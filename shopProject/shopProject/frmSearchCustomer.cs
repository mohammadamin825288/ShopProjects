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
    public partial class frmSearchCustomer : Form
    {
        SqlConnection myconnection = new SqlConnection("Data Source =.;Initial Catalog =ShopDB ;Integrated Security=true");

        public frmSearchCustomer()
        {
            InitializeComponent();
        }

        private void frmSearchCustomer_Load(object sender, EventArgs e)
        {
           
            myconnection.Open();
            SqlDataAdapter myda = new SqlDataAdapter("SELECT CustomerID AS [کد مشتری], CustomerFirstname AS [نام مشتری], CustomerLastname AS [نام خانوادگی], CustomerCellphone AS تلفن, CustomerAddress AS آدرس FROM   Customer", myconnection);
            DataTable mydt = new DataTable();
            myda.Fill(mydt);
            grv1.DataSource = mydt;
            grv1.Columns[0].Width = 100;
            grv1.Columns[1].Width = 150;
            grv1.Columns[0].Width = 150;
            grv1.Columns[0].Width = 100;
            grv1.Columns[0].Width = 200;

            myconnection.Close();


         
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                myconnection.Open();
                SqlDataAdapter myda = new SqlDataAdapter("SELECT CustomerID AS [کد مشتری ],CustomerFirstname AS [نام مشتری ],CustomerLastname AS [نام خانوادگی  ], CustomerAddress AS [آدرس] ,CustomerCellphone AS [تلفن ] FROM Customer Where CustomerID LIKE '"+txtCode.Text+"%'ORDER BY CustomerID ASC",myconnection);
                DataTable mydt = new DataTable();
                myda.Fill(mydt);
                grv1.DataSource = mydt;
                myconnection.Close();



            }
            catch (Exception)
            {

              
            }
        }
    }
}
