
namespace Restaurant
{
    partial class Options
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
            btnDishes = new System.Windows.Forms.Button();
            btnMenu = new System.Windows.Forms.Button();
            btnJournal = new System.Windows.Forms.Button();
            btnOrders = new System.Windows.Forms.Button();
            lblMainFunctions = new System.Windows.Forms.Label();
            lblAdditinolFunctions = new System.Windows.Forms.Label();
            btnCreateClient = new System.Windows.Forms.Button();
            btnMakeOrder = new System.Windows.Forms.Button();
            btnBanquet = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnDishes
            // 
            btnDishes.Location = new System.Drawing.Point(65, 74);
            btnDishes.Margin = new System.Windows.Forms.Padding(4);
            btnDishes.Name = "btnDishes";
            btnDishes.Size = new System.Drawing.Size(260, 41);
            btnDishes.TabIndex = 0;
            btnDishes.Text = "Dishes";
            btnDishes.UseVisualStyleBackColor = true;
            btnDishes.Click += DishesButton_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new System.Drawing.Point(65, 123);
            btnMenu.Margin = new System.Windows.Forms.Padding(4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new System.Drawing.Size(260, 41);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += MenuButton_Click;
            // 
            // btnJournal
            // 
            btnJournal.Location = new System.Drawing.Point(65, 172);
            btnJournal.Margin = new System.Windows.Forms.Padding(4);
            btnJournal.Name = "btnJournal";
            btnJournal.Size = new System.Drawing.Size(260, 41);
            btnJournal.TabIndex = 2;
            btnJournal.Text = "Journal";
            btnJournal.UseVisualStyleBackColor = true;
            btnJournal.Click += JournalButton_Click;
            // 
            // btnOrders
            // 
            btnOrders.Location = new System.Drawing.Point(65, 221);
            btnOrders.Margin = new System.Windows.Forms.Padding(4);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new System.Drawing.Size(260, 41);
            btnOrders.TabIndex = 3;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += OrdersButton_Click;
            // 
            // lblMainFunctions
            // 
            lblMainFunctions.AutoSize = true;
            lblMainFunctions.Location = new System.Drawing.Point(114, 22);
            lblMainFunctions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMainFunctions.Name = "lblMainFunctions";
            lblMainFunctions.Size = new System.Drawing.Size(141, 28);
            lblMainFunctions.TabIndex = 4;
            lblMainFunctions.Text = "Main functions";
            // 
            // lblAdditinolFunctions
            // 
            lblAdditinolFunctions.AutoSize = true;
            lblAdditinolFunctions.Location = new System.Drawing.Point(426, 113);
            lblAdditinolFunctions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAdditinolFunctions.Name = "lblAdditinolFunctions";
            lblAdditinolFunctions.Size = new System.Drawing.Size(189, 28);
            lblAdditinolFunctions.TabIndex = 5;
            lblAdditinolFunctions.Text = "Additional functions";
            // 
            // btnCreateClient
            // 
            btnCreateClient.Location = new System.Drawing.Point(391, 172);
            btnCreateClient.Margin = new System.Windows.Forms.Padding(4);
            btnCreateClient.Name = "btnCreateClient";
            btnCreateClient.Size = new System.Drawing.Size(260, 41);
            btnCreateClient.TabIndex = 6;
            btnCreateClient.Text = "Create client";
            btnCreateClient.UseVisualStyleBackColor = true;
            btnCreateClient.Click += CreateClientButton_Click;
            // 
            // btnMakeOrder
            // 
            btnMakeOrder.Location = new System.Drawing.Point(391, 221);
            btnMakeOrder.Margin = new System.Windows.Forms.Padding(4);
            btnMakeOrder.Name = "btnMakeOrder";
            btnMakeOrder.Size = new System.Drawing.Size(260, 41);
            btnMakeOrder.TabIndex = 7;
            btnMakeOrder.Text = "Make order";
            btnMakeOrder.UseVisualStyleBackColor = true;
            btnMakeOrder.Click += MakeOrderButton_Click;
            // 
            // btnBanquet
            // 
            btnBanquet.Location = new System.Drawing.Point(65, 269);
            btnBanquet.Margin = new System.Windows.Forms.Padding(4);
            btnBanquet.Name = "btnBanquet";
            btnBanquet.Size = new System.Drawing.Size(260, 41);
            btnBanquet.TabIndex = 8;
            btnBanquet.Text = "Banquet";
            btnBanquet.UseVisualStyleBackColor = true;
            btnBanquet.Click += BanquetButton_Click;
            // 
            // Options
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(767, 384);
            Controls.Add(btnBanquet);
            Controls.Add(btnMakeOrder);
            Controls.Add(btnCreateClient);
            Controls.Add(lblAdditinolFunctions);
            Controls.Add(lblMainFunctions);
            Controls.Add(btnOrders);
            Controls.Add(btnJournal);
            Controls.Add(btnMenu);
            Controls.Add(btnDishes);
            Font = new System.Drawing.Font("Segoe UI", 12F);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Options";
            Text = "Options";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnDishes;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnJournal;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Label lblMainFunctions;
        private System.Windows.Forms.Label lblAdditinolFunctions;
        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Button btnBanquet;
    }
}