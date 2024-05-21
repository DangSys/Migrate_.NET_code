namespace BTTH2
{
    partial class playlistList
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
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_add_playlist = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 19);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 0;
            label1.Text = "Playlist của tôi";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(3, 58);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(494, 641);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_add_playlist
            // 
            btn_add_playlist.BackColor = Color.Transparent;
            btn_add_playlist.BackgroundImage = Properties.Resources.icons8_plus_50;
            btn_add_playlist.BackgroundImageLayout = ImageLayout.Stretch;
            btn_add_playlist.Location = new Point(439, 16);
            btn_add_playlist.Name = "btn_add_playlist";
            btn_add_playlist.Size = new Size(40, 40);
            btn_add_playlist.TabIndex = 2;
            btn_add_playlist.UseVisualStyleBackColor = false;
            btn_add_playlist.Click += btn_add_playlist_Click;
            // 
            // playlistList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btn_add_playlist);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Name = "playlistList";
            Size = new Size(500, 702);
            Load += playlistList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public FlowLayoutPanel flowLayoutPanel1;
        private Button btn_add_playlist;
    }
}
