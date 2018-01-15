using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BetApp
{
    public partial class RegisterNewUser : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=BetAppDb;Integrated Security=True";

        public RegisterNewUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "Insert Into Login Values('" + tbxUname.Text + "', '" + tbxPassword.Text + "')";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, conn);

            if(tbxPassword.Text == tbxConfPassword.Text)
            {
                conn.Open();
                int count = cmd.ExecuteNonQuery();
                conn.Close();

                if(count == 1)
                {
                    MessageBox.Show("Registration Successfull");
                    MasterPage masterPage = new MasterPage();
                    masterPage.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registration Failed. Contact Your IT Administrator");
                }
            }
            else
            {
                MessageBox.Show("Password and Confirm Password do not match");
                tbxConfPassword.Clear();
                tbxConfPassword.Focus();
            }
        }

        private void RegisterNewUser_Load(object sender, EventArgs e)
        {
            tbxUname.Focus();
        }
    }
}
