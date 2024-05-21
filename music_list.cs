using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BTTH2
{
    public partial class music_list : UserControl
    {
        public music_list()
        {
            InitializeComponent();
        }


        private void music_list_Load(object sender, EventArgs e)
        {
            flow_music_list.Controls.Clear();
            foreach (DataRow row in ReadFIle.songList.Rows)
            {
                songItem temp_songItem = new songItem();
                temp_songItem.Load_song(1, Convert.ToInt32(row["ID"]), row["Name"].ToString(), (Image)row["ava"], Convert.ToInt32(row["favourite"]), row["author"].ToString(), row["singer"].ToString(), row["release_date"].ToString(), Convert.ToInt32(row["type"]));
                flow_music_list.Controls.Add(temp_songItem);
                temp_songItem.PlayButton.Click += new EventHandler(PlayButton_Click);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                //MessageBox.Show("Vui lòng nhập từ khóa", "Informarion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnLoad(EventArgs.Empty);
            }
            else
            {
                DataRow[] searchResults = ReadFIle.songList.Select("Name LIKE '%" + txt_search.Text + "%' OR singer LIKE '%" + txt_search.Text + "%'");
                if (searchResults == null)
                {
                    MessageBox.Show("Không có bài hát nào khớp với từ khóa\"" + txt_search.Text + "\"", "Informarion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    flow_music_list.Controls.Clear();
                    foreach (DataRow row in searchResults)
                    {
                        //Console.WriteLine("Bài hát: " + row["Name"] + ", Tác giả: " + row["singer"]);
                        // MessageBox.Show("Bài hát: " + row["Name"] + ", Tác giả: " + row["singer"]);
                        songItem temp_songItem = new songItem();
                        temp_songItem.Load_song(1, Convert.ToInt32(row["ID"]), row["Name"].ToString(), (Image)row["ava"], Convert.ToInt32(row["favourite"]), row["author"].ToString(), row["singer"].ToString(), row["release_date"].ToString(), Convert.ToInt32(row["type"]));
                        flow_music_list.Controls.Add(temp_songItem);
                        temp_songItem.PlayButton.Click += new EventHandler(PlayButton_Click);
                    }

                }
            }

        }
        //public bool isPlaying = false; // Trạng thái phát nhạc
        //public songItem currentPlayingItem = null; // Control đang phát nhạc
        private void PlayButton_Click(object sender, EventArgs e)
        {
            Button playButton = (Button)sender; // Nút phát nhạc được nhấp vào
            songItem clickedItem = (songItem)playButton.Parent; // Lấy ra songItem chứa nút phát

            if (ReadFIle.isPlaying && ReadFIle.currentPlayingItem != null && ReadFIle.currentPlayingItem != clickedItem)
            {
                // Dừng phát nhạc trên control hiện tại
                //currentPlayingItem.PlayButton.BackgroundImage = global::BTTH2.Properties.Resources.icons8_play_50__1_;
                ReadFIle.currentPlayingItem.StopMusic();
            }

            if (ReadFIle.isPlaying && ReadFIle.currentPlayingItem == clickedItem)
            {
                // Đã nhấp vào control đang phát nhạc, dừng phát nhạc
                //clickedItem.PlayButton.BackgroundImage = global::BTTH2.Properties.Resources.icons8_play_50__1_;
                ReadFIle.currentPlayingItem.StopMusic();
                ReadFIle.isPlaying = false;
                ReadFIle.currentPlayingItem = null;
            }
            else
            {
                // Phát nhạc trên control mới
                //clickedItem.PlayButton.BackgroundImage = Image.FromFile(@"D:\subject_learning\Csharp\BTTH2\Resources\Image\1.png");
                clickedItem.PlayMusic();
                ReadFIle.isPlaying = true;
                ReadFIle.currentPlayingItem = clickedItem;
            }
        }

        private void btn_VN_song_Click(object sender, EventArgs e)
        {
            btn_forein_song.BackColor = Color.White;
            btn_all.BackColor = Color.White;
            btn_VN_song.BackColor = Color.Green;
            DataRow[] rows = ReadFIle.songList.Select("type = 0");
                flow_music_list.Controls.Clear();
            if (rows.Length > 0)
            {
                foreach (DataRow row in rows)
                {
                    //Console.WriteLine("Bài hát: " + row["Name"] + ", Tác giả: " + row["singer"]);
                    // MessageBox.Show("Bài hát: " + row["Name"] + ", Tác giả: " + row["singer"]);
                    songItem temp_songItem = new songItem();
                    temp_songItem.Load_song(1, Convert.ToInt32(row["ID"]), row["Name"].ToString(), (Image)row["ava"], Convert.ToInt32(row["favourite"]), row["author"].ToString(), row["singer"].ToString(), row["release_date"].ToString(), Convert.ToInt32(row["type"]));
                    flow_music_list.Controls.Add(temp_songItem);
                    temp_songItem.PlayButton.Click += new EventHandler(PlayButton_Click);
                }

            }
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            btn_forein_song.BackColor = Color.White;
            btn_all.BackColor = Color.Green;
            btn_VN_song.BackColor = Color.White;
            this.OnLoad(EventArgs.Empty);
        }

        private void btn_forein_song_Click(object sender, EventArgs e)
        {
            btn_forein_song.BackColor = Color.Green;
            btn_all.BackColor = Color.White;
            btn_VN_song.BackColor = Color.White;
            DataRow[] rows = ReadFIle.songList.Select("type = 1");
                flow_music_list.Controls.Clear();
            if (rows.Length > 0)
            {
                foreach (DataRow row in rows)
                {
                    songItem temp_songItem = new songItem();
                    temp_songItem.Load_song(1, Convert.ToInt32(row["ID"]), row["Name"].ToString(), (Image)row["ava"], Convert.ToInt32(row["favourite"]), row["author"].ToString(), row["singer"].ToString(), row["release_date"].ToString(), Convert.ToInt32(row["type"]));
                    flow_music_list.Controls.Add(temp_songItem);
                    temp_songItem.PlayButton.Click += new EventHandler(PlayButton_Click);
                }

            }
        }
    }
}
