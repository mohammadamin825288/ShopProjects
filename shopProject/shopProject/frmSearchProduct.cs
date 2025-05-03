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
    public partial class frmSearchProduct : Form
    {
        SqlConnection myconnection = new SqlConnection("Data Source=.;Initial Catalog=shopDB;Integrated Security=True");
        public frmSearchProduct()                       //Data Source =.;Initial Catalog =ShopDB ;Integrated Security=true
        {
            InitializeComponent();
        }

        private void frmSearchProduct_Load(object sender, EventArgs e)
        {
            myconnection.Open();
            SqlDataAdapter myda = new SqlDataAdapter("SELECT ProductID as [کد کالا ],ProductTitle as [نام کالا ],ProducPrice as [قیمت] ,ProducInventory as [موجودی کالا ] from Product ", myconnection);
            DataTable mydt = new DataTable();
            myda.Fill(mydt);
            grv1.DataSource = mydt;
            myconnection.Close();

        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                myconnection.Open();
                SqlDataAdapter myda = new SqlDataAdapter("SELECT ProductID as [کد کالا ],ProductTitle as [نام کالا ],ProducPrice as [قیمت ],ProducInventory as [موجودی ] from Product where ProductID like '" + txtProductCode.Text + "%'order by ProductID asc", myconnection);
                DataTable mydt = new DataTable();
                myda.Fill(mydt);
                grv1.DataSource = mydt;
                myconnection.Close();


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                myconnection.Open();
                SqlDataAdapter myda = new SqlDataAdapter("SELECT ProductID as [کد کالا ],ProductTitle as [نام کالا ],ProducPrice as [قیمت ],ProducInventory as [موجودی ] from Product where ProductTitle like N'"+txtProductName.Text+"%'", myconnection);
                DataTable mydt = new DataTable();
                myda.Fill(mydt);
                grv1.DataSource = mydt;
                myconnection.Close();



            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
