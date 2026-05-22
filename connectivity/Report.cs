using ExpenseManagerUI;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

using System.IO;

namespace connectivity
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Add("Expense");
            cmbCategory.Items.Add("Income");

            cmbCategory.SelectedIndex = 0;
        }

        private void LoadExpense()
        {
            string qry = @"SELECT E.Id, E.ExpenseDate, E.Amount, C.CategoryName, E.Description FROM ExpenseTbl E INNER JOIN 
                ExpenseCategoryTbl  C on E.CategoryID = C.CategoryID WHERE E.IsAct = 1 
                ORDER BY E.Id DESC";

            SqlDataAdapter sda = new SqlDataAdapter(qry, DBConnection.con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvReport.DataSource = dt;

            dgvReport.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            dgvReport.RowTemplate.Height = 35;

            dgvReport.AllowUserToAddRows = false;

            dgvReport.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbCategory.Text == "Expense")
            {
                LoadExpense();
            }
            else
            {
                LoadIncome();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }
        private void LoadIncome()
        {
            string qry = @"SELECT I.Id, I.Amount, C.CategoryName, I.Description FROM IncomeTbl I INNER JOIN IncomeCategoryTbl C ON I.CategoryID = C.CategoryID
            WHERE I.IsAct = 1 ORDER BY I.Id DESC ";

            SqlDataAdapter adapter = new SqlDataAdapter(qry, DBConnection.con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvReport.DataSource = dt;

            dgvReport.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            dgvReport.RowTemplate.Height = 35;

            dgvReport.AllowUserToAddRows = false;

            dgvReport.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_PDF_Click(object sender, EventArgs e)
        {
           
            SaveFileDialog sfd =
                new SaveFileDialog();

            sfd.Filter = "PDF Files|*.pdf";

            sfd.FileName =
                cmbCategory.Text + "Report.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Document doc =
                    new Document(
                        PageSize.A4,
                        30f,
                        30f,
                        40f,
                        30f
                    );

                PdfWriter.GetInstance(
                    doc,
                    new FileStream(
                        sfd.FileName,
                        FileMode.Create
                    )
                );

                doc.Open();

                // =========================
                // COLORS
                // =========================

                BaseColor primaryColor =
                    new BaseColor(34, 169, 69);

                BaseColor lightGray =
                    new BaseColor(245, 245, 245);

                BaseColor darkText =
                    new BaseColor(40, 40, 40);

                // =========================
                // FONTS
                // =========================

                iTextSharp.text.Font titleFont =
                    FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD,
                        24,
                        primaryColor
                    );

                iTextSharp.text.Font subFont =
                    FontFactory.GetFont(
                        FontFactory.HELVETICA,
                        11,
                        darkText
                    );

                iTextSharp.text.Font tableHeaderFont =
                    FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD,
                        12,
                        BaseColor.WHITE
                    );

                iTextSharp.text.Font tableBodyFont =
                    FontFactory.GetFont(
                        FontFactory.HELVETICA,
                        11,
                        darkText
                    );

                iTextSharp.text.Font totalFont =
                    FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD,
                        16,
                        primaryColor
                    );

                // =========================
                // COMPANY TITLE
                // =========================

                Paragraph company =
                    new Paragraph(
                        "Expense Manager",
                        titleFont
                    );

                company.Alignment =
                    Element.ALIGN_CENTER;

                doc.Add(company);

                // =========================
                // REPORT TITLE
                // =========================

                Paragraph reportTitle =
                    new Paragraph(
                        cmbCategory.Text + " Report",
                        FontFactory.GetFont(
                            FontFactory.HELVETICA_BOLD,
                            18
                        )
                    );

                reportTitle.Alignment =
                    Element.ALIGN_CENTER;

                reportTitle.SpacingAfter = 10f;

                doc.Add(reportTitle);

                // =========================
                // DATE
                // =========================

                Paragraph date =
                    new Paragraph(
                        "Generated On : "
                        + DateTime.Now.ToString(),
                        subFont
                    );

                date.Alignment =
                    Element.ALIGN_RIGHT;

                date.SpacingAfter = 20f;

                doc.Add(date);

                // =========================
                // TABLE
                // =========================

                PdfPTable table =
                    new PdfPTable(
                        dgvReport.Columns.Count
                    );

                table.WidthPercentage = 100;

                table.SpacingBefore = 10f;

                table.SpacingAfter = 20f;

                // =========================
                // TABLE HEADERS
                // =========================

                foreach (DataGridViewColumn col in dgvReport.Columns)
                {
                    PdfPCell cell =
                        new PdfPCell(
                            new Phrase(
                                col.HeaderText,
                                tableHeaderFont
                            )
                        );

                    cell.BackgroundColor =
                        primaryColor;

                    cell.HorizontalAlignment =
                        Element.ALIGN_CENTER;

                    cell.Padding = 8;

                    table.AddCell(cell);
                }

                // =========================
                // TABLE DATA
                // =========================

                decimal total = 0;

                foreach (DataGridViewRow row in dgvReport.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell dgvCell in row.Cells)
                        {
                            PdfPCell cell =
                                new PdfPCell(
                                    new Phrase(
                                        dgvCell.Value?.ToString(),
                                        tableBodyFont
                                    )
                                );

                            cell.Padding = 6;

                            cell.BackgroundColor =
                                lightGray;

                            table.AddCell(cell);
                        }

                        total += Convert.ToDecimal(
                            row.Cells["Amount"].Value
                        );
                    }
                }

                doc.Add(table);

                // =========================
                // TOTAL
                // =========================

                Paragraph totalText =
                    new Paragraph(
                        "Total Amount : ₹ "
                        + total,
                        totalFont
                    );

                totalText.Alignment =
                    Element.ALIGN_RIGHT;

                totalText.SpacingBefore = 10f;

                doc.Add(totalText);

                // =========================
                // FOOTER
                // =========================

                Paragraph footer =
                    new Paragraph(
                        "Thank You For Using Expense Manager",
                        FontFactory.GetFont(
                            FontFactory.HELVETICA_OBLIQUE,
                            10,
                            BaseColor.GRAY
                        )
                    );

                footer.Alignment =
                    Element.ALIGN_CENTER;

                footer.SpacingBefore = 40f;

                doc.Add(footer);

                doc.Close();

                // =========================
                // SUCCESS MESSAGE
                // =========================

                CustomMessageBox.Show(
                    "Professional PDF Generated Successfully ✅",
                    "Success",
                    DialogType.Success
                );
            }
        }
    }
}