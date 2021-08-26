using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace StatueCollection
{
    public partial class Form3 : Form
    {
        StatueDepot statue;
        public Form3()
        {
            InitializeComponent();
            statue = new StatueDepot();
            txtUserName.Focus();
            txtpassWord.UseSystemPasswordChar = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void btnenterPass_Click(object sender, EventArgs e)  //username and password info
        {
            if (txtUserName.Text == "admin" && txtpassWord.Text == "password")
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                
            }
            else if (txtUserName.Text == "christy" && txtpassWord.Text == "rules")
            {
                Form1 frm1 = new Form1();
                frm1.Show();
            }
            else 
            {
                MessageBox.Show("The Username or Password entered is not correct");
                txtUserName.Clear();
                txtpassWord.Clear();
                //txtUserName.Focus();
            }
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e) //reveals or hides password
        {
            if (checkShowPassword.Checked == true)
            {
                txtpassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassWord.UseSystemPasswordChar = true;
            }
        }
    }
}
