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
namespace ATM
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kisha\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        private void label13_Click(object sender, EventArgs e)
        {
            if (AccNameTb.Text == "" || AccNumTb.Text == "" || FaNameTb.Text == "" || PhoneTb.Text == "" || Addresstb.Text == "" || Occupationtb.Text == "" || pintb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try { 
                    con.Open();
                    string query = "insert into Acccounttbl values('"+AccNumTb.Text+"','" + AccNameTb.Text + "','"+FaNameTb.Text+ "', '"+dobdate.Value.Date+ "' , '"+PhoneTb.Text+"' )";
                    SqlCommand cmd = new SqlCommand();
                    con.Close();
                }
                catch (Exception ex) { }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
