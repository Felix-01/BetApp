using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetApp
{
    public partial class MasterPage : Form
    {
       // string connectionString = "Data Source=.;Initial Catalog=BetAppDb;Integrated Security=True";
        
        public MasterPage()
        {
            InitializeComponent();
        }

        private void recordBetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordBets rbets = new RecordBets();
            rbets.Show();
        }

        private void retrieveAllBetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllBetsDetails allBets = new AllBetsDetails();
            allBets.Show();
        }

        private void MasterPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'betAppDbDataSet.BetDetails' table. You can move, or remove it, as needed.
            

        }

        private void totalBetsWonLostToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void totalWonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TotalWon totalWon = new TotalWon();
            totalWon.Show();             
                     
            

        }

        private void totalLostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TotalLost totalLost = new TotalLost();
            totalLost.Show();
        }

        private void mostPopularRaceCourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostPopularRaceCourse mprc = new MostPopularRaceCourse();
            mprc.Show();
        }

        private void betsInDateOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BetsInDateOrder betsInDateOrder = new BetsInDateOrder();
            betsInDateOrder.Show();
        }

        private void highestBetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighestBet highestBet = new HighestBet();
            highestBet.Show();
        }

        private void numberOfRacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumberOfRaces numberOfRaces = new NumberOfRaces();
            numberOfRaces.Show();
        }
    }
}
