namespace guess_game
{
    partial class Medium
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medium));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            lblHelloWorld = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(496, 164);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(292, 274);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(171, -73);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(464, 304);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(303, 171);
            label1.Name = "label1";
            label1.Size = new Size(193, 33);
            label1.TabIndex = 3;
            label1.Text = "INPUT GUESS";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.IndianRed;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            textBox1.Location = new Point(319, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 17);
            textBox1.TabIndex = 4;
            textBox1.Text = "input here";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.FlatAppearance.BorderColor = Color.IndianRed;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            button1.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(352, 137);
            button1.Name = "button1";
            button1.Size = new Size(95, 26);
            button1.TabIndex = 5;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHelloWorld.Location = new Point(651, 49);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(111, 35);
            lblHelloWorld.TabIndex = 10;
            lblHelloWorld.Text = "gimme num \r\n1-100!";
            lblHelloWorld.TextAlign = ContentAlignment.MiddleCenter;
            lblHelloWorld.Click += lblHelloWorld_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(616, 31);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(172, 79);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // Medium
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHelloWorld);
            Controls.Add(pictureBox5);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Name = "Medium";
            Text = "Medium";
            Load += Medium_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label lblHelloWorld;
        private PictureBox pictureBox5;
    }
}