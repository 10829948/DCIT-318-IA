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

namespace Shoprite_Inventory_Management
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

         SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JEROME\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl values('" + Unametb.Text + "','" + Fnametb.Text + "','" + Passwordtb.Text + "','" + Phonetb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully");
                Con.Close();
            }

            catch 
            {
            
            }
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void UserGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
