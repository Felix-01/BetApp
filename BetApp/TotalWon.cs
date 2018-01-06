﻿using System;
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
    public partial class TotalWon : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=BetAppDb;Integrated Security=True";

        public TotalWon()
        {
            InitializeComponent();
        }

        private void TotalWon_Load(object sender, EventArgs e)
        {
            tbxQueryYear.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Select SUM(Amount) As 'Total Amount Won in "+tbxQueryYear.Text+ " (Millions of Euro)' From BetDetails Where Date Like '"+ tbxQueryYear.Text + "%' And Flag = 'True'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTotalWon.DataSource = dt;

            tbxQueryYear.Clear();
            tbxQueryYear.Focus();
        }
    }
}