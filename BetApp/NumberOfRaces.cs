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
    public partial class NumberOfRaces : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=BetAppDb;Integrated Security=True";

        public NumberOfRaces()
        {
            InitializeComponent();
        }

        private void NumberOfRaces_Load(object sender, EventArgs e)
        {
            string query = "Select Count(RaceCourse) As 'Total Number Of Races To Date' From BetDetails";
            string query2 = "Select Count(RaceCourse) As 'Total Number Of Races Won To Date' From BetDetails Where Flag = 'True'";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvRacesToDate.DataSource = dt;
            

            SqlDataAdapter dapt = new SqlDataAdapter(query2, conn);
            DataTable dtbl = new DataTable();
            dapt.Fill(dtbl);

            dgvRacesWonToDate.DataSource = dtbl;

        }
    }
}
