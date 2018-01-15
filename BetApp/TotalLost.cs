using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BetApp
{
    public partial class TotalLost : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=BetAppDb;Integrated Security=True";

        public TotalLost()
        {
            InitializeComponent();
        }

        private void TotalLost_Load(object sender, EventArgs e)
        {
            tbxQueryYear.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Select SUM(Amount) As 'Total Amount Lost in " + tbxQueryYear.Text + " (Millions of Euro)' From BetDetails Where Date Like '" + tbxQueryYear.Text + "%' And Flag = 'False'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTotalLost.DataSource = dt;

            tbxQueryYear.Clear();
            tbxQueryYear.Focus();
        }
    }
}
