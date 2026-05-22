using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace connectivity
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void BtnInc_Click(object sender, EventArgs e)
        {
            Icome ic = new Icome();
            ic.Show();
            this.Hide();
        }

        private void BtnExp_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            expense.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExpDisplay expense = new ExpDisplay();
            expense.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Chart chart = new Chart();
            chart.Show();
            this.Close();
        }
    }
}
