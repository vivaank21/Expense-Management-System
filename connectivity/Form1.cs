using System;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using ExpenseManagerUI;

namespace connectivity
{
    public partial class Form1 : Form
    {
        //string cs = ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(cs);

            string qry = "SELECT COUNT(*) FROM Logintbl WHERE Username=@Username AND Password = @Password";

            SqlCommand cmd = new SqlCommand(qry, DBConnection.con);

            cmd.Parameters.AddWithValue("@Username", txtUser.Text);
            cmd.Parameters.AddWithValue("@Password", txtPass.Text);

            DBConnection.con.Open();

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            DBConnection.con.Close();

            if (count > 0)
            {
                //MessageBox.Show(
                //    "Welcome Back!\n\nLogin Successful ✅",
                //    "Expense Manager",
                //    MessageBoxButtons.OK,
                //    MessageBoxIcon.Information
                //);
                CustomMessageBox.Show("You have successfully logged in to the system.", "Welcome Back!", DialogType.Success, this);

                Dashboard db = new Dashboard();
                db.Show();
                this.Hide();
            }
            else if (txtUser.Text == "" && txtPass.Text == "")
            {
                CustomMessageBox.Show("Please Enter Username and Password. 🔒", "Action Required!", DialogType.Warning, this);
                return;
            }
            else
            {
                CustomMessageBox.Show("Invalid Username or Password. 👁‍🗨", "Login Failed!", DialogType.Error, this);
                return;
            }

           
        }
    }
}
