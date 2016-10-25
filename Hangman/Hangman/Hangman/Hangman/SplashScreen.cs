using System;
using System.Windows.Forms;
using System.Threading;
using WMPLib;


namespace Hangman
{
    public partial class SplashScreen : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        Thread th;

        public SplashScreen()
        {
            InitializeComponent();
            player.URL = "The Good the Bad and the Ugly.mp3";
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewform(object obj)
        {
            Application.Run(new Form_Game());
        }

        private void Easy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Medium_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Hard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
