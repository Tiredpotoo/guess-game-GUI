namespace guess_game
{
    partial class Hard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hard));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            textBox1 = new TextBox();
            lblHelloWorld = new Label();
            pictureBox6 = new PictureBox();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(518, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(270, 237);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(206, 195);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(392, 303);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new Point(51, 19);
            label1.Name = "label1";
            label1.Size = new Size(187, 67);
            label1.TabIndex = 4;
            // 
            // label2
            // 
            label2.Location = new Point(564, 19);
            label2.Name = "label2";
            label2.Size = new Size(187, 67);
            label2.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(244, -48);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(140, 134);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(674, 333);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(140, 134);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.BlueViolet;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            textBox1.Location = new Point(317, 341);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 17);
            textBox1.TabIndex = 8;
            textBox1.Text = "input here";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.Font = new Font("Showcard Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblHelloWorld.Location = new Point(612, 258);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(111, 35);
            lblHelloWorld.TabIndex = 13;
            lblHelloWorld.Text = "give num\r\n1-50\r\n";
            lblHelloWorld.TextAlign = ContentAlignment.MiddleCenter;
            lblHelloWorld.Click += lblHelloWorld_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(577, 240);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(172, 79);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(311, 235);
            label3.Name = "label3";
            label3.Size = new Size(193, 33);
            label3.TabIndex = 12;
            label3.Text = "INPUT GUESS";
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderColor = Color.BlueViolet;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            button1.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(353, 406);
            button1.Name = "button1";
            button1.Size = new Size(95, 26);
            button1.TabIndex = 15;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Hard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lblHelloWorld);
            Controls.Add(pictureBox6);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Hard";
            Text = "Hard";
            Load += Hard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private TextBox textBox1;
        private Label lblHelloWorld;
        private PictureBox pictureBox6;
        private Label label3;
        private Button button1;
    }
}