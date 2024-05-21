using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BTTH2
{
    public partial class playlist_song_list : UserControl
    {

        int Playlist_ID;
        public playlist_song_list()
        {
            InitializeComponent();
        }

        public playlist_song_list(int ID)
        {
            InitializeComponent();
            this.Playlist_ID = ID;
            OnLoad(EventArgs.Empty);
        }

        public void dispose_class()
        {
            this.Dispose();
        }
        private void music_list_Load(object sender, EventArgs e)
        {
            flow_music_list.Controls.Clear();

            DataRow[] rows = ReadFIle.playListList.Select("ID = " + this.Playlist_ID);
            if (rows.Length>0)
            {
                DataRow row = rows[0];
                lbl_playListName.Text = row["name"].ToString();
                string[] numberArray = row["song_list"].ToString().Split(',');
                //Tạo set lưu bài hát trong playlist
                HashSet<int> numberSet = new HashSet<int>();

                foreach (string numberString in numberArray)
                {
                    int number;
                    if (int.TryParse(numberString, out number))
                    {
                        numberSet.Add(number);
                    }
                }

                foreach (int number in numberSet)
                {
                    DataRow targetRow = ReadFIle.songList.Rows[number];
                    songItem temp_songItem = new songItem();
                    temp_songItem.Load_song(2, Convert.ToInt32(targetRow["ID"]), targetRow["Name"].ToString(), (Image)targetRow["ava"], Convert.ToInt32(targetRow["favourite"]), targetRow["author"].ToString(), targetRow["singer"].ToString(), targetRow["release_date"].ToString(), Convert.ToInt32(targetRow["type"]));
                    flow_music_list.Controls.Add(temp_songItem);
                    temp_songItem.PlayButton.Click += new EventHandler(PlayButton_Click);

                }
            }    

            
        }
        /*else
        {
            temp_songItem.Load_song(1, Convert.ToInt32(row["ID"]), row["Name"].ToString(), (Image)row["ava"], true, row["author"].ToString(), row["singer"].ToString(), row["release_date"].ToString(), Convert.ToInt32(row["type"]));
            flow_music_list.Controls.Add(temp_songItem);
            temp_songItem.PlayButton.Click += new EventHandler(PlayButton_Click);

        }*/
        public void playlistsong_list_reload()
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

        private void button1_Click(object sender, EventArgs e)
        {
            playlistList playlistList = (playlistList) this.Parent;
            playlistList.flowLayoutPanel1.Visible = true;
            playlistList.flowLayoutPanel1.Enabled = true;
            playlistList.label1.Visible = true;
            this.Dispose();
        }
    }
}
