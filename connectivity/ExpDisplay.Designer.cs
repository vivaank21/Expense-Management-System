namespace connectivity
{
    partial class ExpDisplay
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
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvDisplay = new DataGridView();
            button4 = new Button();
            textBox1 = new TextBox();
            lblSearch = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 701);
            panel1.TabIndex = 0;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(50, 588);
            button7.Name = "button7";
            button7.Size = new Size(173, 60);
            button7.TabIndex = 7;
            button7.Text = "Chart";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(50, 493);
            button6.Name = "button6";
            button6.Size = new Size(173, 60);
            button6.TabIndex = 6;
            button6.Text = "Report";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(50, 406);
            button5.Name = "button5";
            button5.Size = new Size(173, 60);
            button5.TabIndex = 5;
            button5.Text = "Display";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(50, 325);
            button3.Name = "button3";
            button3.Size = new Size(173, 56);
            button3.TabIndex = 4;
            button3.Text = "Dashboard";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(50, 237);
            button2.Name = "button2";
            button2.Size = new Size(173, 60);
            button2.TabIndex = 3;
            button2.Text = "Expense";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(50, 153);
            button1.Name = "button1";
            button1.Size = new Size(173, 61);
            button1.TabIndex = 2;
            button1.Text = "Income";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 21);
            label2.Name = "label2";
            label2.Size = new Size(243, 70);
            label2.TabIndex = 2;
            label2.Text = "Sidebar";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(740, 21);
            label1.Name = "label1";
            label1.Size = new Size(479, 70);
            label1.TabIndex = 0;
            label1.Text = "Display Expense";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.record_keeping;
            pictureBox1.Location = new Point(657, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dgvDisplay
            // 
            dgvDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisplay.Location = new Point(280, 264);
            dgvDisplay.Name = "dgvDisplay";
            dgvDisplay.RowHeadersWidth = 51;
            dgvDisplay.Size = new Size(939, 437);
            dgvDisplay.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 192, 0);
            button4.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(1067, 153);
            button4.Name = "button4";
            button4.Size = new Size(138, 61);
            button4.TabIndex = 5;
            button4.Text = "Income";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(574, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(453, 34);
            textBox1.TabIndex = 6;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(439, 169);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(102, 33);
            lblSearch.TabIndex = 7;
            lblSearch.Text = "Search";
            // 
            // ExpDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1217, 701);
            Controls.Add(lblSearch);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(dgvDisplay);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ExpDisplay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExpDisplay";
            Load += ExpDisplay_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button button1;
        private Button button3;
        private Button button2;
        private DataGridView dgvDisplay;
        private Button button4;
        private TextBox textBox1;
        private Label lblSearch;
        private Button button5;
        private Button button7;
        private Button button6;
    }
}