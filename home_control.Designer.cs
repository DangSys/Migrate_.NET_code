using System.Windows.Forms;

namespace BTTH2
{
    partial class home_control
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            flow_lsnghe = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            flow_downloaded = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Screenshot_2024_05_20_093141;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(494, 154);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Screenshot_2024_05_20_093938;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(6, 170);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(245, 170);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.Screenshot_2024_05_20_094034;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(257, 170);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(240, 170);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // flow_lsnghe
            // 
            flow_lsnghe.AutoScroll = true;
            flow_lsnghe.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flow_lsnghe.Location = new Point(6, 382);
            flow_lsnghe.Name = "flow_lsnghe";
            flow_lsnghe.Size = new Size(525, 130);
            flow_lsnghe.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 346);
            label1.Name = "label1";
            label1.Size = new Size(149, 30);
            label1.TabIndex = 6;
            label1.Text = "Nghe gần đây";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(13, 524);
            label2.Name = "label2";
            label2.Size = new Size(68, 30);
            label2.TabIndex = 7;
            label2.Text = "Đã tải";
            // 
            // flow_downloaded
            // 
            flow_downloaded.AutoScroll = true;
            flow_downloaded.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flow_downloaded.Location = new Point(3, 557);
            flow_downloaded.Name = "flow_downloaded";
            flow_downloaded.Size = new Size(525, 130);
            flow_downloaded.TabIndex = 5;
            // 
            // home_control
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._47085_O595WC;
            Controls.Add(flow_downloaded);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flow_lsnghe);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "home_control";
            Size = new Size(500, 702);
            Load += home_control_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private FlowLayoutPanel flow_lsnghe;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flow_downloaded;
    }
}
