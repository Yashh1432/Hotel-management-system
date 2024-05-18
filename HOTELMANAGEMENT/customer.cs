using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;


namespace HOTELMANAGEMENT
{
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }


        SqlConnection conn = new SqlConnection(@"Data Source=ZEELRAJPARA\ZEEL;Initial Catalog=HOTELMANAGEMENT;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();


        private void button1_Click(object sender, EventArgs e)
        {
            txtprice.Enabled = true;
            txtBAD.Enabled = true;
            txtRoomtype.Enabled = true;
            binddata();
            conn.Close();
            String s="";
            if (btnmale.Checked == true)
                s = "Male";
            else s = "Female";
            
            cmd=new SqlCommand("insert into tblcustomer values('"+txtname.Text+"',"+txtcontact.Text+",'"+txtnationality.Text+"','"+s+"','"+txtDOB.Text+"','"+txtidproof.Text+"','"+txtaddress.Text+"','"+tatCheckin.Text+"',"+txtRoomno+");", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record inserted .......");
        }
        private void binroomno()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter();
            conn.Close();
            da=new SqlDataAdapter("select * from tblrooms;",conn);
            conn.Open();
            da.Fill(dt);
            conn.Close();
            txtRoomno.DataSource = dt;
            txtRoomno.ValueMember = "RoomNO";
            txtRoomno.DisplayMember = "RoomNo";   
        }
        private void binddata()
        {
            conn.Close();
            cmd = new SqlCommand("select * from tblrooms where RoomNo=102",conn);
            SqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows) { 
                dr.Read();
                txtBAD.Text=dr.GetValue(2).ToString();
                txtRoomtype.Text=dr.GetValue(1).ToString();
                txtprice.Text=dr.GetValue(3).ToString();
            }
        }

        private void customer_Load(object sender, EventArgs e)
        {
            binroomno();
            txtBAD.Enabled = false;
            txtRoomtype.Enabled = false;
            txtprice.Enabled = false;       
        }

        private void txtDOB_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
