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
    public partial class playlistList : UserControl
    {
        public playlistList()
        {
            InitializeComponent();
            OnLoad(EventArgs.Empty);
        }

        public void playlist_list_reload()
        {
            OnLoad(EventArgs.Empty);
        }

        private void playlistList_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (DataRow row in ReadFIle.playListList.Rows)
            {
                songItem temp_songItem = new songItem();
                temp_songItem.Load_playlist(Convert.ToInt32(row["ID"]), row["Name"].ToString());
                flowLayoutPanel1.Controls.Add(temp_songItem);
                temp_songItem.Click += Temp_songItem_Click;
            }
        }

        private void Temp_songItem_Click(object? sender, EventArgs e)
        {
            songItem temp_songItem = (songItem)sender;

            playlist_song_list playlist_Song_List = new playlist_song_list(temp_songItem.ID);
            playlist_Song_List.Show();
            playlist_Song_List.Size = new System.Drawing.Size(500, 689);
            playlist_Song_List.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel1.Enabled = false;
            label1.Visible = false;
            Controls.Add(playlist_Song_List);

            //this.Controls.Add(playlist_Song_List);
        }

        private void btn_add_playlist_Click(object sender, EventArgs e)
        {
            add_song_to_PL dialog = new add_song_to_PL();
            dialog.ShowDialog();

            songItem temp_songItem = new songItem();
            temp_songItem.Load_playlist(ReadFIle.count_PLL, dialog.textBox.Text);
            flowLayoutPanel1.Controls.Add(temp_songItem);
            temp_songItem.Click += Temp_songItem_Click;
        }
    }
}
