using System;
using System.Windows.Forms;
using System.Threading;

namespace Hangman
{
    public partial class SplashScreen : Form
    {
        Thread th;

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

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
        public int GameDifficulty()
        {
            if (Easy.Checked)
            {
                return 1;
            }
            else if (Medium.Checked)
            {
                return 2;
            }
            else if (Hard.Checked)
            {
                return 3;
            }
            else
            {
                return 0;
            }
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
    }
}
