using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HOTELMANAGEMENT
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=ZEELRAJPARA\ZEEL;Initial Catalog=HOTELMANAGEMENT;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        private void Dashboard_Load(object sender, EventArgs e)
        {
            bind();
        }
        private void bind()
        { 
            DataTable dt = new DataTable();
            SqlDataAdapter da= new SqlDataAdapter();
            conn.Close();
            da= new SqlDataAdapter("select * from tblrooms;",conn);
            conn.Open();
            da.Fill(dt);        
            conn.Close();
            dataGridView3.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbtnAC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Rtype = "";
            if (rbtnAC.Checked == true)
            {
                Rtype = rbtnAC.Text;
            }
            else if (rbtnNonac.Checked == true)
            {
                Rtype = rbtnNonac.Text;
            }
            

            String bad = "";
            if (comboBox1.SelectedValue == "Single Bad")
            {
                bad = comboBox1.Text;
            }
            else if (comboBox1.SelectedValue == "Double Bad")
            {
                bad = comboBox1.Text;
            }
            else if (comboBox1.SelectedValue == "Triple Bad")
            {
                bad = comboBox1.Text;
            }


            conn.Close();
            cmd = new SqlCommand("insert into tblrooms values('" + txtRoomno.Text + "','" + Rtype + "','" + bad.ToUpper() + "'," + txtPrice.Text + ");", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Room Added Successfull..!! ");

            txtRoomno.Clear();
            txtPrice.Clear();
            comboBox1.Items.Clear();
            rbtnNonac.Checked = false;
            rbtnAC.Checked = false;
            bad.Clone();

            bind();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Rtype = "";
            if (rbtnAC.Checked == true)
            {
                Rtype = rbtnAC.Text;
            }
            else if (rbtnNonac.Checked == true)
            {
                Rtype = rbtnNonac.Text;
            }


            String bad = "";
            if (comboBox1.SelectedIndex == 1)
            {
                bad = "Singal bad";
            }
            else if (comboBox1.SelectedValue == "Double Bad")
            {
                bad = comboBox1.Text;   
            }
            else if (comboBox1.SelectedValue == "Triple Bad")
            {
                bad = comboBox1.Text;
            }


            conn.Close();
            cmd = new SqlCommand("update tblrooms set RoomType = '" + Rtype + "',Bad='" + bad + "',Price=" + txtPrice.Text + " where RoomNo = "+txtRoomno.Text+";", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Room Update Successfull..!! ");

            txtRoomno.Clear();
            txtPrice.Clear();
            comboBox1.Items.Clear();
            rbtnNonac.Checked = false;
            rbtnAC.Checked = false;
            bad.Clone();

            bind();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Close();
            cmd = new SqlCommand("delete tblrooms where RoomNo=" + txtRoomno.Text + ";", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Room Removed Successfull..!! ");
            bind(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
    }
}
