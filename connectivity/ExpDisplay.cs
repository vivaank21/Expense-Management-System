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
    public partial class ExpDisplay : Form
    {
        public ExpDisplay()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ExpDisplay_Load(object sender, EventArgs e)
        {
            LoadExpense();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Icome ic = new Icome();
            ic.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            expense.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void LoadExpense()
        {
            string qry = @"SELECT E.Id, E.ExpenseDate, E.Amount, C.CategoryName, E.Description FROM ExpenseTbl E INNER JOIN 
                ExpenseCategoryTbl  C on E.CategoryID = C.CategoryID WHERE E.IsAct = 1 
                ORDER BY E.Id DESC";

            SqlDataAdapter sda = new SqlDataAdapter(qry, DBConnection.con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvDisplay.DataSource = dt;

            dgvDisplay.Columns["Id"].Visible = false;

            dgvDisplay.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvDisplay.RowTemplate.Height = 35;

            dgvDisplay.AllowUserToAddRows = false;

            dgvDisplay.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvDisplay.EnableHeadersVisualStyles = false;

            dgvDisplay.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(34, 169, 69);

            dgvDisplay.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvDisplay.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11, FontStyle.Bold);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExpDisplay display = new ExpDisplay();
            display.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            Chart chart = new Chart();
            chart.Show();
            this.Close();
        }
    }
}