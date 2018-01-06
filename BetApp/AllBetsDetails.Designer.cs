namespace BetApp
{
    partial class AllBetsDetails
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
            this.components = new System.ComponentModel.Container();
            this.dgvBets = new System.Windows.Forms.DataGridView();
            this.horseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.betDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.betAppDbDataSet1 = new BetApp.BetAppDbDataSet1();
            this.betDetailsTableAdapter = new BetApp.BetAppDbDataSet1TableAdapters.BetDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAppDbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBets
            // 
            this.dgvBets.AutoGenerateColumns = false;
            this.dgvBets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvBets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.horseNameDataGridViewTextBoxColumn,
            this.raceCourseDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.flagDataGridViewCheckBoxColumn});
            this.dgvBets.DataSource = this.betDetailsBindingSource;
            this.dgvBets.Location = new System.Drawing.Point(79, 36);
            this.dgvBets.Name = "dgvBets";
            this.dgvBets.Size = new System.Drawing.Size(543, 357);
            this.dgvBets.TabIndex = 0;
            // 
            // horseNameDataGridViewTextBoxColumn
            // 
            this.horseNameDataGridViewTextBoxColumn.DataPropertyName = "HorseName";
            this.horseNameDataGridViewTextBoxColumn.HeaderText = "HorseName";
            this.horseNameDataGridViewTextBoxColumn.Name = "horseNameDataGridViewTextBoxColumn";
            // 
            // raceCourseDataGridViewTextBoxColumn
            // 
            this.raceCourseDataGridViewTextBoxColumn.DataPropertyName = "RaceCourse";
            this.raceCourseDataGridViewTextBoxColumn.HeaderText = "RaceCourse";
            this.raceCourseDataGridViewTextBoxColumn.Name = "raceCourseDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // flagDataGridViewCheckBoxColumn
            // 
            this.flagDataGridViewCheckBoxColumn.DataPropertyName = "Flag";
            this.flagDataGridViewCheckBoxColumn.HeaderText = "Flag";
            this.flagDataGridViewCheckBoxColumn.Name = "flagDataGridViewCheckBoxColumn";
            // 
            // betDetailsBindingSource
            // 
            this.betDetailsBindingSource.DataMember = "BetDetails";
            this.betDetailsBindingSource.DataSource = this.betAppDbDataSet1;
            // 
            // betAppDbDataSet1
            // 
            this.betAppDbDataSet1.DataSetName = "BetAppDbDataSet1";
            this.betAppDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // betDetailsTableAdapter
            // 
            this.betDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // AllBetsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(699, 439);
            this.Controls.Add(this.dgvBets);
            this.Name = "AllBetsDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details of All Bets";
            this.Load += new System.EventHandler(this.AllBetsDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAppDbDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBets;
        private BetAppDbDataSet1 betAppDbDataSet1;
        private System.Windows.Forms.BindingSource betDetailsBindingSource;
        private BetAppDbDataSet1TableAdapters.BetDetailsTableAdapter betDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn horseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn flagDataGridViewCheckBoxColumn;
    }
}