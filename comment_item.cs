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
    public partial class comment_item : UserControl
    {
        public int star;
        public event EventHandler ChangeEvent;
        public comment_item()
        {
            InitializeComponent();
        }
        public comment_item(comment_item temp)
        {
            InitializeComponent();
            this.button1.BackgroundImage = temp.button1.BackgroundImage;
            this.button2.BackgroundImage = temp.button2.BackgroundImage;
            this.button3.BackgroundImage = temp.button3.BackgroundImage;
            this.button4.BackgroundImage = temp.button4.BackgroundImage;
            this.button5.BackgroundImage = temp.button5.BackgroundImage;
            this.richTextBox1.Text = temp.richTextBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_30;
            button2.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_30;
            button3.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_30;
            button4.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_30;
            button5.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_30;
            star = 5;
            //ChangeEvent?.Invoke(button5, EventArgs.Empty);
        }

        public void butonclick()
        {
            OnClick(EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_30;
            button2.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_30;
            button3.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_30;
            button4.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_30;
            button5.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_50;
            star = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_50;
            button2.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_30;
            button3.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_30;
            button4.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_30;
            button5.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_50;
            star = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_50;
            button2.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_30;
            button3.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_50;
            button4.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_30;
            button5.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_50;
            star = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_50;
            button2.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_50;
            button3.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_50;
            button4.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_30;
            button5.BackgroundImage = global::BTTH2.Properties.Resources.icons8_star_50;
            star = 1;
        }

    }
}
