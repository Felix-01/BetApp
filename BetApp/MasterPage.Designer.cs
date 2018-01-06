namespace BetApp
{
    partial class MasterPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recordBetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retrieveAllBetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalBetsWonLostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalWonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalLostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostPopularRaceCourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betsInDateOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highestBetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfRacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betAppDbDataSet = new BetApp.BetAppDbDataSet();
            this.betDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.betDetailsTableAdapter = new BetApp.BetAppDbDataSetTableAdapters.BetDetailsTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAppDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordBetToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recordBetToolStripMenuItem
            // 
            this.recordBetToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordBetToolStripMenuItem.Name = "recordBetToolStripMenuItem";
            this.recordBetToolStripMenuItem.Size = new System.Drawing.Size(86, 21);
            this.recordBetToolStripMenuItem.Text = "Record Bet";
            this.recordBetToolStripMenuItem.Click += new System.EventHandler(this.recordBetToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retrieveAllBetsToolStripMenuItem,
            this.totalBetsWonLostToolStripMenuItem,
            this.mostPopularRaceCourceToolStripMenuItem,
            this.betsInDateOrderToolStripMenuItem,
            this.highestBetsToolStripMenuItem,
            this.numberOfRacesToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // retrieveAllBetsToolStripMenuItem
            // 
            this.retrieveAllBetsToolStripMenuItem.Name = "retrieveAllBetsToolStripMenuItem";
            this.retrieveAllBetsToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.retrieveAllBetsToolStripMenuItem.Text = "Retrieve All Bets";
            this.retrieveAllBetsToolStripMenuItem.Click += new System.EventHandler(this.retrieveAllBetsToolStripMenuItem_Click);
            // 
            // totalBetsWonLostToolStripMenuItem
            // 
            this.totalBetsWonLostToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalWonToolStripMenuItem,
            this.totalLostToolStripMenuItem});
            this.totalBetsWonLostToolStripMenuItem.Name = "totalBetsWonLostToolStripMenuItem";
            this.totalBetsWonLostToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.totalBetsWonLostToolStripMenuItem.Text = "Total Bets Won/Lost";
            this.totalBetsWonLostToolStripMenuItem.Click += new System.EventHandler(this.totalBetsWonLostToolStripMenuItem_Click);
            // 
            // totalWonToolStripMenuItem
            // 
            this.totalWonToolStripMenuItem.Name = "totalWonToolStripMenuItem";
            this.totalWonToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.totalWonToolStripMenuItem.Text = "Total Won";
            this.totalWonToolStripMenuItem.Click += new System.EventHandler(this.totalWonToolStripMenuItem_Click);
            // 
            // totalLostToolStripMenuItem
            // 
            this.totalLostToolStripMenuItem.Name = "totalLostToolStripMenuItem";
            this.totalLostToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.totalLostToolStripMenuItem.Text = "Total Lost";
            this.totalLostToolStripMenuItem.Click += new System.EventHandler(this.totalLostToolStripMenuItem_Click);
            // 
            // mostPopularRaceCourceToolStripMenuItem
            // 
            this.mostPopularRaceCourceToolStripMenuItem.Name = "mostPopularRaceCourceToolStripMenuItem";
            this.mostPopularRaceCourceToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.mostPopularRaceCourceToolStripMenuItem.Text = "Most Popular Race Cource";
            this.mostPopularRaceCourceToolStripMenuItem.Click += new System.EventHandler(this.mostPopularRaceCourceToolStripMenuItem_Click);
            // 
            // betsInDateOrderToolStripMenuItem
            // 
            this.betsInDateOrderToolStripMenuItem.Name = "betsInDateOrderToolStripMenuItem";
            this.betsInDateOrderToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.betsInDateOrderToolStripMenuItem.Text = "Bets In Date Order";
            this.betsInDateOrderToolStripMenuItem.Click += new System.EventHandler(this.betsInDateOrderToolStripMenuItem_Click);
            // 
            // highestBetsToolStripMenuItem
            // 
            this.highestBetsToolStripMenuItem.Name = "highestBetsToolStripMenuItem";
            this.highestBetsToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.highestBetsToolStripMenuItem.Text = "Highest Bets";
            this.highestBetsToolStripMenuItem.Click += new System.EventHandler(this.highestBetsToolStripMenuItem_Click);
            // 
            // numberOfRacesToolStripMenuItem
            // 
            this.numberOfRacesToolStripMenuItem.Name = "numberOfRacesToolStripMenuItem";
            this.numberOfRacesToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.numberOfRacesToolStripMenuItem.Text = "Number of Races";
            this.numberOfRacesToolStripMenuItem.Click += new System.EventHandler(this.numberOfRacesToolStripMenuItem_Click);
            // 
            // betAppDbDataSet
            // 
            this.betAppDbDataSet.DataSetName = "BetAppDbDataSet";
            this.betAppDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // betDetailsBindingSource
            // 
            this.betDetailsBindingSource.DataMember = "BetDetails";
            this.betDetailsBindingSource.DataSource = this.betAppDbDataSet;
            // 
            // betDetailsTableAdapter
            // 
            this.betDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // MasterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(699, 439);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MasterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Page";
            this.Load += new System.EventHandler(this.MasterPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAppDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recordBetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retrieveAllBetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalBetsWonLostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostPopularRaceCourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betsInDateOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highestBetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfRacesToolStripMenuItem;
        private BetAppDbDataSet betAppDbDataSet;
        private System.Windows.Forms.BindingSource betDetailsBindingSource;
        private BetAppDbDataSetTableAdapters.BetDetailsTableAdapter betDetailsTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem totalWonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalLostToolStripMenuItem;
    }
}



