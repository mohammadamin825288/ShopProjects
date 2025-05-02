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
    public partial class frmProduct : Form
    {
        SqlConnection myconnection = new SqlConnection("Data Source=.;Initial Catalog=shopDB;Integrated Security=True");
        Boolean mychekCode;
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            SqlDataAdapter myda = new SqlDataAdapter("SELECT   ProductID AS  [کدکالا ], ProductTitle AS [عنوان کالا] , ProducPrice AS [قیمت کالا ], ProducInventory AS [موجودی کالا] from Product", myconnection);
            DataTable mydataTable = new DataTable();
            myda.Fill(mydataTable);
            dataGridView1.DataSource = mydataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductID.Text))
            {
                txtProductID.Focus();
            }
            else if (mychekCode==true)
            {
                MessageBox.Show("کد کالا تکراری است ");
            }
            else if (string.IsNullOrEmpty(txtProductTitle.Text))
            {
                txtProductTitle.Focus();
            }
            else if (string.IsNullOrEmpty(txtProductPrice.Text))
            {
                txtProductPrice.Focus();

            }
            else if (string.IsNullOrEmpty(txtProductQTY.Text))
            {
                txtProductQTY.Focus();
            }
            else
            {
                try
                {
                    myconnection.Open();
                    SqlCommand mycommand = new SqlCommand("INSERT INTO  Product (ProductID,ProductTitle,ProducPrice,ProducInventory)VALUES(@ProductID,@ProductTitle,@ProducPrice,@ProducInventory)", myconnection);
                    mycommand.Parameters.AddWithValue("@ProductID", Convert.ToInt64(txtProductID.Text).ToString());
                    mycommand.Parameters.AddWithValue("@ProductTitle", txtProductTitle.Text);
                    mycommand.Parameters.AddWithValue("@ProducPrice", txtProductPrice.Text);
                    mycommand.Parameters.AddWithValue("@ProducInventory", txtProductQTY.Text);
                    mycommand.ExecuteNonQuery();
                    myconnection.Close();

                    MessageBox.Show("اطلاعات با موفقیت ثبت شدند ");

                    txtProductID.Clear();
                    txtProductTitle.Clear();
                    txtProductPrice.Clear();
                    txtProductQTY.Clear();

                    frmProduct_Load(sender, e);
                }
                catch (Exception)
                {

                 //   throw;
                }
            }
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                myconnection.Open();
                SqlCommand mycommand2 = new SqlCommand("select * from Product where ProductID=@ProductID", myconnection);
                mycommand2.Parameters.AddWithValue("@ProductID", Convert.ToInt64(txtProductID.Text));
                mychekCode = Convert.ToBoolean(mycommand2.ExecuteScalar());

                myconnection.Close();




            }
            catch (Exception)
            {

                txtProductTitle.Clear();
                txtProductPrice.Clear();
                txtProductQTY.Clear();
                mychekCode = false;
            }
        }
    }
}
