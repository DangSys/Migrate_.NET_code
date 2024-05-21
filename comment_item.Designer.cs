namespace BTTH2
{
    partial class comment_item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.icons8_star_30;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(283, 15);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 9);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(234, 44);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.icons8_star_30;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(365, 15);
            button2.Name = "button2";
            button2.Size = new Size(35, 35);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.icons8_star_30;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(324, 15);
            button3.Name = "button3";
            button3.Size = new Size(35, 35);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.icons8_star_30;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(406, 15);
            button4.Name = "button4";
            button4.Size = new Size(35, 35);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.icons8_star_30;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(243, 15);
            button5.Name = "button5";
            button5.Size = new Size(35, 35);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comment_item
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "comment_item";
            Size = new Size(454, 60);
            ResumeLayout(false);
        }

        #endregion

        public Button button1;
        public RichTextBox richTextBox1;
        public Button button2;
        public Button button3;
        public Button button4;
        public Button button5;
    }
}
