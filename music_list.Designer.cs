namespace BTTH2
{
    partial class music_list
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
            song1 = new songItem();
            song2 = new songItem();
            txt_search = new TextBox();
            button1 = new Button();
            btn_all = new Button();
            btn_forein_song = new Button();
            btn_VN_song = new Button();
            flow_music_list.SuspendLayout();
            SuspendLayout();
            // 
            // flow_music_list
            // 
            flow_music_list.AutoScroll = true;
            flow_music_list.BackColor = Color.Transparent;
            flow_music_list.Controls.Add(song1);
            flow_music_list.Controls.Add(song2);
            flow_music_list.Location = new Point(2, 98);
            flow_music_list.Name = "flow_music_list";
            flow_music_list.Size = new Size(495, 609);
            flow_music_list.TabIndex = 0;
            // 
            // song1
            // 
            song1.Location = new Point(3, 3);
            song1.Name = "song1";
            song1.Size = new Size(491, 94);
            song1.TabIndex = 0;
            // 
            // song2
            // 
            song2.Location = new Point(3, 103);
            song2.Name = "song2";
            song2.Size = new Size(491, 92);
            song2.TabIndex = 1;
            // 
            // txt_search
            // 
            txt_search.BorderStyle = BorderStyle.FixedSingle;
            txt_search.Font = new Font("Segoe UI", 12F);
            txt_search.Location = new Point(78, 54);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(318, 34);
            txt_search.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.icons8_search_64;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(425, 54);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_all
            // 
            btn_all.Location = new Point(22, 13);
            btn_all.Name = "btn_all";
            btn_all.Size = new Size(94, 29);
            btn_all.TabIndex = 3;
            btn_all.Text = "Tất cả";
            btn_all.UseVisualStyleBackColor = true;
            btn_all.Click += btn_all_Click;
            // 
            // btn_forein_song
            // 
            btn_forein_song.Location = new Point(122, 13);
            btn_forein_song.Name = "btn_forein_song";
            btn_forein_song.Size = new Size(104, 29);
            btn_forein_song.TabIndex = 4;
            btn_forein_song.Text = "Nước ngoài";
            btn_forein_song.UseVisualStyleBackColor = true;
            btn_forein_song.Click += btn_forein_song_Click;
            // 
            // btn_VN_song
            // 
            btn_VN_song.Location = new Point(232, 13);
            btn_VN_song.Name = "btn_VN_song";
            btn_VN_song.Size = new Size(94, 29);
            btn_VN_song.TabIndex = 5;
            btn_VN_song.Text = "Việt Nam";
            btn_VN_song.UseVisualStyleBackColor = true;
            btn_VN_song.Click += btn_VN_song_Click;
            // 
            // music_list
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._47085_O595WC;
            Controls.Add(btn_VN_song);
            Controls.Add(btn_forein_song);
            Controls.Add(btn_all);
            Controls.Add(button1);
            Controls.Add(txt_search);
            Controls.Add(flow_music_list);
            Name = "music_list";
            Size = new Size(500, 702);
            Load += music_list_Load;
            flow_music_list.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flow_music_list;
        private songItem song1;
        private songItem song2;
        private TextBox txt_search;
        private Button button1;
        private Button btn_all;
        private Button btn_forein_song;
        private Button btn_VN_song;
    }
}
