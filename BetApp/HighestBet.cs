using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BetApp
{
    public partial class HighestBet : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=BetAppDb;Integrated Security=True";

        public HighestBet()
        {
            InitializeComponent();
        }

        private void HighestBet_Load(object sender, EventArgs e)
        {
            string query = "Select HorseName As 'Horse Name', RaceCourse As 'Race Course', Date, Amount As 'Amount In Millions of Euro', Flag From BetDetails Where Amount = (Select Distinct Top(1) Max(Amount) From BetDetails Where Flag = 'True' )";
            string query1 = "Select HorseName As 'Horse Name', RaceCourse As 'Race Course', Date, Amount As 'Amount In Millions of Euro', Flag From BetDetails Where Amount = (Select Distinct Top(1) Max(Amount) From BetDetails Where Flag = 'False' )";

            SqlConnection conn = new SqlConnection(connectionString);

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHighestBetWon.DataSource = dt;

            SqlDataAdapter dap = new SqlDataAdapter(query1, conn);
            DataTable dtb = new DataTable();
            dap.Fill(dtb);
            dgvHighestBetLost.DataSource = dtb;
        }
    }
}
