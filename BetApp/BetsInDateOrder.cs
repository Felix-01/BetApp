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
    public partial class BetsInDateOrder : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=BetAppDb;Integrated Security=True";

        public BetsInDateOrder()
        {
            InitializeComponent();
        }

        private void BetsInDateOrder_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM BetDetails ORDER BY Date Desc;";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvBetsInDateOrder.DataSource = dt;
        }
    }
}
