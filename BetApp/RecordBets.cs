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
    public partial class RecordBets : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=BetAppDb;Integrated Security=True";
        public RecordBets()
        {
            InitializeComponent();
            tbxHorseName.Focus();           
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
                    tbxHorseName.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to Add Record");
                    btnClear_Click(sender, e);
                    tbxHorseName.Focus();
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
        }
    }
}
