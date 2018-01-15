using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BetApp
{
    public partial class Login : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=BetAppDb;Integrated Security=True";
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "Select * From Login Where UserName ='" + tbxUName.Text+"' And Password = '"+tbxPword.Text+"'";
            SqlConnection conn = new SqlConnection(connectionString);
          
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                MasterPage mPage = new MasterPage();
                mPage.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Incorrect Credentials");
                tbxUName.Clear();
                tbxPword.Clear();
                tbxUName.Focus();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterNewUser registerNewUser = new RegisterNewUser();
            registerNewUser.Show();
            this.Hide();
        }
    }
}
