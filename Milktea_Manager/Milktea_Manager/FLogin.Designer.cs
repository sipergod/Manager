namespace Milktea_Manager
{
    partial class FLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_UserName = new System.Windows.Forms.Label();
            this.Txb_UserName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Txb_Password = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Exit);
            this.panel1.Controls.Add(this.Btn_Login);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Txb_UserName);
            this.panel2.Controls.Add(this.Lbl_UserName);
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 30);
            this.panel2.TabIndex = 0;
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.AutoSize = true;
            this.Lbl_UserName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UserName.Location = new System.Drawing.Point(4, 4);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.Size = new System.Drawing.Size(89, 19);
            this.Lbl_UserName.TabIndex = 0;
            this.Lbl_UserName.Text = "UserName :";
            // 
            // Txb_UserName
            // 
            this.Txb_UserName.Location = new System.Drawing.Point(100, 5);
            this.Txb_UserName.Name = "Txb_UserName";
            this.Txb_UserName.Size = new System.Drawing.Size(365, 20);
            this.Txb_UserName.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Txb_Password);
            this.panel3.Controls.Add(this.Lbl_Password);
            this.panel3.Location = new System.Drawing.Point(5, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(470, 30);
            this.panel3.TabIndex = 1;
            // 
            // Txb_Password
            // 
            this.Txb_Password.Location = new System.Drawing.Point(100, 5);
            this.Txb_Password.Name = "Txb_Password";
            this.Txb_Password.Size = new System.Drawing.Size(365, 20);
            this.Txb_Password.TabIndex = 1;
            this.Txb_Password.UseSystemPasswordChar = true;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Password.Location = new System.Drawing.Point(4, 4);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(89, 19);
            this.Lbl_Password.TabIndex = 0;
            this.Lbl_Password.Text = "Password  :";
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(311, 73);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(75, 23);
            this.Btn_Login.TabIndex = 2;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(401, 73);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Exit.TabIndex = 3;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 101);
            this.Controls.Add(this.panel1);
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Txb_Password;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Txb_UserName;
        private System.Windows.Forms.Label Lbl_UserName;
    }
}

