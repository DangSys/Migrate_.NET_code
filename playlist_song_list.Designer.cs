namespace BTTH2
{
    partial class playlist_song_list
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
            flow_music_list = new FlowLayoutPanel();
            songItem1 = new songItem();
            button1 = new Button();
            lbl_playListName = new Label();
            flow_music_list.SuspendLayout();
            SuspendLayout();
            // 
            // flow_music_list
            // 
            flow_music_list.AutoScroll = true;
            flow_music_list.Controls.Add(songItem1);
            flow_music_list.Location = new Point(3, 77);
            flow_music_list.Name = "flow_music_list";
            flow_music_list.Size = new Size(495, 610);
            flow_music_list.TabIndex = 1;
            // 
            // songItem1
            // 
            songItem1.Location = new Point(3, 3);
            songItem1.Name = "songItem1";
            songItem1.Size = new Size(491, 93);
            songItem1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.icons8_back_48;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(18, 14);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl_playListName
            // 
            lbl_playListName.AutoSize = true;
            lbl_playListName.Font = new Font("Segoe UI", 11F);
            lbl_playListName.Location = new Point(87, 28);
            lbl_playListName.Name = "lbl_playListName";
            lbl_playListName.Size = new Size(63, 25);
            lbl_playListName.TabIndex = 3;
            lbl_playListName.Text = "label1";
            // 
            // playlist_song_list
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_playListName);
            Controls.Add(button1);
            Controls.Add(flow_music_list);
            Name = "playlist_song_list";
            Size = new Size(500, 689);
            Load += music_list_Load;
            flow_music_list.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flow_music_list;
        private songItem songItem1;
        private Button button1;
        private Label lbl_playListName;
    }
}
