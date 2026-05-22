namespace connectivity
{
    partial class Dashboard
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
            label1 = new Label();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            BtnExp = new Button();
            BtnInc = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(758, 21);
            label1.Name = "label1";
            label1.Size = new Size(325, 47);
            label1.TabIndex = 0;
            label1.Text = "Expense Tracker";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(BtnExp);
            panel1.Controls.Add(BtnInc);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 590);
            panel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(44, 482);
            button4.Name = "button4";
            button4.Size = new Size(156, 59);
            button4.TabIndex = 8;
            button4.Text = "Chart";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(44, 381);
            button3.Name = "button3";
            button3.Size = new Size(156, 59);
            button3.TabIndex = 7;
            button3.Text = "Display";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(44, 276);
            button2.Name = "button2";
            button2.Size = new Size(156, 59);
            button2.TabIndex = 6;
            button2.Text = "Report";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // BtnExp
            // 
            BtnExp.BackColor = Color.White;
            BtnExp.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExp.Location = new Point(44, 176);
            BtnExp.Name = "BtnExp";
            BtnExp.Size = new Size(156, 59);
            BtnExp.TabIndex = 4;
            BtnExp.Text = "Add Expense";
            BtnExp.UseVisualStyleBackColor = false;
            BtnExp.Click += BtnExp_Click;
            // 
            // BtnInc
            // 
            BtnInc.BackColor = Color.White;
            BtnInc.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnInc.Location = new Point(44, 79);
            BtnInc.Name = "BtnInc";
            BtnInc.Size = new Size(156, 59);
            BtnInc.TabIndex = 3;
            BtnInc.Text = "Add Income";
            BtnInc.UseVisualStyleBackColor = false;
            BtnInc.Click += BtnInc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 20);
            label2.Name = "label2";
            label2.Size = new Size(121, 36);
            label2.TabIndex = 2;
            label2.Text = "Sidebar";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dashboard;
            pictureBox1.Location = new Point(322, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(773, 499);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.prf;
            pictureBox2.Location = new Point(689, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1107, 591);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button BtnInc;
        private Label label2;
        private Button BtnExp;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}