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
    public partial class MostPopularRaceCourse : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=BetAppDb;Integrated Security=True";

        public MostPopularRaceCourse()
        {
            InitializeComponent();
        }

        private void MostPopularRaceCourse_Load(object sender, EventArgs e)
        {
            string query = "SELECT TOP 1 RaceCourse As 'Most Popular RaceCourse'FROM BetDetails GROUP BY RaceCourse ORDER BY COUNT(RaceCourse) DESC";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMostPopularRC.DataSource = dt;
        }
    }
}
