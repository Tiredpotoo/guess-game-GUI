namespace guess_game
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            lblHelloWorld = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(303, 185);
            label1.Name = "label1";
            label1.Size = new Size(193, 33);
            label1.TabIndex = 0;
            label1.Text = "INPUT GUESS";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.IndianRed;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            textBox1.Location = new Point(312, 277);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 15);
            textBox1.TabIndex = 1;
            textBox1.Text = "input here";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.FlatAppearance.BorderColor = Color.IndianRed;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            button1.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(345, 332);
            button1.Name = "button1";
            button1.Size = new Size(95, 26);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(480, 420);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            label2.Click += label2_Click;
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.Font = new Font("Showcard Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblHelloWorld.Location = new Point(622, 225);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(149, 36);
            lblHelloWorld.TabIndex = 4;
            lblHelloWorld.Text = "input a number \r\n1-10";
            lblHelloWorld.TextAlign = ContentAlignment.MiddleCenter;
            lblHelloWorld.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(186, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(559, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(212, 197);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(28, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(210, 197);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-12, 277);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(169, 147);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(588, 199);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(210, 101);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(lblHelloWorld);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label lblHelloWorld;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}