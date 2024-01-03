
namespace Restaurant
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEnter = new System.Windows.Forms.Button();
            txtLogin = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            lblLogin = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.Location = new System.Drawing.Point(233, 281);
            btnEnter.Margin = new System.Windows.Forms.Padding(4);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new System.Drawing.Size(131, 40);
            btnEnter.TabIndex = 0;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += EnterButton_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new System.Drawing.Point(153, 110);
            txtLogin.Margin = new System.Windows.Forms.Padding(4);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new System.Drawing.Size(330, 34);
            txtLogin.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(153, 199);
            txtPassword.Margin = new System.Windows.Forms.Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(330, 34);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new System.Drawing.Point(153, 76);
            lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new System.Drawing.Size(61, 28);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "Login";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(153, 166);
            lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(93, 28);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(638, 367);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(btnEnter);
            Font = new System.Drawing.Font("Segoe UI", 12F);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Login";
            Text = "Authorization";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
    }
}

