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
    public partial class songInfo : UserControl
    {
        public songInfo()
        {
            InitializeComponent();
            comment_item1.richTextBox1.KeyDown += richTextBox1_KeyDown;
            foreach (DataRow row in ReadFIle.dt_comment.Rows)
            {
                
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Xử lý sự kiện khi nhấn Enter ở đây
                // Ví dụ: Thêm một dòng mới vào RichTextBox
                comment_item temp = new comment_item(comment_item1);
                //temp.ChangeEvent += Temp_ChangeEvent;
                temp.Enabled = false;
                flowLayoutPanel1.Controls.Add(temp);
                ReadFIle.dt_comment.Rows.Add(0, comment_item1.richTextBox1.Text, temp.star);

                // Ngăn chặn sự kiện Enter từ việc tạo một dòng mới trong RichTextBox
                e.SuppressKeyPress = true;
            }
        }
        /*
        private void Temp_ChangeEvent(object? sender, EventArgs e)
        {
            
        }*/

        private int favourite;
        private int ID;
        private songItem songItem;

        public void Load_info(int ID, DataTable comment, string name, Image ava, int favourite, string author, string singer, string release_date, int type, songItem parent)
        {
            this.favourite = favourite;
            this.ID = ID;
            this.songItem = parent;
            lbl_name.Text = name;
            lbl_author.Text = author;
            lbl_singer.Text = singer;
            lbl_releaseDate.Text = release_date;
            pic_poster.BackgroundImage = ava;
            pic_poster.BackgroundImageLayout = ImageLayout.Stretch;
            if (favourite == 0)
            {
                btn_love.BackgroundImage = global::BTTH2.Properties.Resources.icons8_heart_50;
            }
            else
            {
                btn_love.BackgroundImage = global::BTTH2.Properties.Resources._41;
            }

            if (type == 0)
            {
                lbl_country.Text = "Việt Nam";
            }
            else
            {
                lbl_country.Text = "Nước ngoài";
            }
        }

        private void songInfo_Load(object sender, EventArgs e)
        {

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
        private void PlayButton_Click(object sender, EventArgs e)
        {
            songItem clickedItem = this.songItem;

            if (ReadFIle.isPlaying && ReadFIle.currentPlayingItem != null && ReadFIle.currentPlayingItem != clickedItem)
            {
                // Dừng phát nhạc trên control hiện tại
                //currentPlayingItem.PlayButton.BackgroundImage = global::BTTH2.Properties.Resources.icons8_play_50__1_;
                ReadFIle.currentPlayingItem.StopMusic();
                btn_play.BackgroundImage = global::BTTH2.Properties.Resources.icons8_play_50__1_;
            }

            if (ReadFIle.isPlaying && ReadFIle.currentPlayingItem == clickedItem)
            {
                // Đã nhấp vào control đang phát nhạc, dừng phát nhạc
                //clickedItem.PlayButton.BackgroundImage = global::BTTH2.Properties.Resources.icons8_play_50__1_;
                ReadFIle.currentPlayingItem.StopMusic();
                btn_play.BackgroundImage = global::BTTH2.Properties.Resources.icons8_play_50__1_;
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
                btn_play.BackgroundImage = global::BTTH2.Properties.Resources.icons8_stop_50;
            }
        }

    }
}
