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
    public partial class frmFactor : Form
    {
        SqlConnection myconnection = new SqlConnection("Data Source=.;Initial Catalog=shopDB;Integrated Security=True");
        Boolean myCustomerchekCode = false;
        Boolean myProductchekCode = false;
        Boolean myFactorcheck;    //بررسی ثبت شدن کد فاکتور
        public frmFactor()
        {
            InitializeComponent();
        }
        public void ShowDataInformation()
        {
            myconnection.Open();
            SqlDataAdapter myda = new SqlDataAdapter("SELECT  FactorDetails.ProductID AS [کد کالا],Product.ProductTitle AS [نام کالا], FactorDetails.Qty AS تعداد, Product.ProducPrice AS [قیمت واحد],FactorDetails.Qty * Product.ProducPrice AS [قیمت کل] FROM  Product  INNER JOIN  FactorDetails  ON  Product.ProductID=FactorDetails.ProductID  where  FactorDetails.FactorID='" + Convert.ToInt32(txtFactor.Text) + "'", myconnection);
            DataTable mydt = new DataTable();
            myda.Fill(mydt);
            grv1.DataSource = mydt;
            grv1.Columns[0].Width = 90;
            grv1.Columns[1].Width = 130;
            grv1.Columns[2].Width = 90;
            grv1.Columns[3].Width = 90;
            grv1.Columns[4].Width = 90;

            //جمع بندی فاکتور
            myda = new SqlDataAdapter("select Sum(Product.ProducPrice *FactorDetails.Qty) FROM  Product INNER JOIN FactorDetails on Product.ProductID = FactorDetails.ProductID where FactorDetails.FactorID = '"+Convert.ToInt32(txtFactor.Text)+"'",myconnection);
            DataTable mydt2 = new  DataTable();
            myda.Fill(mydt2);
            txtTotalPrice.Text = mydt2.Rows[0].ItemArray[0].ToString();
            myconnection.Close();

        }

        public void factorCode()
        {
            try
            {
               
                SqlDataAdapter myda = new SqlDataAdapter("Select max(FactorID)from Factor ",myconnection);
                DataTable mydt = new DataTable();
                myda.Fill(mydt);
                txtFactor.Text = (Convert.ToInt32(mydt.Rows[0].ItemArray[0]) + 1).ToString();
              


            }
            catch (Exception)
            {

                txtFactor.Text = "1000";
            }
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void frmFactor_Load(object sender, EventArgs e)
        {
            factorCode();
            txtDate.Text = ClassShamsi.ConvertToShamsi(DateTime.Now);
            txtCustomerCode.Text = "1";
            txtProductCode.Focus();

        }

        private void txtCustomerCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter myda = new SqlDataAdapter("Select CustomerFirstname,CustomerLastname,CustomerAddress,CustomerCellphone from Customer where CustomerID ='" + Convert.ToInt32(txtCustomerCode.Text) + "'", myconnection);
                DataTable mydt = new DataTable();
                myda.Fill(mydt);
                txtCustomerName.Text = mydt.Rows[0].ItemArray[0].ToString();
                txtCustomerLastname.Text = mydt.Rows[0].ItemArray[1].ToString();
                txtAddress.Text = mydt.Rows[0].ItemArray[2].ToString();
                txtphone.Text = mydt.Rows[0].ItemArray[3].ToString();

                myCustomerchekCode = true;
                
            }
            catch (Exception)
            {
                txtCustomerName.Clear();
                txtCustomerLastname.Clear();
                txtAddress.Clear();
                txtphone.Clear();
                myCustomerchekCode = false;
            }
        }

        private void btnCustomerFind_Click(object sender, EventArgs e)
        {
            frmSearchCustomer myfrmSearchCustomer = new frmSearchCustomer();
            myfrmSearchCustomer.ShowDialog();

        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter myda = new SqlDataAdapter("Select ProductTitle,ProducPrice,ProducInventory from Product where ProductID ='"+Convert.ToInt64(txtProductCode.Text)+"'",myconnection);
                DataTable mydt = new DataTable();
                myda.Fill(mydt);
                txtProductName.Text = mydt.Rows[0].ItemArray[0].ToString();
                txtInventory.Text = mydt.Rows[0].ItemArray[2].ToString();
                txtPrice.Text = mydt.Rows[0].ItemArray[1].ToString();

                myProductchekCode = true;


            }
            catch (Exception)
            {

                txtProductName.Clear();
                txtPrice.Clear();
                txtInventory.Clear();

                myProductchekCode = false;
            }
        }

        private void btnProductFind_Click(object sender, EventArgs e)
        {
            frmSearchProduct myfrmSearchProduct = new frmSearchProduct();
            myfrmSearchProduct.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerCode.Text))
            {
                txtCustomerCode.Focus();

            }
            else if (myCustomerchekCode ==false)
            {
                txtCustomerCode.Focus();
                MessageBox.Show("کد اشتراک نامعتبر است ");
            }
            else if (string.IsNullOrEmpty(txtProductCode.Text))
            {
                txtProductCode.Focus();

            }
            else if (myProductchekCode ==false)
            {
                txtProductCode.Focus();
                MessageBox.Show("کد کالا نامعتبر است ");

            }
            else if (string.IsNullOrEmpty(txtNumberOfOrders.Text))
            {
                txtNumberOfOrders.Focus();

            }
            else if (Convert.ToInt32(txtNumberOfOrders.Text)>Convert.ToInt32(txtInventory.Text))
            {
                txtNumberOfOrders.Focus();
                MessageBox.Show("تعداد کالا درخواستی بیشتر از مقدار موجودی انبار است ");
            }
            else
            {
                if (myFactorcheck ==false)
                {
                    myconnection.Open();
                    SqlCommand mycommand = new SqlCommand("INSERT INTO Factor(FactorID,userID,CustomerID,FactorDate,FactorTime)VALUES(@FactorID,@userID,@CustomerID,@FactorDate,@FactorTime);", myconnection);
                    mycommand.Parameters.AddWithValue("@FactorID", Convert.ToInt32(txtFactor.Text));
                    mycommand.Parameters.AddWithValue("@userID", 1);
                    mycommand.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(txtCustomerCode.Text));
                    mycommand.Parameters.AddWithValue("@FactorDate", ClassShamsi.ConvertToShamsi(DateTime.Now));
                    mycommand.Parameters.AddWithValue("@FactorTime", DateTime.Now.ToLongTimeString());
                    mycommand.ExecuteNonQuery();

                    myconnection.Close();
                    MessageBox.Show("اطلاعات فاکتور با موفقیت ثبت شد ");
                    myFactorcheck = true;

                    //فرستادن به جدول factorditails

                    myconnection.Open();
                    SqlCommand mycommand2 = new SqlCommand("INSERT INTO FactorDetails(FactorID,ProductID,QTY)VALUES(@FactorID,@ProductID,@QTY);", myconnection);
                    mycommand2.Parameters.AddWithValue("@FactorID", Convert.ToInt32(txtFactor.Text));
                    mycommand2.Parameters.AddWithValue("@ProductID", Convert.ToInt64(txtProductCode.Text));
                    mycommand2.Parameters.AddWithValue("@QTY", Convert.ToInt32(txtNumberOfOrders.Text));
                    mycommand2.ExecuteNonQuery();

                    //بروزرسانی موجودی 
                    mycommand2 = new SqlCommand("UPDATE Product SET ProducInventory = ProducInventory - @QTY WHERE ProductID =@ProductID ", myconnection);
                    mycommand2.Parameters.AddWithValue("@QTY", Convert.ToInt32(txtNumberOfOrders.Text));
                    mycommand2.Parameters.AddWithValue("@ProductID", Convert.ToInt64(txtProductCode.Text));
                    mycommand2.ExecuteNonQuery();
                    myconnection.Close();
                    //درج کالا های بعدی 
                    txtProductCode.Clear();
                    txtInventory.Clear();
                    txtNumberOfOrders.Focus();
                    //نمایش مشخصات کالا در جدول 
                    ShowDataInformation();
                }
            }
        }
    }
}
