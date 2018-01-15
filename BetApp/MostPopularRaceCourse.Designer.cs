namespace BetApp
{
    partial class MostPopularRaceCourse
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
            this.dgvMostPopularRC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostPopularRC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostPopularRC
            // 
            this.dgvMostPopularRC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostPopularRC.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.dgvMostPopularRC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostPopularRC.Location = new System.Drawing.Point(177, 57);
            this.dgvMostPopularRC.Name = "dgvMostPopularRC";
            this.dgvMostPopularRC.Size = new System.Drawing.Size(344, 150);
            this.dgvMostPopularRC.TabIndex = 0;
            // 
            // MostPopularRaceCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(699, 439);
            this.Controls.Add(this.dgvMostPopularRC);
            this.Name = "MostPopularRaceCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Most Popular Race Course";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MostPopularRaceCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostPopularRC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostPopularRC;
    }
}