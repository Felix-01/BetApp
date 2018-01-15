using System;
using System.Windows.Forms;

namespace BetApp
{
    public partial class AllBetsDetails : Form
    {
        //string connectionString = "Data Source=.;Initial Catalog=BetAppDb;Integrated Security=True";
        public AllBetsDetails()
        {
            InitializeComponent();
        }

        private void AllBetsDetails_Load(object sender, EventArgs e)
        {
            
            this.betDetailsTableAdapter.Fill(this.betAppDbDataSet1.BetDetails);
            //string query = "Select * From BetDetails Order by Date Desc; ";

            //SqlConnection conn = new SqlConnection(connectionString);
            //SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //DataTable dt = new DataTable();

            //da.Fill(dt);

            //dgvBets.DataSource = dt;
        }
    }
}
