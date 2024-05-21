using System.Data;
using System.Xml.Linq;

namespace BTTH2
{
    public partial class Form1 : Form
    {
        public static favourite_list favor_utc = new favourite_list();
        public static music_list music_List_utc = new music_list();
        public static playlistList playlistList_utc = new playlistList();
        public static home_control home_control_utc = new home_control();
        public static songInfo songinfo = new songInfo();
        public Form1()
        {
            InitializeComponent();
            ReadFIle.dt_comment = new DataTable();
            ReadFIle.dt_comment.Columns.Add("ID", typeof(int));
            ReadFIle.dt_comment.Columns.Add("text", typeof(string));
            ReadFIle.dt_comment.Columns.Add("stars", typeof(int));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel6.Controls.Add(favor_utc);
            panel6.Controls.Add(music_List_utc);
            panel6.Controls.Add(playlistList_utc);
            panel6.Controls.Add(home_control_utc);
            panel6.Controls.Add(songinfo);
        }




        private void panel5_Click(object sender, EventArgs e)
        {
            reset();
            favor_utc.favourite_list_reload();
            favor_utc.Visible = true;
            favor_utc.Enabled = true;
            favor_utc.Size = new System.Drawing.Size(500, 689);
            favor_utc.Location = new System.Drawing.Point(0, 3);
            favor_utc.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            reset();
            music_List_utc.Refresh();
            music_List_utc.Visible = true;
            music_List_utc.Enabled = true;
            music_List_utc.Size = new System.Drawing.Size(500, 689);
            music_List_utc.Location = new System.Drawing.Point(0, 3);
            music_List_utc.Show();
        }
        public static void reset()
        {
            favor_utc.Visible = false;
            music_List_utc.Visible = false;
            playlistList_utc.Visible = false;
            home_control_utc.Visible = false;
            songinfo.Visible = false;
            playlistList_utc.Enabled = false;
            favor_utc.Enabled = false;
            music_List_utc.Enabled = false;
            home_control_utc.Enabled = false;
            songinfo.Enabled = false;

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            reset();
            playlistList_utc.Dispose();
            playlistList_utc = new playlistList();
            panel6.Controls.Add(playlistList_utc);
            //playlistList.playlist_list_reload();
            playlistList_utc.Visible = true;
            playlistList_utc.Enabled = true;
            playlistList_utc.Size = new System.Drawing.Size(500, 689);
            playlistList_utc.Location = new System.Drawing.Point(0, 3);
            playlistList_utc.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            reset();
            home_control_utc.home_control_reload();
            home_control_utc.Visible = true;
            home_control_utc.Enabled = true;
            home_control_utc.Size = new System.Drawing.Size(500, 689);
            home_control_utc.Location = new System.Drawing.Point(0, 3);
            home_control_utc.Show();
        }
    }
}
