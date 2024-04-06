namespace Assignment4
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxUserName = new TextBox();
            tbxPWD = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // tbxUserName
            // 
            tbxUserName.Location = new Point(214, 55);
            tbxUserName.Name = "tbxUserName";
            tbxUserName.Size = new Size(333, 30);
            tbxUserName.TabIndex = 0;
            // 
            // tbxPWD
            // 
            tbxPWD.Location = new Point(214, 136);
            tbxPWD.Name = "tbxPWD";
            tbxPWD.Size = new Size(333, 30);
            tbxPWD.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(214, 289);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(435, 289);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 58);
            label1.Name = "label1";
            label1.Size = new Size(76, 24);
            label1.TabIndex = 4;
            label1.Text = "User &ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 139);
            label2.Name = "label2";
            label2.Size = new Size(91, 24);
            label2.TabIndex = 5;
            label2.Text = "&Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(tbxPWD);
            Controls.Add(tbxUserName);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxUserName;
        private TextBox tbxPWD;
        private Button btnLogin;
        private Button btnExit;
        private Label label1;
        private Label label2;
    }
}