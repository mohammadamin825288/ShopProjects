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
    public partial class frmUsers : Form
    {
        SqlConnection myconnection = new SqlConnection("Data Source=.;Initial Catalog=shopDB;Integrated Security=True");

        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            SqlDataAdapter myda = new SqlDataAdapter("SELECT Users.userName AS [نام کاربری], Users.LoginQTY AS [تعداد ورود], Users.LastDate AS [تاریخ آخرین ورود], Users.LastTime AS [ساعت آخرین ورود], userRoles.roleType AS نقش FROM   Users INNER JOIN    userRoles ON Users.userType = userRoles.userType ", myconnection);
            DataTable mydt = new DataTable();
            myda.Fill(mydt);
            grv1.DataSource = mydt;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {

                txtUsername.Focus();

            }
            else if(string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();

            }
            else
            {
                int usertype;
                if (radioButton1.Checked == true)
                {
                    usertype = 0; //کاربر عادی
                }
                else
                {
                    usertype = 1;//کاربر مدیر


                    try
                    {
                        myconnection.Open();
                        SqlCommand mycommand = new SqlCommand("INSERT INTO Users (userName,userPass,userType,LoginQTY)VALUES(@USERnAME,@userName,@userPass,@userType,@LoginQTY)", myconnection);
                        mycommand.Parameters.AddWithValue("@userName", txtUsername.Text);
                        mycommand.Parameters.AddWithValue("@userPass", txtPassword.Text);
                        mycommand.Parameters.AddWithValue("@userType", usertype);
                        mycommand.Parameters.AddWithValue("@LoginQTY", 0);
                        mycommand.ExecuteNonQuery();
                        myconnection.Close();

                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtUsername.Focus();
                        MessageBox.Show("کاربر جدبد با موفقیت ثبت شد ");

                        frmUser_Load(sender, e);

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
