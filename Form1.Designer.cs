namespace Ergasia_Allilepidrasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            label21 = new Label();
            button2 = new Button();
            label8 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            panel2 = new Panel();
            label22 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(789, 265);
            button1.Name = "button1";
            button1.Size = new Size(158, 87);
            button1.TabIndex = 1;
            button1.Text = "Τοποθέτηση Σκηνής";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(551, 114);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 3;
            label1.Text = "Προσαρμογή:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 159);
            panel1.TabIndex = 4;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Ομαδική Δραστηριότητα", "Βραδινή Εκδήλωση", "Πάρτι" });
            comboBox3.Location = new Point(660, 114);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(108, 28);
            comboBox3.TabIndex = 19;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Λευκό", "Κίτρινο", "Μπλε" });
            comboBox2.Location = new Point(660, 74);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(108, 28);
            comboBox2.TabIndex = 18;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = SystemColors.ControlDarkDark;
            label21.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label21.ForeColor = SystemColors.ButtonHighlight;
            label21.Location = new Point(235, 62);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(671, 32);
            label21.TabIndex = 17;
            label21.Text = "Επιλέξτε ένα σημείο στον χάρτη για να εμφανιστεί το μενού";
            // 
            // button2
            // 
            button2.Location = new Point(863, 46);
            button2.Name = "button2";
            button2.Size = new Size(132, 70);
            button2.TabIndex = 13;
            button2.Text = "Run";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(551, 81);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 11;
            label8.Text = "Χρώμα:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(551, 44);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 9;
            label7.Text = "Ένταση:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(660, 41);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(108, 27);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(551, 13);
            label6.Name = "label6";
            label6.Size = new Size(138, 20);
            label6.TabIndex = 7;
            label6.Text = "Ρύθμιση Φωτισμού";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Πανί για τα ορεινά", "Πανί για τα πεδινά", "Πανί για το δάσος", "Πανί για το νησί" });
            comboBox1.Location = new Point(235, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(235, 13);
            label5.Name = "label5";
            label5.Size = new Size(243, 25);
            label5.TabIndex = 5;
            label5.Text = "Επιλογή προστατευτικών πανιών";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(78, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(42, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(42, 27);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(20, 77);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 2;
            label4.Text = "Πίεση:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(20, 44);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 1;
            label3.Text = "Γωνία:";
            // 
            // label2
            // 
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(20, 13);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 0;
            label2.Text = "Ρύθμιση Πασσάλων";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label9.Location = new Point(10, 14);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(166, 25);
            label9.TabIndex = 5;
            label9.Text = "Στοιχεία Περιοχής";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(490, 274);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 6;
            label10.Text = "Έδαφος :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(490, 304);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 7;
            label11.Text = "Υγρασία :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(490, 332);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(109, 20);
            label12.TabIndex = 8;
            label12.Text = "Θερμοκρασία :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(490, 362);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(177, 20);
            label13.TabIndex = 9;
            label13.Text = "Πιθανότητες Επιβίωσης :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(563, 274);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(42, 20);
            label14.TabIndex = 10;
            label14.Text = "TEXT";
            label14.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(563, 304);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(42, 20);
            label15.TabIndex = 11;
            label15.Text = "TEXT";
            label15.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(601, 332);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(42, 20);
            label16.TabIndex = 12;
            label16.Text = "TEXT";
            label16.Visible = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(666, 362);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(42, 20);
            label17.TabIndex = 13;
            label17.Text = "TEXT";
            label17.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(490, 438);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(18, 20);
            label18.TabIndex = 14;
            label18.Text = "Χ";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(490, 470);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(17, 20);
            label19.TabIndex = 15;
            label19.Text = "Υ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(490, 410);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(156, 20);
            label20.TabIndex = 16;
            label20.Text = "Συντεταγμένες Χάρτη";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label9);
            panel2.Location = new Point(478, 229);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(519, 273);
            panel2.TabIndex = 17;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(478, 174);
            label22.Name = "label22";
            label22.Size = new Size(58, 20);
            label22.TabIndex = 19;
            label22.Text = "label22";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(21, 174);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(440, 448);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.Questions;
            pictureBox2.Location = new Point(923, 514);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(775, 552);
            button3.Name = "button3";
            button3.Size = new Size(132, 70);
            button3.TabIndex = 20;
            button3.Text = "On-line Help";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(627, 552);
            button4.Name = "button4";
            button4.Size = new Size(132, 70);
            button4.TabIndex = 21;
            button4.Text = "Order";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(478, 552);
            button5.Name = "button5";
            button5.Size = new Size(132, 70);
            button5.TabIndex = 22;
            button5.Text = "Panel";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 654);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label22);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private ComboBox comboBox1;
        private Label label5;
        private Label label8;
        private Label label7;
        private TextBox textBox3;
        private Button button2;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label22;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
