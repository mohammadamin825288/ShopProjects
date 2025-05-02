using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void ثبتکاربرجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers myusers = new frmUsers();
            myusers.ShowDialog();

        }

        private void ثبتمشتریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer mycustomer = new frmCustomer();
            mycustomer.ShowDialog();

        }

        private void ثبتکالاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct mynewProduct = new frmProduct();
            mynewProduct.ShowDialog();
        }

        private void جستجواطلاعاتمشتریToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void جستجواToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchCustomer myfrmSearchCustomer = new frmSearchCustomer();
            myfrmSearchCustomer.ShowDialog();

        }
    }
}
