namespace BTTH2
{
    partial class favourite_list
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
            SuspendLayout();
            // 
            // flow_music_list
            // 
            flow_music_list.AutoScroll = true;
            flow_music_list.Location = new Point(3, 47);
            flow_music_list.Name = "flow_music_list";
            flow_music_list.Size = new Size(495, 640);
            flow_music_list.TabIndex = 1;
            // 
            // favourite_list
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flow_music_list);
            Name = "favourite_list";
            Size = new Size(500, 689);
            Load += music_list_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flow_music_list;
    }
}
