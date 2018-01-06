namespace BetApp
{
    partial class NumberOfRaces
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRacesToDate = new System.Windows.Forms.DataGridView();
            this.dgvRacesWonToDate = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacesToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacesWonToDate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(271, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Races Won Till Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(266, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Number Of Races Till Date";
            // 
            // dgvRacesToDate
            // 
            this.dgvRacesToDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacesToDate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvRacesToDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacesToDate.Location = new System.Drawing.Point(185, 46);
            this.dgvRacesToDate.Name = "dgvRacesToDate";
            this.dgvRacesToDate.Size = new System.Drawing.Size(354, 58);
            this.dgvRacesToDate.TabIndex = 3;
            // 
            // dgvRacesWonToDate
            // 
            this.dgvRacesWonToDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacesWonToDate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvRacesWonToDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacesWonToDate.Location = new System.Drawing.Point(185, 174);
            this.dgvRacesWonToDate.Name = "dgvRacesWonToDate";
            this.dgvRacesWonToDate.Size = new System.Drawing.Size(354, 56);
            this.dgvRacesWonToDate.TabIndex = 4;
            // 
            // NumberOfRaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(699, 439);
            this.Controls.Add(this.dgvRacesWonToDate);
            this.Controls.Add(this.dgvRacesToDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NumberOfRaces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Of Races";
            this.Load += new System.EventHandler(this.NumberOfRaces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacesToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacesWonToDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRacesToDate;
        private System.Windows.Forms.DataGridView dgvRacesWonToDate;
    }
}