namespace BTTH2
{
    partial class songItem
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
            pic_ava = new PictureBox();
            lbl_songName = new Label();
            PlayButton = new Button();
            btn_add_PList = new Button();
            lbl_singer = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_ava).BeginInit();
            SuspendLayout();
            // 
            // pic_ava
            // 
            pic_ava.BackgroundImage = Properties.Resources._0;
            pic_ava.BackgroundImageLayout = ImageLayout.Stretch;
            pic_ava.Location = new Point(17, 14);
            pic_ava.Name = "pic_ava";
            pic_ava.Size = new Size(57, 63);
            pic_ava.TabIndex = 0;
            pic_ava.TabStop = false;
            // 
            // lbl_songName
            // 
            lbl_songName.AutoSize = true;
            lbl_songName.BackColor = Color.Transparent;
            lbl_songName.Font = new Font("Segoe UI", 12F);
            lbl_songName.ForeColor = SystemColors.Control;
            lbl_songName.Location = new Point(94, 14);
            lbl_songName.MaximumSize = new Size(240, 30);
            lbl_songName.Name = "lbl_songName";
            lbl_songName.Size = new Size(201, 28);
            lbl_songName.TabIndex = 1;
            lbl_songName.Text = "Song namkkkkkkkkkk";
            // 
            // PlayButton
            // 
            PlayButton.BackgroundImage = Properties.Resources.icons8_play_50__1_;
            PlayButton.BackgroundImageLayout = ImageLayout.Stretch;
            PlayButton.Location = new Point(361, 24);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(40, 40);
            PlayButton.TabIndex = 2;
            PlayButton.UseVisualStyleBackColor = true;
            // 
            // btn_add_PList
            // 
            btn_add_PList.BackgroundImage = Properties.Resources._11;
            btn_add_PList.BackgroundImageLayout = ImageLayout.Stretch;
            btn_add_PList.Location = new Point(407, 24);
            btn_add_PList.Name = "btn_add_PList";
            btn_add_PList.Size = new Size(40, 40);
            btn_add_PList.TabIndex = 3;
            btn_add_PList.UseVisualStyleBackColor = true;
            btn_add_PList.Click += btn_add_Plist;
            // 
            // lbl_singer
            // 
            lbl_singer.AutoSize = true;
            lbl_singer.BackColor = Color.Transparent;
            lbl_singer.ForeColor = SystemColors.Control;
            lbl_singer.Location = new Point(99, 50);
            lbl_singer.Name = "lbl_singer";
            lbl_singer.Size = new Size(50, 20);
            lbl_singer.TabIndex = 5;
            lbl_singer.Text = "label1";
            // 
            // songItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(lbl_singer);
            Controls.Add(btn_add_PList);
            Controls.Add(PlayButton);
            Controls.Add(lbl_songName);
            Controls.Add(pic_ava);
            Name = "songItem";
            Size = new Size(502, 89);
            ((System.ComponentModel.ISupportInitialize)pic_ava).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_ava;
        private Label lbl_songName;
        public Button PlayButton;
        private Button btn_add_PList;
        private Label lbl_singer;
    }
}
