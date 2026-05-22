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
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dsp_Click(object sender, EventArgs e)
        {
            ExpDisplay ed = new ExpDisplay();
            ed.Show();
            this.Close();
        }

        private void Inc_Click(object sender, EventArgs e)
        {
            Icome ic = new Icome();
            ic.Show();
            this.Close();
        }

        private void Dash_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (txtAmt.Text == "")
            {
                CustomMessageBox.Show("Please Enter Amount ⚠", "Warning", DialogType.Warning);
                return;
            }
            if (txtDiscript.Text == "")
            {
                CustomMessageBox.Show("Please Enter Description⚠", "Warning", DialogType.Warning);
                return;
            }
            if (cbCat.SelectedIndex < -1)
            {
                CustomMessageBox.Show("Please Select Category ⚠", "Warning", DialogType.Warning);
                return;
            }

            string qry = @"INSERT INTO ExpenseTbl(ExpenseDate, Amount, CategoryID, Description) VALUES(@ExpenseDate, @Amount, @CategoryID, @Description)";

            SqlCommand cmd = new SqlCommand(qry, DBConnection.con);

            cmd.Parameters.AddWithValue("@ExpenseDate", dt.Value.Date);
            cmd.Parameters.AddWithValue("@Amount", txtAmt.Text);
            cmd.Parameters.AddWithValue("@CategoryID", cbCat.SelectedIndex);

            if (txtDiscript.Text == "")
            {
                cmd.Parameters.AddWithValue("@Description", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Description", txtDiscript.Text);
            }

            DBConnection.con.Open();

            cmd.ExecuteNonQuery();

            DBConnection.con.Close();

            CustomMessageBox.Show("Expense Added Successfully ✅", "Success!", DialogType.Success);

        }
        private void loadcategory()
        {
            string qry = "SELECT CategoryID, CategoryName FROM ExpenseCategoryTbl";

            SqlDataAdapter adapter = new SqlDataAdapter(qry, DBConnection.con);

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            cbCat.DataSource = dt;
            cbCat.DisplayMember = "CategoryName";
            cbCat.ValueMember = "CategoryID";
            cbCat.SelectedIndex = -1;
        }

        private void cleardata()
        {
            txtAmt.Clear();
            cbCat.SelectedIndex = -1;
            txtDiscript.Clear();
            dt.Value = DateTime.Now;
        }

        private void Expense_Load(object sender, EventArgs e)
        {
            loadcategory();
            cleardata();
        }
    }
}
