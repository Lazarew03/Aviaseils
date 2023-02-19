namespace Aviaseils
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbMyCity = new System.Windows.Forms.ComboBox();
            this.cbOneCity = new System.Windows.Forms.ComboBox();
            this.cbTwoCity = new System.Windows.Forms.ComboBox();
            this.cbThreeCity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOneCity = new System.Windows.Forms.Label();
            this.labelTwoCity = new System.Windows.Forms.Label();
            this.labelThreeCity = new System.Windows.Forms.Label();
            this.numCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.myPrise = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.butPr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMyCity
            // 
            this.cbMyCity.FormattingEnabled = true;
            this.cbMyCity.Items.AddRange(new object[] {
            "Берлин",
            "Прага",
            "Париж",
            "Рига",
            "Лондон",
            "Ватикан",
            "Палермо",
            "Варшава",
            "Кишинев",
            "Мадрид",
            "Будапешт"});
            this.cbMyCity.Location = new System.Drawing.Point(40, 246);
            this.cbMyCity.Name = "cbMyCity";
            this.cbMyCity.Size = new System.Drawing.Size(151, 28);
            this.cbMyCity.TabIndex = 0;
            // 
            // cbOneCity
            // 
            this.cbOneCity.FormattingEnabled = true;
            this.cbOneCity.Items.AddRange(new object[] {
            "Берлин",
            "Прага",
            "Париж",
            "Рига",
            "Лондон",
            "Ватикан",
            "Палермо",
            "Варшава",
            "Кишинев",
            "Мадрид",
            "Будапешт"});
            this.cbOneCity.Location = new System.Drawing.Point(197, 246);
            this.cbOneCity.Name = "cbOneCity";
            this.cbOneCity.Size = new System.Drawing.Size(151, 28);
            this.cbOneCity.TabIndex = 1;
            this.cbOneCity.Visible = false;
            // 
            // cbTwoCity
            // 
            this.cbTwoCity.FormattingEnabled = true;
            this.cbTwoCity.Items.AddRange(new object[] {
            "Берлин",
            "Прага",
            "Париж",
            "Рига",
            "Лондон",
            "Ватикан",
            "Палермо",
            "Варшава",
            "Кишинев",
            "Мадрид",
            "Будапешт"});
            this.cbTwoCity.Location = new System.Drawing.Point(354, 246);
            this.cbTwoCity.Name = "cbTwoCity";
            this.cbTwoCity.Size = new System.Drawing.Size(151, 28);
            this.cbTwoCity.TabIndex = 2;
            this.cbTwoCity.Visible = false;
            // 
            // cbThreeCity
            // 
            this.cbThreeCity.FormattingEnabled = true;
            this.cbThreeCity.Items.AddRange(new object[] {
            "Берлин",
            "Прага",
            "Париж",
            "Рига",
            "Лондон",
            "Ватикан",
            "Палермо",
            "Варшава",
            "Кишинев",
            "Мадрид",
            "Будапешт"});
            this.cbThreeCity.Location = new System.Drawing.Point(511, 246);
            this.cbThreeCity.Name = "cbThreeCity";
            this.cbThreeCity.Size = new System.Drawing.Size(151, 28);
            this.cbThreeCity.TabIndex = 3;
            this.cbThreeCity.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Город отправления";
            // 
            // labelOneCity
            // 
            this.labelOneCity.AutoSize = true;
            this.labelOneCity.Location = new System.Drawing.Point(217, 223);
            this.labelOneCity.Name = "labelOneCity";
            this.labelOneCity.Size = new System.Drawing.Size(110, 20);
            this.labelOneCity.TabIndex = 5;
            this.labelOneCity.Text = "Первый город";
            this.labelOneCity.Visible = false;
            this.labelOneCity.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelTwoCity
            // 
            this.labelTwoCity.AutoSize = true;
            this.labelTwoCity.Location = new System.Drawing.Point(380, 223);
            this.labelTwoCity.Name = "labelTwoCity";
            this.labelTwoCity.Size = new System.Drawing.Size(105, 20);
            this.labelTwoCity.TabIndex = 6;
            this.labelTwoCity.Text = "Второй город";
            this.labelTwoCity.Visible = false;
            // 
            // labelThreeCity
            // 
            this.labelThreeCity.AutoSize = true;
            this.labelThreeCity.Location = new System.Drawing.Point(536, 223);
            this.labelThreeCity.Name = "labelThreeCity";
            this.labelThreeCity.Size = new System.Drawing.Size(103, 20);
            this.labelThreeCity.TabIndex = 7;
            this.labelThreeCity.Text = "Третий город";
            this.labelThreeCity.Visible = false;
            // 
            // numCity
            // 
            this.numCity.Location = new System.Drawing.Point(354, 108);
            this.numCity.Name = "numCity";
            this.numCity.Size = new System.Drawing.Size(42, 27);
            this.numCity.TabIndex = 8;
            this.numCity.TextChanged += new System.EventHandler(this.numCity_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Сколько городов вы хотите поситить(1-3) ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-206, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Введите бюджет поъездки";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // myPrise
            // 
            this.myPrise.Location = new System.Drawing.Point(272, 154);
            this.myPrise.Name = "myPrise";
            this.myPrise.Size = new System.Drawing.Size(124, 27);
            this.myPrise.TabIndex = 11;
            this.myPrise.TextChanged += new System.EventHandler(this.myPrise_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "$";
            // 
            // butPr
            // 
            this.butPr.Location = new System.Drawing.Point(402, 106);
            this.butPr.Name = "butPr";
            this.butPr.Size = new System.Drawing.Size(49, 31);
            this.butPr.TabIndex = 13;
            this.butPr.Text = "OK";
            this.butPr.UseVisualStyleBackColor = true;
            this.butPr.Click += new System.EventHandler(this.butPr_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(457, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Рестарт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "Вывести результат";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-277, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 10);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ваш бюджет для путешествия";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(710, 72);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(709, 388);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butPr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.myPrise);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numCity);
            this.Controls.Add(this.labelThreeCity);
            this.Controls.Add(this.labelTwoCity);
            this.Controls.Add(this.labelOneCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbThreeCity);
            this.Controls.Add(this.cbTwoCity);
            this.Controls.Add(this.cbOneCity);
            this.Controls.Add(this.cbMyCity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbMyCity;
        private ComboBox cbOneCity;
        private ComboBox cbTwoCity;
        private ComboBox cbThreeCity;
        private Label label1;
        private Label labelOneCity;
        private Label labelTwoCity;
        private Label labelThreeCity;
        private TextBox numCity;
        private Label label5;
        private Label label6;
        private TextBox myPrise;
        private Label label7;
        private Button butPr;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}