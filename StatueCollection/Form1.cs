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
    public partial class Form1 : Form
    {
        StatueCollectionEntities entities;
        public Form1()
        {
            InitializeComponent();
            entities = new StatueCollectionEntities();   //new instance
        } //initialization

        private void Form1_Load(object sender, EventArgs e)
        {
        } //empty

        private void btnMainView_Click(object sender, EventArgs e)  //opens datagrid
        {
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
        }

        private void btnMainAdd_Click(object sender, EventArgs e)  //opens "add statue" feature
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void btnExitApplication_Click(object sender, EventArgs e) //closes app/all windows
        {
            Application.Exit();
        }

        private void btnMainTotalValue_Click(object sender, EventArgs e)  //Sum of Owned statues
        {
            var preOrders = from stat in entities.Statues
                            where stat.Owned == true
                            select stat;
            MessageBox.Show("Total value of your Collection is: $" + preOrders.Sum(p => p.Cost)?.ToString("N"));
        }

        private void btnMainPreOrderTotalCost_Click(object sender, EventArgs e)  //Sum of Pre-Orders
        {
            var preOrders = from stat in entities.Statues
                            where stat.Owned == false
                            select stat;
            
            MessageBox.Show("Total Cost of your Pre-Orders is: $" + preOrders.Sum(p => p.Cost)?.ToString("N"));
        }

        private void btnRetailLinks_Click(object sender, EventArgs e)  //Opens Link Page
        {
            Form6 frm6 = new Form6();
            frm6.ShowDialog();
        }
    }
}
