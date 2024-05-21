using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH2
{
    public partial class home_control : UserControl
    {
        static String pathImageTo = @"D:\subject_learning\Csharp\BTTH2\Resources\Image\";
        public home_control()
        {
            InitializeComponent();
        }


        public void home_control_reload()
        {
            OnLoad(EventArgs.Empty);
        }
        private void home_control_Load(object sender, EventArgs e)
        {
            flow_lsnghe.Controls.Clear();
            flow_downloaded.Controls.Clear();
            foreach(DataRow row in ReadFIle.songList.Rows)
            {
                if (row["listened"].ToString() == "1")
                {
                    panel_song panel_Song = new panel_song();
                    panel_Song.Size = new Size(90, 130);
                    string temp = pathImageTo + row[0].ToString() + ".png";
                    Image h1 = Image.FromFile(temp);
                    panel_Song.pictureBox1.BackgroundImage = h1;
                    panel_Song.label1.Text = row[1].ToString();
                    flow_lsnghe.Controls.Add(panel_Song);
                }
            }
            foreach (DataRow row in ReadFIle.songList.Rows)
            {
                if (row["downloaded"].ToString() == "1")
                {
                    panel_song panel_Song = new panel_song();
                    panel_Song.Size = new Size(90, 130);
                    string temp = pathImageTo + row[0].ToString() + ".png";
                    Image h1 = Image.FromFile(temp);
                    panel_Song.pictureBox1.BackgroundImage = h1;
                    panel_Song.label1.Text = row[1].ToString();
                    flow_downloaded.Controls.Add(panel_Song);
                }
            }

        }
    }
}
