using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiwiBike4Rent.userManagement
{
    public partial class AddStaffForm : Form
    {
        public AddStaffForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.KiwiBike4Rent))
            {
                connection.Open();
                string query = "INSERT INTO STAFF VALUES" +
                    " (@Name,@UserName,@tel,@extNumber, @password, @address," +
                    " @officeAddress,'staff', 'check-out')";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@name", txtName.Text);
                sqlCommand.Parameters.AddWithValue("@UserName", txtUsername.Text);
                sqlCommand.Parameters.AddWithValue("@tel", txtTel.Text);
                sqlCommand.Parameters.AddWithValue("@extNumber", txtExtNumber.Text);
                sqlCommand.Parameters.AddWithValue("@password", txtPassword.Text);
                sqlCommand.Parameters.AddWithValue("@address", txtAddress.Text);
                sqlCommand.Parameters.AddWithValue("@OfficeAddress", txtOfficeAddress.Text);
                //add change usertype&role capability if admin function avaliable
                try
                {
                    if (1 == sqlCommand.ExecuteNonQuery())
                    {
                        MessageBox.Show("Staff Added!", "Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (SqlException sqlE)
                {
                    MessageBox.Show("Something Wrong!!!\n"+sqlE.Message,"SQL Exception",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddStaffForm_Load(object sender, EventArgs e)
        {

        }
    }
}
