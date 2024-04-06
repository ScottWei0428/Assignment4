using Assignment4.Models.Entities;
using Microsoft.Identity.Client;
using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment4; 

namespace Assignment4
{
    public partial class TransactionsForm : Form
    {

        private int _accountId;
        public TransactionsForm(int accountId)
        {
            InitializeComponent();
            _accountId = accountId;
            dataGridView1.CellValidating += new DataGridViewCellValidatingEventHandler(dataGridView1_CellValidating);
        }

        private void LoadTransactions()
        {
            var transactionsList = AccountDB.GetTransactionsForAccount(_accountId);


            MessageBox.Show($"Number of transactions: {transactionsList.Count}");

            dataGridView1.DataSource = transactionsList;
            dataGridView1.Refresh();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            var newTransaction = new TransactionHistory
            {
                AccountId = _accountId,
                TransactionDate = DateTime.Now,
                Amount = 100M,
                Description = "New Transaction"
            };

            AccountDB.AddTransaction(newTransaction);
            LoadTransactions();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText = dataGridView1.Columns[e.ColumnIndex].HeaderText;

            
            if (dataGridView1.Rows[e.RowIndex].IsNewRow) { return; }

            
            if (headerText.Equals("Amount"))
            {
                if (!decimal.TryParse(e.FormattedValue.ToString(), out decimal _))
                {
                    e.Cancel = true;
                    MessageBox.Show("Amount must be a decimal number.");
                }
            }
            
            else if (headerText.Equals("TransactionDate"))
            {
                if (!DateTime.TryParse(e.FormattedValue.ToString(), out DateTime _))
                {
                    e.Cancel = true;
                    MessageBox.Show("Transaction Date must be a valid date in the format MM/DD/YYYY.");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var transactionsToUpdate = new List<TransactionHistory>();
            var transactionIds = new HashSet<int>();
            bool hasDuplicateId = false;
            bool isValid = true; 

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue; 

        
                if (!int.TryParse(Convert.ToString(row.Cells["TransactionId"].Value), out int transactionId))
                {
                    MessageBox.Show("Transaction ID must be an integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                    break; 
                }

                
                if (!int.TryParse(Convert.ToString(row.Cells["AccountId"].Value), out _))
                {
                    MessageBox.Show("Account ID must be an integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                    break; 
                }

                
                if (!decimal.TryParse(Convert.ToString(row.Cells["Amount"].Value), out decimal amount))
                {
                    MessageBox.Show("Amount must be a decimal number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                    break; 
                }

                
                if (!DateTime.TryParse(Convert.ToString(row.Cells["TransactionDate"].Value), out DateTime transactionDate))
                {
                    MessageBox.Show("Transaction Date must be a valid date in the format MM/DD/YYYY.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                    break; 
                }

              
                if (!transactionIds.Add(transactionId))
                {
                    MessageBox.Show($"Duplicate Transaction ID found: {transactionId}. Update canceled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    hasDuplicateId = true;
                    break; 
                }

             
                if (isValid && !hasDuplicateId)
                {
                    var transaction = new TransactionHistory
                    {
                        TransactionId = transactionId,
                        AccountId = Convert.ToInt32(row.Cells["AccountId"].Value),
                        Amount = amount,
                        Description = Convert.ToString(row.Cells["Description"].Value),
                        TransactionDate = transactionDate
                    };

                    transactionsToUpdate.Add(transaction);
                }
            }

            
            if (!isValid || hasDuplicateId)
            {
                LoadTransactions();
                return; 
            }

           
            foreach (var transaction in transactionsToUpdate)
            {
                AccountDB.UpdateTransactions(_accountId, transactionsToUpdate);
            }
            LoadTransactions(); 
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var transactionId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TransactionId"].Value);
                AccountDB.DeleteTransaction(transactionId);
                LoadTransactions();
            }
        }



        private void Transactions_Load_1(object sender, EventArgs e)
        {
            LoadTransactions();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            
            if (dataGridView1.Columns["AccountId"] != null)
            {
                dataGridView1.Columns["AccountId"].ReadOnly = true; 
                dataGridView1.Columns["AccountId"].DefaultCellStyle.BackColor = Color.LightGray;
            }
            if (dataGridView1.Columns["TransactionId"] != null)
            {
                dataGridView1.Columns["TransactionId"].ReadOnly = true;
                dataGridView1.Columns["TransactionId"].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

    }
}
