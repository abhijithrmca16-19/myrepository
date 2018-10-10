using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;  
using System.Data.OleDb;  
using System.Data.SqlClient; 

namespace WebApplication1
{
    public class adminlogin:System.Web.UI.Page
    {
        public SqlConnection con = new SqlConnection();  
        public adminlogin()  
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString =

            InitializeComponent();
        }
        protected void adminlogin_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=10.3.10.1;Initial Catalog=SRAS;Integrated Security=True");  
            con.Open(); 
            {
        }
    }
        private void Button1_Click(object sender, EventArgs e)
        {
    SqlConnection con = new SqlConnection();  
            con.ConnectionString = "Data Source=;Initial Catalog=;Integrated Security=True";  
            con.Open();  
            string userid = textBox1.Text;  
            string password = textBox2.Text;  
            SqlCommand cmd = new SqlCommand("select userid,password from login where userid='" + textBox1.Text + "'and password='" + text            Box2.Text + "'", con);  
            SqlDataAdapter da = new SqlDataAdapter(cmd);  
            DataTable dt = new DataTable();  
            da.Fill(dt);  
            if (dt.Rows.Count > 0)  
            {  
                MessageBox.Show("Login sucess Welcome to Homepage ");  
                System.Diagnostics.Process.Start("");  
            }  
            else  
            {  
                MessageBox.Show("Invalid Login please check username and password");  
            }  
            con.Close();  
        }  
        }
    }

