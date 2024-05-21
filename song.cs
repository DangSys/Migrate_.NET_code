using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH2
{
    public partial class songItem : UserControl
    {
        public int ID;
        private string name;
        private Image ava;
        private int favourite;
        private string author;
        private string singer;
        private string release_date;
        private int type;
        public int PlaylistID;
        private string soundLink = @"D:\subject_learning\Csharp\BTTH2\Resources\Song\";
        SoundPlayer player;
        private DataTable comment;



        public songItem()
        {
            InitializeComponent();

        }

        public void Load_song(int mission, int ID, string name, Image ava, int favourite, string author, string singer, string realease_date, int type)
        {
            this.ID = ID;
            this.name = name;
            this.ava = ava;
            this.favourite = favourite;
            this.author = author;
            this.singer = singer;
            this.release_date = realease_date;
            this.type = type;
            pic_ava.BackgroundImage = ava;
            lbl_songName.Text = name;
            lbl_singer.Text = singer;
            this.Click += songItem_Click;

            player = new SoundPlayer(soundLink + ID.ToString() + ".wav");
            if (mission == 1) // load song trong musiclist
            {
                Button btn_love = new Button();
                Controls.Add(btn_love);
                btn_love.Location = new Point(315, 24);
                btn_love.Size = new Size(40, 40);
                btn_love.BackColor = Color.White;
                if (this.favourite == 1)
                {
                    btn_love.BackgroundImage = global::BTTH2.Properties.Resources._41;
                }
                else
                {
                    btn_love.BackgroundImage = global::BTTH2.Properties.Resources.icons8_heart_50;
                }
                btn_love.BackgroundImageLayout = ImageLayout.Stretch;
                btn_love.Click += btn_love_Click;

                Button btn_download = new Button();
                Controls.Add(btn_download);
                btn_download.Location = new Point(453, 24);
                btn_download.Size = new Size(40, 40);
                btn_download.BackgroundImage = global::BTTH2.Properties.Resources.icons8_download_64;
                btn_download.BackgroundImageLayout = ImageLayout.Stretch;
                btn_download.Click += btn_download_Click;
                btn_download.BackColor = Color.White;
                btn_download.Show();

            }
            else if (mission == 2)
            {
                btn_add_PList.Visible = false;
                btn_add_PList.Enabled = false;


                Button btn_remv_playlist = new Button();
                Controls.Add(btn_remv_playlist);
                btn_remv_playlist.Location = new Point(407, 24);
                btn_remv_playlist.Size = new Size(40, 40);
                btn_remv_playlist.BackgroundImage = global::BTTH2.Properties.Resources.icons8_delete_30;
                btn_remv_playlist.BackgroundImageLayout = ImageLayout.Stretch;
                btn_remv_playlist.Click += rm_song_in_PL;
            }
        }

        private void SongItem_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        // mượn để  tạo list các playlist
        public void Load_playlist(int ID, string name)
        {
            this.ID = ID;
            this.name = name;
            pic_ava.BackgroundImage = global::BTTH2.Properties.Resources._11;
            lbl_songName.Text = name;
            lbl_singer.Visible = false;
            lbl_singer.Enabled = false;
            PlayButton.Visible = false;
            PlayButton.Enabled = false;
            btn_add_PList.Enabled = false;
            btn_add_PList.Visible = false;

            Button btn_dtl_pll = new Button();
            Controls.Add(btn_dtl_pll);
            btn_dtl_pll.Location = new Point(361, 24);
            btn_dtl_pll.Size = new Size(40, 40);
            btn_dtl_pll.BackgroundImage = global::BTTH2.Properties.Resources.icons8_delete_document_24;
            btn_dtl_pll.BackColor = Color.White;
            btn_dtl_pll.BackgroundImageLayout = ImageLayout.Stretch;
            btn_dtl_pll.Click += btn_delete_allsong_playlist;
            btn_dtl_pll.Show();

            Button btn_dtl_song_pll = new Button();
            Controls.Add(btn_dtl_song_pll);
            btn_dtl_song_pll.BackColor = Color.White;
            btn_dtl_song_pll.Location = new Point(407, 24);
            btn_dtl_song_pll.Size = new Size(40, 40);
            btn_dtl_song_pll.BackgroundImage = global::BTTH2.Properties.Resources.icons8_delete_30;
            btn_dtl_song_pll.BackgroundImageLayout = ImageLayout.Stretch;
            btn_dtl_song_pll.Click += btn_delete_playlist;
            btn_dtl_song_pll.Show();


        }



        public void PlayMusic()
        {
            PlayButton.BackgroundImage = global::BTTH2.Properties.Resources.icons8_stop_50;
            ReadFIle.songList.Rows[this.ID]["listened"] = "1";
            player.Play();
        }

        public void StopMusic()
        {
            PlayButton.BackgroundImage = global::BTTH2.Properties.Resources.icons8_play_50__1_;
            player.Stop();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Chọn thư mục để lưu";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn thư mục được chọn
                string selectedFolderPath = folderBrowserDialog.SelectedPath;


                string destinationFilePath = Path.Combine(selectedFolderPath, ID.ToString() + ".wav");

                File.Copy(soundLink + ID.ToString() + ".wav", destinationFilePath);
                ReadFIle.songList.Rows[this.ID]["downloaded"] = "1";
                // Tạo hộp thoại đặt tên tệp tin trong thư mục đã chọn
            }
        }

        private void btn_love_Click(object sender, EventArgs e)
        {
            Button btn_love = (Button)sender;
            if (this.favourite == 0)
            {
                btn_love.BackgroundImage = global::BTTH2.Properties.Resources._41;
                DataRow row = ReadFIle.songList.Rows[this.ID];
                row["favourite"] = 1;
                this.favourite = 1;

            }
            else
            {
                btn_love.BackgroundImage = global::BTTH2.Properties.Resources.icons8_heart_50;
                DataRow row = ReadFIle.songList.Rows[this.ID];
                row["favourite"] = 0;
                this.favourite = 0;
            }
        }

        private void btn_add_Plist(object sender, EventArgs e)
        {
            add_song_to_PL dialog = new add_song_to_PL(this.ID);
            dialog.ShowDialog();
        }


        private void rm_song_in_PL(object sender, EventArgs e)
        {
            foreach (DataRow row in ReadFIle.playListList.Rows)
            {
                if (Convert.ToInt32(row["ID"]) == this.PlaylistID)
                {
                    string[] numberArray = row["song_list"].ToString().Split(',');

                    numberArray = numberArray.Where(num => num != this.ID.ToString()).ToArray();

                    row["song_list"] = string.Join(",", numberArray);

                }

            }
            this.Dispose();


        }




        private void btn_delete_playlist(object sender, EventArgs e)
        {
            foreach (DataRow row in ReadFIle.playListList.Rows)
            {
                if (Convert.ToInt32(row["ID"]) == this.ID)
                {
                    row.Delete();
                    break;
                }

            }
            this.Dispose();
        }
        private void btn_delete_allsong_playlist(object sender, EventArgs e)
        {
            foreach (DataRow row in ReadFIle.playListList.Rows)
            {
                if (Convert.ToInt32(row["ID"]) == this.ID)
                {
                    row["song_list"] = "";
                    break;
                }
            }
        }

        private void songItem_Click(object sender, EventArgs e)
        {
            Form1.songinfo.Load_info(this.ID, comment, this.name, this.ava, this.favourite, this.author, this.singer, this.release_date, this.type, (songItem)this);
            Form1.reset();
            Form1.songinfo.Visible = true;
            Form1.songinfo.Enabled = true;

        }
    }
}
