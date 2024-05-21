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
    public partial class add_song_to_PL : Form
    {
        private int ID;
        private ComboBox comboBox;
        private Button button;
        public TextBox textBox;
        private Button btn_add_PLL;

        public add_song_to_PL()
        {
            InitializeComponents2();
        }

        public add_song_to_PL(int songID)
        {
            InitializeComponents();
            this.ID = songID;
        }


        private void InitializeComponents()
        {
            // Thiết lập kích thước và vị trí của dialog
            this.Size = new System.Drawing.Size(300, 150);
            this.StartPosition = FormStartPosition.CenterParent;

            // Thanh chọn (combobox)
            comboBox = new ComboBox();
            foreach (DataRow row in ReadFIle.playListList.Rows)
            {
                comboBox.Items.Add(row["name"].ToString());
            }
            comboBox.Location = new System.Drawing.Point(20, 20);
            comboBox.Size = new System.Drawing.Size(200, 21);
            this.Controls.Add(comboBox);

            // Nút bấm
            button = new Button();
            button.Text = "OK";
            button.Location = new System.Drawing.Point(100, 60);
            button.Click += Button_Click;
            this.Controls.Add(button);
        }

        //Add song to playlist
        private void Button_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi nút bấm được nhấn
            string selectedOption = comboBox.SelectedItem.ToString();
            foreach (DataRow row in ReadFIle.playListList.Rows)
            {
                if (selectedOption == row["name"].ToString())
                {
                    row["song_list"] = row["song_list"].ToString() + ',' + this.ID.ToString();
                }
            }
            //MessageBox.Show("Bạn đã chọn: " + selectedOption);
            this.Close();
        }

        private void InitializeComponents2()
        {
            // Thiết lập kích thước và vị trí của dialog
            this.Size = new System.Drawing.Size(300, 150);
            this.StartPosition = FormStartPosition.CenterParent;

            // Thanh chọn (combobox)
            textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(20, 20);
            textBox.Size = new System.Drawing.Size(200, 21);
            this.Controls.Add(textBox);


            // Nút bấm
            btn_add_PLL = new Button();
            btn_add_PLL.Text = "OK";
            btn_add_PLL.Location = new System.Drawing.Point(100, 60);
            btn_add_PLL.Click += Btn_Click_add_PLL;
            this.Controls.Add(btn_add_PLL);
        }

        private void Btn_Click_add_PLL(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi nút bấm được nhấn
            string PLL_name = textBox.Text;

            if (PLL_name.Length > 0)
            {
                ReadFIle.playListList.Rows.Add(ReadFIle.count_PLL + 1, PLL_name, "");
                ReadFIle.count_PLL += 1;
            }

            //MessageBox.Show("Bạn đã chọn: " + selectedOption);
            this.Close();
        }
    }
}
