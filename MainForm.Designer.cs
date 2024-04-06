namespace Assignment4
{
    partial class MainForm
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
            listBoxAccount = new ListBox();
            btnView = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // listBoxAccount
            // 
            listBoxAccount.FormattingEnabled = true;
            listBoxAccount.HorizontalScrollbar = true;
            listBoxAccount.ItemHeight = 24;
            listBoxAccount.Location = new Point(21, 29);
            listBoxAccount.Name = "listBoxAccount";
            listBoxAccount.ScrollAlwaysVisible = true;
            listBoxAccount.Size = new Size(893, 364);
            listBoxAccount.TabIndex = 0;
            // 
            // btnView
            // 
            btnView.Location = new Point(984, 70);
            btnView.Name = "btnView";
            btnView.Size = new Size(152, 34);
            btnView.TabIndex = 1;
            btnView.Text = "&View Details";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click_1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(984, 194);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(152, 34);
            btnExit.TabIndex = 2;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 450);
            Controls.Add(btnExit);
            Controls.Add(btnView);
            Controls.Add(listBoxAccount);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxAccount;
        private Button btnView;
        private Button btnExit;
    }
}