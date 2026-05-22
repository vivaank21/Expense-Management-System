namespace connectivity
{
    partial class Expense
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
            Dash = new Button();
            dsp = new Button();
            Inc = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            dt = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            cbCat = new ComboBox();
            txtAmt = new TextBox();
            txtDiscript = new TextBox();
            label6 = new Label();
            add = new Button();
            updt = new Button();
            disp = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(Dash);
            panel1.Controls.Add(dsp);
            panel1.Controls.Add(Inc);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 693);
            panel1.TabIndex = 0;
            // 
            // Dash
            // 
            Dash.BackColor = Color.FromArgb(255, 255, 192);
            Dash.Location = new Point(42, 352);
            Dash.Name = "Dash";
            Dash.Size = new Size(172, 45);
            Dash.TabIndex = 12;
            Dash.Text = "Dashboard";
            Dash.UseVisualStyleBackColor = false;
            Dash.Click += Dash_Click;
            // 
            // dsp
            // 
            dsp.BackColor = Color.Olive;
            dsp.Location = new Point(45, 249);
            dsp.Name = "dsp";
            dsp.Size = new Size(169, 45);
            dsp.TabIndex = 11;
            dsp.Text = "Display";
            dsp.UseVisualStyleBackColor = false;
            dsp.Click += dsp_Click;
            // 
            // Inc
            // 
            Inc.BackColor = Color.FromArgb(0, 192, 0);
            Inc.Location = new Point(42, 150);
            Inc.Name = "Inc";
            Inc.Size = new Size(172, 48);
            Inc.TabIndex = 10;
            Inc.Text = "Income";
            Inc.UseVisualStyleBackColor = false;
            Inc.Click += Inc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 32);
            label1.Name = "label1";
            label1.Size = new Size(121, 36);
            label1.TabIndex = 0;
            label1.Text = "Sidebar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(774, 32);
            label2.Name = "label2";
            label2.Size = new Size(261, 70);
            label2.TabIndex = 1;
            label2.Text = "Expense";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.expse;
            pictureBox1.Location = new Point(706, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(370, 151);
            label3.Name = "label3";
            label3.Size = new Size(89, 33);
            label3.TabIndex = 3;
            label3.Text = "Date :";
            // 
            // dt
            // 
            dt.Location = new Point(489, 151);
            dt.Name = "dt";
            dt.Size = new Size(296, 39);
            dt.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(327, 235);
            label4.Name = "label4";
            label4.Size = new Size(132, 33);
            label4.TabIndex = 5;
            label4.Text = "Amount :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(315, 328);
            label5.Name = "label5";
            label5.Size = new Size(144, 33);
            label5.TabIndex = 6;
            label5.Text = "Category :";
            // 
            // cbCat
            // 
            cbCat.FormattingEnabled = true;
            cbCat.Location = new Point(489, 328);
            cbCat.Name = "cbCat";
            cbCat.Size = new Size(296, 40);
            cbCat.TabIndex = 1;
            // 
            // txtAmt
            // 
            txtAmt.Location = new Point(489, 235);
            txtAmt.Name = "txtAmt";
            txtAmt.Size = new Size(296, 39);
            txtAmt.TabIndex = 7;
            // 
            // txtDiscript
            // 
            txtDiscript.Location = new Point(489, 433);
            txtDiscript.Multiline = true;
            txtDiscript.Name = "txtDiscript";
            txtDiscript.Size = new Size(296, 154);
            txtDiscript.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(284, 433);
            label6.Name = "label6";
            label6.Size = new Size(175, 33);
            label6.TabIndex = 9;
            label6.Text = "Discription :";
            // 
            // add
            // 
            add.Location = new Point(354, 611);
            add.Name = "add";
            add.Size = new Size(143, 45);
            add.TabIndex = 12;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // updt
            // 
            updt.Location = new Point(554, 611);
            updt.Name = "updt";
            updt.Size = new Size(143, 45);
            updt.TabIndex = 13;
            updt.Text = "Update";
            updt.UseVisualStyleBackColor = true;
            // 
            // disp
            // 
            disp.Location = new Point(761, 611);
            disp.Name = "disp";
            disp.Size = new Size(143, 45);
            disp.TabIndex = 14;
            disp.Text = "Display";
            disp.UseVisualStyleBackColor = true;
            // 
            // Expense
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1067, 694);
            Controls.Add(disp);
            Controls.Add(updt);
            Controls.Add(add);
            Controls.Add(label6);
            Controls.Add(txtDiscript);
            Controls.Add(txtAmt);
            Controls.Add(cbCat);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dt);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Expense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expense";
            Load += Expense_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private DateTimePicker dt;
        private Label label4;
        private Label label5;
        private ComboBox cbCat;
        private TextBox txtAmt;
        private TextBox txtDiscript;
        private Label label6;
        private Button dsp;
        private Button Inc;
        private Button Dash;
        private Button add;
        private Button updt;
        private Button disp;
    }
}