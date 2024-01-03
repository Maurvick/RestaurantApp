
namespace Restaurant
{
    partial class Display
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
            dgDishes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgDishes).BeginInit();
            SuspendLayout();
            // 
            // dgDishes
            // 
            dgDishes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgDishes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dgDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDishes.Location = new System.Drawing.Point(-1, 0);
            dgDishes.Name = "dgDishes";
            dgDishes.RowHeadersWidth = 51;
            dgDishes.Size = new System.Drawing.Size(782, 404);
            dgDishes.TabIndex = 0;
            // 
            // Display
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(782, 403);
            Controls.Add(dgDishes);
            Name = "Display";
            Text = "Display";
            ((System.ComponentModel.ISupportInitialize)dgDishes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgDishes;
    }
}