namespace BetApp
{
    partial class TotalWon
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
            this.dgvTotalWon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxQueryYear = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalWon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTotalWon
            // 
            this.dgvTotalWon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTotalWon.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.dgvTotalWon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalWon.Location = new System.Drawing.Point(73, 72);
            this.dgvTotalWon.Name = "dgvTotalWon";
            this.dgvTotalWon.Size = new System.Drawing.Size(562, 159);
            this.dgvTotalWon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(416, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Year of Interest";
            // 
            // tbxQueryYear
            // 
            this.tbxQueryYear.Location = new System.Drawing.Point(535, 31);
            this.tbxQueryYear.Name = "tbxQueryYear";
            this.tbxQueryYear.Size = new System.Drawing.Size(100, 20);
            this.tbxQueryYear.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(73, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(562, 70);
            this.button1.TabIndex = 3;
            this.button1.Text = "Get Value";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TotalWon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(699, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxQueryYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTotalWon);
            this.Name = "TotalWon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total Won";
            this.Load += new System.EventHandler(this.TotalWon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalWon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTotalWon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxQueryYear;
        private System.Windows.Forms.Button button1;
    }
}