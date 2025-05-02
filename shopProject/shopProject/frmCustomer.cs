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


namespace shopProject
{
    public partial class frmCustomer : Form
    {
        SqlConnection myconnection = new SqlConnection("Data Source=.;Initial Catalog=shopDB;Integrated Security=True");

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.LightBlue;
            }
            else
            {
                e.CellStyle.BackColor = Color.White;
            }


        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        public void systemcode()
        {
            try
            {
                SqlDataAdapter myda = new SqlDataAdapter("SELECT Max(CustomerID)from Customer", myconnection);
                DataTable mydt = new DataTable();
                myda.Fill(mydt);
               

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
