using Assignment4.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            using (var context = new MMABooksContext())
            {
                var accountDetails = context.Accounts.ToList();

                if (accountDetails.Any())
                {
                    var accountDisplayList = accountDetails.Select(a =>
                        $"AccountId: {a.AccountId}, Type: {a.AccountType}, User ID: {a.UserId}, Balance: {a.CurrentBalance:C}, Created: {a.DateCreated:g}").ToList();

                    listBoxAccount.DataSource = accountDisplayList;
                }
                else
                {
                    MessageBox.Show("No account data available.");
                }
            }
        }


        private void btnView_Click_1(object sender, EventArgs e)
        {
            var selectedAccountInfo = listBoxAccount.SelectedItem.ToString();


            var accountIdString = selectedAccountInfo.Split(new[] { "AccountId: " }, StringSplitOptions.None)[1].Split(',')[0].Trim();



            if (int.TryParse(accountIdString, out int accountId))
            {
                this.Hide();
                TransactionsForm transactionsForm = new TransactionsForm(accountId);
                MessageBox.Show($"You have seleceted Account ID: {accountId}");
                transactionsForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Please select a valid account.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
