namespace connectivity
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dgvReport = new DataGridView();
            cmbCategory = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            btn_PDF = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 617);
            panel1.TabIndex = 0;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Location = new Point(53, 486);
            button7.Name = "button7";
            button7.Size = new Size(173, 60);
            button7.TabIndex = 11;
            button7.Text = "Chart";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Location = new Point(53, 395);
            button6.Name = "button6";
            button6.Size = new Size(173, 60);
            button6.TabIndex = 10;
            button6.Text = "Display";
            button6.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(53, 308);
            button3.Name = "button3";
            button3.Size = new Size(173, 60);
            button3.TabIndex = 7;
            button3.Text = "Dashboard";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Location = new Point(53, 221);
            button4.Name = "button4";
            button4.Size = new Size(173, 60);
            button4.TabIndex = 8;
            button4.Text = "Expense";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Location = new Point(53, 127);
            button5.Name = "button5";
            button5.Size = new Size(173, 60);
            button5.TabIndex = 9;
            button5.Text = "Income";
            button5.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 27);
            label1.Name = "label1";
            label1.Size = new Size(243, 70);
            label1.TabIndex = 0;
            label1.Text = "Sidebar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(864, 27);
            label2.Name = "label2";
            label2.Size = new Size(249, 70);
            label2.TabIndex = 1;
            label2.Text = "Reports";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.report;
            pictureBox1.Location = new Point(785, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dgvReport
            // 
            dgvReport.BackgroundColor = SystemColors.ActiveCaption;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(291, 320);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(849, 297);
            dgvReport.TabIndex = 3;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(503, 127);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(332, 40);
            cmbCategory.TabIndex = 4;
            cmbCategory.Text = "Expense";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(353, 127);
            label3.Name = "label3";
            label3.Size = new Size(144, 33);
            label3.TabIndex = 1;
            label3.Text = "Category :";
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.Location = new Point(382, 221);
            button1.Name = "button1";
            button1.Size = new Size(173, 60);
            button1.TabIndex = 5;
            button1.Text = "Load Data";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_PDF
            // 
            btn_PDF.BackColor = Color.OliveDrab;
            btn_PDF.Location = new Point(847, 221);
            btn_PDF.Name = "btn_PDF";
            btn_PDF.Size = new Size(173, 60);
            btn_PDF.TabIndex = 6;
            btn_PDF.Text = "Export PDF";
            btn_PDF.UseVisualStyleBackColor = false;
            btn_PDF.Click += btn_PDF_Click;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1136, 617);
            Controls.Add(btn_PDF);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(cmbCategory);
            Controls.Add(dgvReport);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Report";
            Text = "Report";
            Load += Report_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView dgvReport;
        private ComboBox cmbCategory;
        private Label label3;
        private Button button7;
        private Button button6;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button1;
        private Button btn_PDF;
    }
}