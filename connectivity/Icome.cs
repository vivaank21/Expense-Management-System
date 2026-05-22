using ExpenseManagerUI;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace connectivity
{
    public partial class Icome : Form
    {
        public Icome()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Icome_Load(object sender, EventArgs e)
        {
            loadcategory();
        }

        private void btn_dash_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Close();
        }

        private void Exps_Click(object sender, EventArgs e)
        {
            Expense exp = new Expense();
            exp.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAmt.Text == "")
            {
                CustomMessageBox.Show(
                    "Please Enter Amount ⚠",
                    "Warning!", DialogType.Warning);
                return;
            }


            if (cmbCat.SelectedIndex == -1)
            {
                CustomMessageBox.Show("Please Select Category ⚠", "Warning!", DialogType.Warning);
                return;
            }

            string qry = @"INSERT INTO IncomeTbl
                (Amount, CategoryID, Description)
                VALUES(@Amount, @CategoryID, @Description)";

            SqlCommand cmd = new SqlCommand(qry, DBConnection.con);

            cmd.Parameters.AddWithValue("@Amount", txtAmt.Text);

            cmd.Parameters.AddWithValue("@CategoryID", cmbCat.SelectedValue);

            if (txtDesc.Text == "")
            {
                cmd.Parameters.AddWithValue("@Description", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Description", txtDesc.Text);
            }

            DBConnection.con.Open();

            cmd.ExecuteNonQuery();

            DBConnection.con.Close();

            CustomMessageBox.Show("Income Added Successfully ✅", "Success", DialogType.Success);

            //LoadIncome();
        }

        private void loadcategory()
        {
            string qry = "SELECT CategoryID, CategoryName FROM IncomeCategoryTbl";

            SqlDataAdapter adapter = new SqlDataAdapter(qry, DBConnection.con);

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            cmbCat.DataSource = dt;
            cmbCat.DisplayMember = "CategoryName";
            cmbCat.ValueMember = "CategoryID";
            cmbCat.SelectedIndex = -1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Chart chart = new Chart();
            chart.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExpDisplay display = new ExpDisplay();
            display.Show();
            this.Close();
        }
    }

} 

