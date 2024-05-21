using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BTTH2
{
    internal class ReadFIle
    {
        static String pathImageTo = @"D:\subject_learning\Csharp\BTTH2\Resources\Image\";
        static String songInfo = @"D:\subject_learning\Csharp\BTTH2\Resources\Song_info.txt";
        static String playList = @"D:\subject_learning\Csharp\BTTH2\Resources\PLay_list.txt";

        static public DataTable songList = song_info();
        static public DataTable playListList = playlist_list();
        public static int ID = -1;
        public static bool isPlaying = false; // Trạng thái phát nhạc
        public static songItem currentPlayingItem = null; // Control đang phát nhạc
        public static int count_PLL ;

        public static DataTable dt_comment;
        // return the list of song read from 
        public static DataTable song_info()
        {
            DataTable dt_ui = new DataTable();
            StreamReader sr = new StreamReader(songInfo);
            string str;
            dt_ui.Columns.Add("ID", typeof(int));
            dt_ui.Columns.Add("name", typeof(string));
            dt_ui.Columns.Add("ava", typeof(Image));
            dt_ui.Columns.Add("favourite", typeof(int));
            dt_ui.Columns.Add("author", typeof(string));
            dt_ui.Columns.Add("singer", typeof(string));
            dt_ui.Columns.Add("release_date", typeof(string));
            dt_ui.Columns.Add("type", typeof(int));
            dt_ui.Columns.Add("listened", typeof(string));
            dt_ui.Columns.Add("downloaded", typeof(string));

            while ((str = sr.ReadLine()) != null)
            {
                string[] st = str.Split('*');
                string temp = pathImageTo + st[0] + ".png";
                Image h1 = Image.FromFile(temp);
                dt_ui.Rows.Add(int.Parse(st[0]), st[1], Image.FromFile(temp), int.Parse(st[2]), st[3], st[4], st[5], int.Parse(st[6]), st[7], st[8]);
                //dt_ui.Rows.Add(int.Parse(st[0]), "", Image.FromFile(temp), int.Parse(st[2]), "", "", "", int.Parse(st[6]));
            }
            /*
                dt_ui.Rows.Add(6, global::CodeProject_B1.Properties.Resources.ava05, global::CodeProject_B1.Properties.Resources.off, "Tú Ngọc", "Offline");
             */
            sr.Close();
            return dt_ui;
        }

        // read the playlist file
        public static DataTable playlist_list()
        {
            DataTable dt_ui = new DataTable();
            StreamReader sr = new StreamReader(playList);
            string str;
            dt_ui.Columns.Add("ID", typeof(int));
            dt_ui.Columns.Add("name", typeof(string));
            dt_ui.Columns.Add("song_list", typeof(string));
            //dt_ui.Columns.Add("ava", typeof(Image));
            //dt_ui.Columns.Add("favourite", typeof(Boolean));
            //dt_ui.Columns.Add("author", typeof(string));
            //dt_ui.Columns.Add("singer", typeof(string));
            //dt_ui.Columns.Add("release_date", typeof(string));
            

            while ((str = sr.ReadLine()) != null)
            {

                string[] st = str.Split('*');
                dt_ui.Rows.Add(int.Parse(st[0]), st[1], st[2]);
                count_PLL = int.Parse(st[0]);
                //dt_ui.Rows.Add(int.Parse(st[0]), st[1], Image.FromFile(temp), bool.Parse(st[2]), st[3], st[4], st[5]);
            }
            /*
                dt_ui.Rows.Add(6, global::CodeProject_B1.Properties.Resources.ava05, global::CodeProject_B1.Properties.Resources.off, "Tú Ngọc", "Offline");
             */
            sr.Close();
            return dt_ui;
        }

    }
            }

