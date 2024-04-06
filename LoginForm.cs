using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace Assignment4
{
    public partial class LoginForm : Form
    {
        private const string adminCredentialsPath = @"D:\Application_Dev_using_C#.Net-ITE-5230-IRA\Assignment4\Assignment4\admin.txt";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = tbxUserName.Text; 
            string enteredPassword = tbxPWD.Text; 

            try
            {
                
                string[] credentials = File.ReadAllLines(adminCredentialsPath);
                string[] adminCredentials = credentials[0].Split(':');

                if (adminCredentials.Length == 2)
                {
                    string username = adminCredentials[0];
                    string password = adminCredentials[1];

                   
                    if (enteredUsername == username && enteredPassword == password)
                    {
                      
                        DialogResult = DialogResult.OK;
                        this.Hide();
                        MainForm mainForm = new MainForm();
                        mainForm.FormClosed += (s, args) => this.Close(); // When MainForm is closed, close this form as well
                        mainForm.Show();
                    }
                    else
                    {
                        
                        MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading admin credentials: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
