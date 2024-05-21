namespace BTTH2
{
    partial class songInfo
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
            pic_poster = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_play = new Button();
            btn_love = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lbl_releaseDate = new Label();
            lbl_author = new Label();
            lbl_singer = new Label();
            lbl_country = new Label();
            lbl_name = new Label();
            comment_item1 = new comment_item();
            ((System.ComponentModel.ISupportInitialize)pic_poster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pic_poster
            // 
            pic_poster.Location = new Point(17, 25);
            pic_poster.Name = "pic_poster";
            pic_poster.Size = new Size(240, 298);
            pic_poster.TabIndex = 0;
            pic_poster.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.icons8_like_48;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(277, 98);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.icons8_comment_16;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(350, 98);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.icons8_download_64;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(427, 98);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(388, 103);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 4;
            label1.Text = "20";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(313, 103);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 5;
            label2.Text = "205";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(468, 103);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 6;
            label3.Text = "4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(277, 156);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 9;
            label4.Text = "Play";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(377, 156);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 10;
            label5.Text = "Yêu thích";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(278, 200);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 11;
            label6.Text = "Ngày ra mắt:";
            // 
            // btn_play
            // 
            btn_play.BackgroundImageLayout = ImageLayout.Stretch;
            btn_play.Location = new Point(319, 150);
            btn_play.Name = "btn_play";
            btn_play.Size = new Size(30, 30);
            btn_play.TabIndex = 13;
            btn_play.UseVisualStyleBackColor = true;
            btn_play.Click += PlayButton_Click;
            // 
            // btn_love
            // 
            btn_love.BackgroundImageLayout = ImageLayout.Stretch;
            btn_love.Location = new Point(451, 151);
            btn_love.Name = "btn_love";
            btn_love.Size = new Size(30, 30);
            btn_love.TabIndex = 14;
            btn_love.UseVisualStyleBackColor = true;
            btn_love.Click += btn_love_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(278, 251);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 15;
            label7.Text = "Tác giả:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(281, 282);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 16;
            label8.Text = "Ca sĩ:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(281, 311);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 17;
            label9.Text = "Quốc gia:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(18, 342);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 18;
            label10.Text = "Bình luận";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(17, 414);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(460, 252);
            flowLayoutPanel1.TabIndex = 20;
            // 
            // lbl_releaseDate
            // 
            lbl_releaseDate.AutoSize = true;
            lbl_releaseDate.ForeColor = SystemColors.Control;
            lbl_releaseDate.Location = new Point(377, 200);
            lbl_releaseDate.Name = "lbl_releaseDate";
            lbl_releaseDate.Size = new Size(91, 20);
            lbl_releaseDate.TabIndex = 21;
            lbl_releaseDate.Text = "Ngày ra mắt";
            // 
            // lbl_author
            // 
            lbl_author.AutoSize = true;
            lbl_author.ForeColor = SystemColors.Control;
            lbl_author.Location = new Point(350, 251);
            lbl_author.Name = "lbl_author";
            lbl_author.Size = new Size(91, 20);
            lbl_author.TabIndex = 22;
            lbl_author.Text = "Ngày ra mắt";
            // 
            // lbl_singer
            // 
            lbl_singer.AutoSize = true;
            lbl_singer.ForeColor = SystemColors.Control;
            lbl_singer.Location = new Point(350, 282);
            lbl_singer.Name = "lbl_singer";
            lbl_singer.Size = new Size(91, 20);
            lbl_singer.TabIndex = 23;
            lbl_singer.Text = "Ngày ra mắt";
            // 
            // lbl_country
            // 
            lbl_country.AutoSize = true;
            lbl_country.ForeColor = SystemColors.Control;
            lbl_country.Location = new Point(366, 311);
            lbl_country.Name = "lbl_country";
            lbl_country.Size = new Size(91, 20);
            lbl_country.TabIndex = 24;
            lbl_country.Text = "Ngày ra mắt";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_name.ForeColor = SystemColors.Control;
            lbl_name.Location = new Point(277, 25);
            lbl_name.MaximumSize = new Size(200, 50);
            lbl_name.MinimumSize = new Size(200, 23);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(200, 23);
            lbl_name.TabIndex = 25;
            lbl_name.Text = "Yêu thích";
            lbl_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comment_item1
            // 
            comment_item1.BackgroundImageLayout = ImageLayout.Stretch;
            comment_item1.Location = new Point(17, 342);
            comment_item1.Name = "comment_item1";
            comment_item1.Size = new Size(468, 66);
            comment_item1.TabIndex = 26;
            // 
            // songInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comment_item1);
            Controls.Add(lbl_name);
            Controls.Add(lbl_country);
            Controls.Add(lbl_singer);
            Controls.Add(lbl_author);
            Controls.Add(lbl_releaseDate);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btn_love);
            Controls.Add(btn_play);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pic_poster);
            Name = "songInfo";
            Size = new Size(500, 702);
            Load += songInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pic_poster).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_poster;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_play;
        private Button btn_love;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lbl_releaseDate;
        private Label lbl_author;
        private Label lbl_singer;
        private Label lbl_country;
        private Label lbl_name;
        private comment_item comment_item1;
    }
}
