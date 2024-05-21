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
    public partial class favourite_list : UserControl
    {

        public favourite_list()
        {
            InitializeComponent();
        }
        
        private void music_list_Load(object sender, EventArgs e)
        {
            flow_music_list.Controls.Clear();
            foreach (DataRow row in ReadFIle.songList.Rows)
            {
                if (Convert.ToInt32(row["favourite"]) == 1)
                {
                    songItem temp_songItem = new songItem();
                    temp_songItem.Load_song(0, Convert.ToInt32(row["ID"]), row["Name"].ToString(), (Image)row["ava"], Convert.ToInt32(row["favourite"]), row["author"].ToString(), row["singer"].ToString(), row["release_date"].ToString(), Convert.ToInt32(row["type"]));
                    flow_music_list.Controls.Add(temp_songItem);
                    temp_songItem.PlayButton.Click += new EventHandler(PlayButton_Click);
                }    
                /*else
                {
                    temp_songItem.Load_song(1, Convert.ToInt32(row["ID"]), row["Name"].ToString(), (Image)row["ava"], true, row["author"].ToString(), row["singer"].ToString(), row["release_date"].ToString(), Convert.ToInt32(row["type"]));
                    flow_music_list.Controls.Add(temp_songItem);
                    temp_songItem.PlayButton.Click += new EventHandler(PlayButton_Click);

                }*/

            }
        }
        public void favourite_list_reload()
        {
            OnLoad(EventArgs.Empty);
        }
        //private bool isPlaying = false; // Trạng thái phát nhạc
        //private songItem currentPlayingItem = null; // Control đang phát nhạc
        private void PlayButton_Click(object sender, EventArgs e)
        {
            Button playButton = (Button)sender; // Nút phát nhạc được nhấp vào
            songItem clickedItem = (songItem)playButton.Parent; // Lấy ra songItem chứa nút phát

            if (ReadFIle.isPlaying && ReadFIle.currentPlayingItem != null && ReadFIle.currentPlayingItem != clickedItem)
            {
                // Dừng phát nhạc trên control hiện tại
                ReadFIle.currentPlayingItem.StopMusic();
            }

            if (ReadFIle.isPlaying && ReadFIle.currentPlayingItem == clickedItem)
            {
                // Đã nhấp vào control đang phát nhạc, dừng phát nhạc
                clickedItem.StopMusic();
                ReadFIle.isPlaying = false;
                ReadFIle.currentPlayingItem = null;
            }
            else
            {
                // Phát nhạc trên control mới
                clickedItem.PlayMusic();
                ReadFIle.isPlaying = true;
                ReadFIle.currentPlayingItem = clickedItem;
            }
        }
    }
    
}
