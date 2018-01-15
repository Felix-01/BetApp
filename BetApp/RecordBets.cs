using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BetApp
{
    public partial class RecordBets : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=BetAppDb;Integrated Security=True";
        public RecordBets()
        {
            InitializeComponent();                     
        }

        private void btnRecordBet_Click(object sender, EventArgs e)
        {
            int count = 0;            
            string query = "Insert Into BetDetails Values('"+tbxHorseName.Text+"', '"+tbxRaceCourse.Text+"', '"+dateTimePicker1.Text+"', '"+tbxAmount.Text.ToString()+"', '"+cmBxFlag.Text+"')";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            
            conn.Open();
                        
            try
            {
                count = cmd.ExecuteNonQuery();
                
                if (count == 1)
                {
                    MessageBox.Show("Record Successfully Added");
                    btnClear_Click(sender, e);
                    
                }
                else
                {
                    MessageBox.Show("Failed to Add Record");
                    btnClear_Click(sender, e);
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxAmount.Clear();
            tbxHorseName.Clear();
            tbxRaceCourse.Clear();
            cmBxFlag.Text = "";

            tbxHorseName.Focus();
        }

        private void RecordBets_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            tbxHorseName.Focus();
        }
    }
}
