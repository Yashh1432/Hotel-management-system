using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace HOTELMANAGEMENT
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-L6GFUGE\YASH;Initial Catalog=hotel;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();  

        public Form1()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

            conn.Close();
           

            cmd = new SqlCommand("SELECT * FROM tblLogin where Username='" + txtusername.Text + "'", conn);
            SqlDataReader dr;

            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (txtusername.Text == "ADMMIN" && txtpassword.Text == "admin")
                {
                    homepage h  = new homepage(); 
                    h.Show();
                    
                }

            }
            else
            {

                MessageBox.Show("Invalid Username of Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Clear();
                txtusername.Clear();
                txtusername.Focus();
            }

            conn.Close();


        }

        private void checkBoxshowpassword_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxshowpassword.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '.';
            }
        }
    }
}
