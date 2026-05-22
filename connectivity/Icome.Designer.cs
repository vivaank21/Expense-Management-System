namespace connectivity
{
    partial class Icome
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
            lblHead = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            Exps = new Button();
            btn_dash = new Button();
            lblSide = new Label();
            lblAmt = new Label();
            txtAmt = new TextBox();
            lblCat = new Label();
            lblDiscpt = new Label();
            txtDesc = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            cmbCat = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblHead
            // 
            lblHead.AutoSize = true;
            lblHead.Font = new Font("Cambria", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHead.Location = new Point(682, 30);
            lblHead.Name = "lblHead";
            lblHead.Size = new Size(194, 55);
            lblHead.TabIndex = 0;
            lblHead.Text = "Income ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.income;
            pictureBox1.Location = new Point(583, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(Exps);
            panel1.Controls.Add(btn_dash);
            panel1.Controls.Add(lblSide);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 630);
            panel1.TabIndex = 2;
            // 
            // button6
            // 
            button6.Location = new Point(35, 535);
            button6.Name = "button6";
            button6.Size = new Size(188, 58);
            button6.TabIndex = 5;
            button6.Text = "Chart";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(35, 432);
            button5.Name = "button5";
            button5.Size = new Size(188, 58);
            button5.TabIndex = 4;
            button5.Text = "Report";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(35, 325);
            button4.Name = "button4";
            button4.Size = new Size(188, 58);
            button4.TabIndex = 3;
            button4.Text = "Display Income";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Exps
            // 
            Exps.Location = new Point(35, 217);
            Exps.Name = "Exps";
            Exps.Size = new Size(188, 58);
            Exps.TabIndex = 2;
            Exps.Text = "Expense";
            Exps.UseVisualStyleBackColor = true;
            Exps.Click += Exps_Click;
            // 
            // btn_dash
            // 
            btn_dash.Location = new Point(35, 118);
            btn_dash.Name = "btn_dash";
            btn_dash.Size = new Size(188, 58);
            btn_dash.TabIndex = 1;
            btn_dash.Text = "Dashboard";
            btn_dash.UseVisualStyleBackColor = true;
            btn_dash.Click += btn_dash_Click;
            // 
            // lblSide
            // 
            lblSide.AutoSize = true;
            lblSide.Location = new Point(50, 19);
            lblSide.Name = "lblSide";
            lblSide.Size = new Size(126, 41);
            lblSide.TabIndex = 0;
            lblSide.Text = "Sidebar";
            // 
            // lblAmt
            // 
            lblAmt.AutoSize = true;
            lblAmt.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmt.Location = new Point(340, 165);
            lblAmt.Name = "lblAmt";
            lblAmt.Size = new Size(132, 33);
            lblAmt.TabIndex = 3;
            lblAmt.Text = "Amount :";
            // 
            // txtAmt
            // 
            txtAmt.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmt.Location = new Point(485, 164);
            txtAmt.Name = "txtAmt";
            txtAmt.Size = new Size(330, 34);
            txtAmt.TabIndex = 4;
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCat.Location = new Point(328, 242);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(144, 33);
            lblCat.TabIndex = 5;
            lblCat.Text = "Category :";
            // 
            // lblDiscpt
            // 
            lblDiscpt.AutoSize = true;
            lblDiscpt.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiscpt.Location = new Point(297, 327);
            lblDiscpt.Name = "lblDiscpt";
            lblDiscpt.Size = new Size(175, 33);
            lblDiscpt.TabIndex = 7;
            lblDiscpt.Text = "Discription :";
            // 
            // txtDesc
            // 
            txtDesc.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDesc.Location = new Point(485, 327);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(330, 152);
            txtDesc.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(340, 537);
            button1.Name = "button1";
            button1.Size = new Size(115, 46);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(539, 537);
            button2.Name = "button2";
            button2.Size = new Size(137, 46);
            button2.TabIndex = 9;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(761, 537);
            button3.Name = "button3";
            button3.Size = new Size(129, 46);
            button3.TabIndex = 10;
            button3.Text = "Display";
            button3.UseVisualStyleBackColor = true;
            // 
            // cmbCat
            // 
            cmbCat.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCat.FormattingEnabled = true;
            cmbCat.Location = new Point(485, 242);
            cmbCat.Name = "cmbCat";
            cmbCat.Size = new Size(330, 35);
            cmbCat.TabIndex = 11;
            cmbCat.Text = "Select The Values";
            // 
            // Icome
            // 
            AutoScaleDimensions = new SizeF(18F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(976, 633);
            Controls.Add(cmbCat);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDesc);
            Controls.Add(lblDiscpt);
            Controls.Add(lblCat);
            Controls.Add(txtAmt);
            Controls.Add(lblAmt);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(lblHead);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 6, 7, 6);
            Name = "Icome";
            Text = "Icome";
            Load += Icome_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHead;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button Exps;
        private Button btn_dash;
        private Label lblSide;
        private Label lblAmt;
        private TextBox txtAmt;
        private Label lblCat;
        private Label lblDiscpt;
        private TextBox txtDesc;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ComboBox cmbCat;
        private Button button6;
        private Button button5;
    }
}