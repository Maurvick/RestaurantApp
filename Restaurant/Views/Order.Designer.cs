
namespace Restaurant
{
    partial class Order
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
            cmbDishes = new System.Windows.Forms.ComboBox();
            cmbType = new System.Windows.Forms.ComboBox();
            btnCreate = new System.Windows.Forms.Button();
            lblDish = new System.Windows.Forms.Label();
            lblType = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // cmbDishes
            // 
            cmbDishes.FormattingEnabled = true;
            cmbDishes.Location = new System.Drawing.Point(110, 74);
            cmbDishes.Margin = new System.Windows.Forms.Padding(4);
            cmbDishes.Name = "cmbDishes";
            cmbDishes.Size = new System.Drawing.Size(610, 36);
            cmbDishes.TabIndex = 0;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new System.Drawing.Point(111, 157);
            cmbType.Margin = new System.Windows.Forms.Padding(4);
            cmbType.Name = "cmbType";
            cmbType.Size = new System.Drawing.Size(609, 36);
            cmbType.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(300, 232);
            btnCreate.Margin = new System.Windows.Forms.Padding(4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(194, 41);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblDish
            // 
            lblDish.AutoSize = true;
            lblDish.Location = new System.Drawing.Point(111, 42);
            lblDish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDish.Name = "lblDish";
            lblDish.Size = new System.Drawing.Size(50, 28);
            lblDish.TabIndex = 3;
            lblDish.Text = "Dish";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new System.Drawing.Point(111, 125);
            lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblType.Name = "lblType";
            lblType.Size = new System.Drawing.Size(53, 28);
            lblType.TabIndex = 4;
            lblType.Text = "Type";
            // 
            // Order
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(833, 302);
            Controls.Add(lblType);
            Controls.Add(lblDish);
            Controls.Add(btnCreate);
            Controls.Add(cmbType);
            Controls.Add(cmbDishes);
            Font = new System.Drawing.Font("Segoe UI", 12F);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Order";
            Text = "Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDishes;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblDish;
        private System.Windows.Forms.Label lblType;
    }
}