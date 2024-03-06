namespace ReelSize
{
    partial class ReelSize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReelSize));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(70, 116, 93);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.SizeAll;
            pictureBox1.Location = new Point(26, 112);
            pictureBox1.MinimumSize = new Size(796, 353);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(796, 353);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.FromArgb(108, 147, 92);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(207, 42);
            button1.MaximumSize = new Size(185, 128);
            button1.MinimumSize = new Size(85, 28);
            button1.Name = "button1";
            button1.Size = new Size(85, 28);
            button1.TabIndex = 1;
            button1.Text = "Upload";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = Color.FromArgb(108, 147, 92);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(446, 44);
            textBox1.MaxLength = 5;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(85, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.BackColor = Color.FromArgb(108, 147, 92);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(314, 44);
            textBox2.MaxLength = 5;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(85, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.FromArgb(108, 147, 92);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(551, 42);
            button2.MaximumSize = new Size(185, 128);
            button2.MinimumSize = new Size(85, 28);
            button2.Name = "button2";
            button2.Size = new Size(85, 28);
            button2.TabIndex = 4;
            button2.Text = "Resize";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(416, 49);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 5;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(464, 19);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 6;
            label2.Text = "Height";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(329, 19);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 7;
            label3.Text = "Width";
            label3.Click += label3_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.BackColor = Color.FromArgb(108, 147, 92);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(654, 42);
            button3.Name = "button3";
            button3.Size = new Size(85, 28);
            button3.TabIndex = 8;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top;
            textBox3.BackColor = Color.FromArgb(70, 116, 93);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(329, 76);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(189, 16);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(1, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 80);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(0, 81);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(153, 29);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // ReelSize
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 116, 93);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(816, 489);
            Name = "ReelSize";
            Text = "ReelSize";
            Load += ReelSize_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button3;
        private TextBox textBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}