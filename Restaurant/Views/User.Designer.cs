
namespace Restaurant
{
    partial class NewUser
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
            txtLogin = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            lblLogin = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new System.Drawing.Point(89, 61);
            txtLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new System.Drawing.Size(480, 34);
            txtLogin.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(89, 142);
            txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(480, 34);
            txtPassword.TabIndex = 1;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new System.Drawing.Point(89, 29);
            lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new System.Drawing.Size(61, 28);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(89, 110);
            lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(93, 28);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(223, 213);
            btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(172, 41);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += AddUserButton_Click;
            // 
            // NewUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(644, 285);
            Controls.Add(btnAdd);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Font = new System.Drawing.Font("Segoe UI", 12F);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "NewUser";
            Text = "New user";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnAdd;
    }
}