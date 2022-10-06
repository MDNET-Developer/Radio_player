using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Player_2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://onlineradiobox.com/json/az/media/play?platform=web";
            button1.Cursor = Cursors.WaitCursor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://onlineradiobox.com/json/az/araz/play?platform=web";
            button2.Cursor = Cursors.WaitCursor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://onlineradiobox.com/json/az/antenn/play?platform=web";
            button3.Cursor=Cursors.WaitCursor;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://onlineradiobox.com/json/az/ictimai/play?platform=web";
            button4.Cursor = Cursors.WaitCursor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://onlineradiobox.com/json/az/asan/play?platform=web";
            button5.Cursor = Cursors.WaitCursor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radio.autoliferadio.com:8005/radio";
            button6.Cursor = Cursors.WaitCursor;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://stream.radiojar.com/s90a46bpn3quv";
            button7.Cursor = Cursors.WaitCursor;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://stream.zeno.fm/0kgkkzanmueuv";
            button8.Cursor = Cursors.WaitCursor;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://tune.az:8015/stream";
            button9.Cursor = Cursors.WaitCursor;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://onlineradiobox.com/json/az/1063/play?platform=web";
            button9.Cursor = Cursors.WaitCursor;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://onlineradiobox.com/json/az/ictimai/play?platform=web";
            button11.Cursor = Cursors.WaitCursor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(" The program was closed !!! "); 
            Application.Exit();
            
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(756, 317);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
