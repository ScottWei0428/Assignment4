using Assignment4.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assignment4
{
    public class AccountDB
    {
        public static List<TransactionHistory> GetTransactionsForAccount(int accountId)
        {
            try
            {
                using (var context = new MMABooksContext())
                {
                    return context.TransactionHistories
                                   .Where(t => t.AccountId == accountId)
                                   .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching transactions: {ex.Message}");
                return new List<TransactionHistory>(); 
            }
        }

        public static void AddTransaction(TransactionHistory transaction)
        {
            using (var context = new MMABooksContext())
            {
                context.TransactionHistories.Add(transaction);
                context.SaveChanges();
            }
        }

        public static void UpdateTransactions(int accountId, List<TransactionHistory> updatedTransactions)
        {
            using (var context = new MMABooksContext())
            {
               
                var existingTransactions = context.TransactionHistories
                                                  .Where(t => t.AccountId == accountId)
                                                  .ToList();

                foreach (var updatedTransaction in updatedTransactions)
                {
                    
                    var existingTransaction = existingTransactions
                                                  .SingleOrDefault(t => t.TransactionId == updatedTransaction.TransactionId);

                    if (existingTransaction != null)
                    {
                        
                        context.Entry(existingTransaction).CurrentValues.SetValues(updatedTransaction);
                    }
                    else
                    {
                        MessageBox.Show($"Transaction with ID {updatedTransaction.TransactionId} not found, cannot update.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                
                context.SaveChanges();
            }
        }


        public static void DeleteTransaction(int transactionId)
        {
            using (var context = new MMABooksContext())
            {
                // Find the transaction to be deleted
                var transactionToDelete = context.TransactionHistories.Find(transactionId);
                if (transactionToDelete != null)
                {
                    // Remove the transaction from the context
                    context.TransactionHistories.Remove(transactionToDelete);

                    // Save changes to the database
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Transaction not found, cannot delete.");
                }
            }
        }

    }
}