using ExpenseManagerUI;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace connectivity
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Chart_Load(object sender, EventArgs e)
        {
            LoadSixMonthExpenseChart();
            LoadIncomeVsExpenseChart();
            LoadExpenseBreakdownChart();
        }
        private void LoadSixMonthExpenseChart()
        {
            chartMonthlyExpense.Series.Clear();


            chartMonthlyExpense.Titles.Clear();

            chartMonthlyExpense.Titles.Add(
                "Last 6 Months Expense Trend"
            );

            chartMonthlyExpense.BackColor =
                Color.White;

            chartMonthlyExpense.ChartAreas[0].BackColor =
                Color.Transparent;

            chartMonthlyExpense.Palette =
                ChartColorPalette.BrightPastel;

            Series s = new Series();

            s.ChartType =
                SeriesChartType.Spline;

            s.BorderWidth = 4;

            s.MarkerStyle =
                MarkerStyle.Circle;

            s.MarkerSize = 10;

            s.IsValueShownAsLabel = true;

            s.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            string qry = @"
                SELECT TOP 6
                DATENAME(MONTH, ExpenseDate) AS MonthName,
                MONTH(ExpenseDate) AS MonthNo,
                SUM(Amount) AS Total
                FROM ExpenseTbl
                WHERE IsAct = 1
                GROUP BY
                DATENAME(MONTH, ExpenseDate),
                MONTH(ExpenseDate)
                ORDER BY MonthNo DESC";

            SqlDataAdapter sda =
                new SqlDataAdapter(
                    qry,
                    DBConnection.con
                );

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dt.DefaultView.Sort =
                "MonthNo ASC";

            dt = dt.DefaultView.ToTable();

            foreach (DataRow row in dt.Rows)
            {
                int index = s.Points.AddXY(
                    row["MonthName"],
                    row["Total"]
                );

                s.Points[index].ToolTip =
                    row["MonthName"] +
                    " : ₹ " +
                    row["Total"];
            }

            chartMonthlyExpense.Series.Add(s);
        }

        private void LoadIncomeVsExpenseChart()
        {
            chartCompare.Series.Clear();

            chartCompare.Titles.Clear();

            chartCompare.Titles.Add(
                "Income vs Expense"
            );

            chartCompare.BackColor =
                Color.White;

            chartCompare.ChartAreas[0].BackColor =
                Color.Transparent;

            chartCompare.Palette =
                ChartColorPalette.Excel;

            Series s = new Series();

            s.ChartType =
                SeriesChartType.Column;

            s.IsValueShownAsLabel = true;

            s.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold
                );

            decimal income = 0;

            decimal expense = 0;

            // =========================
            // INCOME
            // =========================

            string incomeQry =
                "SELECT ISNULL(SUM(Amount),0) FROM IncomeTbl WHERE IsAct = 1";

            SqlCommand incomeCmd =
                new SqlCommand(
                    incomeQry,
                    DBConnection.con
                );

            DBConnection.con.Open();

            income =
                Convert.ToDecimal(
                    incomeCmd.ExecuteScalar()
                );

            DBConnection.con.Close();

            // =========================
            // EXPENSE
            // =========================

            string expenseQry =
                "SELECT ISNULL(SUM(Amount),0) FROM ExpenseTbl WHERE IsAct = 1";

            SqlCommand expenseCmd =
                new SqlCommand(
                    expenseQry,
                    DBConnection.con
                );

            DBConnection.con.Open();

            expense =
                Convert.ToDecimal(
                    expenseCmd.ExecuteScalar()
                );

            DBConnection.con.Close();

            int i1 =
                s.Points.AddXY(
                    "Income",
                    income
                );

            int i2 =
                s.Points.AddXY(
                    "Expense",
                    expense
                );

            s.Points[i1].ToolTip =
                "Income : ₹ " + income;

            s.Points[i2].ToolTip =
                "Expense : ₹ " + expense;

            chartCompare.Series.Add(s);

            chartCompare.ChartAreas[0]
                .Area3DStyle
                .Enable3D = true;
        }

        private void LoadExpenseBreakdownChart()
        {
            chartExpenseBreakdown.Series.Clear();


            chartExpenseBreakdown.Titles.Clear();

            chartExpenseBreakdown.Titles.Add(
                "Expense Breakdown"
            );

            chartExpenseBreakdown.BackColor =
                Color.White;

            chartExpenseBreakdown.ChartAreas[0].BackColor =
                Color.Transparent;

            chartExpenseBreakdown.Palette =
                ChartColorPalette.BrightPastel;

            Series s = new Series();

            s.ChartType =
                SeriesChartType.Doughnut;

            s.IsValueShownAsLabel = true;

            s["PieLabelStyle"] =
                "Outside";

            s.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            string qry = @"
                SELECT
                C.CategoryName,
                SUM(E.Amount) AS Total
                FROM ExpenseTbl E
                INNER JOIN ExpenseCategoryTbl C
                ON E.CategoryID = C.CategoryID
                WHERE E.IsAct = 1
                GROUP BY C.CategoryName";

            SqlDataAdapter sda =
                new SqlDataAdapter(
                    qry,
                    DBConnection.con
                );

            DataTable dt = new DataTable();

            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                int index = s.Points.AddXY(
                    row["CategoryName"],
                    row["Total"]
                );

                s.Points[index].ToolTip =
                    row["CategoryName"] +
                    " : ₹ " +
                    row["Total"];
            }

            chartExpenseBreakdown.Series.Add(s);

            chartExpenseBreakdown.Legends[0]
                .Docking = Docking.Bottom;

            chartExpenseBreakdown.ChartAreas[0]
                .Area3DStyle
                .Enable3D = true;
        }

        private void LoadCards()
        {
            decimal income = 0;


            decimal expense = 0;

            decimal balance = 0;

            // =========================
            // TOTAL INCOME
            // =========================

            string incomeQry =
                "SELECT ISNULL(SUM(Amount),0) FROM IncomeTbl WHERE IsAct = 1";

            SqlCommand incomeCmd =
                new SqlCommand(
                    incomeQry,
                    DBConnection.con
                );

            DBConnection.con.Open();

            income =
                Convert.ToDecimal(
                    incomeCmd.ExecuteScalar()
                );

            DBConnection.con.Close();

            // =========================
            // TOTAL EXPENSE
            // =========================

            string expenseQry =
                "SELECT ISNULL(SUM(Amount),0) FROM ExpenseTbl WHERE IsAct = 1";

            SqlCommand expenseCmd =
                new SqlCommand(
                    expenseQry,
                    DBConnection.con
                );

            DBConnection.con.Open();

            expense =
                Convert.ToDecimal(
                    expenseCmd.ExecuteScalar()
                );

            DBConnection.con.Close();

            // =========================
            // BALANCE
            // =========================

            balance = income - expense;

            // =========================
            // DISPLAY VALUES
            // =========================

            lblIncome.Text =
                "₹ " + income.ToString("N2");

            lblExpense.Text =
                "₹ " + expense.ToString("N2");

            lblBalance.Text =
                "₹ " + balance.ToString("N2");

            // =========================
            // CARD COLORS
            // =========================

            pnlIncome.BackColor =
                Color.FromArgb(34, 197, 94);

            pnlExpense.BackColor =
                Color.FromArgb(239, 68, 68);

            pnlBalance.BackColor =
                Color.FromArgb(59, 130, 246);

            // =========================
            // LABEL COLORS
            // =========================

            lblIncome.ForeColor = Color.White;

            lblExpense.ForeColor = Color.White;

            lblBalance.ForeColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Icome ic = new Icome();
            ic.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Expense exp = new Expense();
            exp.Show();
            this.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ExpDisplay display = new ExpDisplay();
            display.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Chart chart = new Chart();
            chart.Show();
            this.Close();
        }
    }
}
