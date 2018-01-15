namespace BetApp
{
    partial class BetsInDateOrder
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
            this.dgvBetsInDateOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBetsInDateOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBetsInDateOrder
            // 
            this.dgvBetsInDateOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBetsInDateOrder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBetsInDateOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBetsInDateOrder.Location = new System.Drawing.Point(57, 49);
            this.dgvBetsInDateOrder.Name = "dgvBetsInDateOrder";
            this.dgvBetsInDateOrder.Size = new System.Drawing.Size(638, 337);
            this.dgvBetsInDateOrder.TabIndex = 0;
            // 
            // BetsInDateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(751, 439);
            this.Controls.Add(this.dgvBetsInDateOrder);
            this.Name = "BetsInDateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bet Details Ordered By Date";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BetsInDateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBetsInDateOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBetsInDateOrder;
    }
}