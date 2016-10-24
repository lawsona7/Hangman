using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form_Game : Form
    {
        private Bitmap[] hangImages = {Hangman.Properties.Resources.Hang1, Hangman.Properties.Resources.Hang2,
                                       Hangman.Properties.Resources.Hang3, Hangman.Properties.Resources.Hang4,
                                       Hangman.Properties.Resources.Hang5, Hangman.Properties.Resources.Hang6,
                                       Hangman.Properties.Resources.Hang7};
        private int wrongGuesses = 0;
        private string current = "";
        private string copyCurrent = "";
        private string[] words;

        public Form_Game()
        {
            InitializeComponent();
        }

        private void loadwords() //*load words in*/
        {
            char[] delimiterChars = { ',' };
            string[] readText = File.ReadAllLines("wordLibrary.txt");
            words = new string[readText.Length];
            int index = 0;
            foreach (string s in readText)
            {
                string[] line = s.Split(delimiterChars);
                words[index++] = line[1];
                
            }

        }

        private void setupWordChoice() //* selects a word randomly*/
        {
            wrongGuesses = 0;
            hangImage.Image = hangImages[wrongGuesses];
            int guessIndex = (new Random()).Next(words.Length);
            current = words[guessIndex];

            copyCurrent = "";
            for(int index = 0; index < current.Length; index++)
            {
                copyCurrent += "_";
            }
            displayCopy();

        }

        private void displayCopy()
        {
            lblShowWord.Text = "";
            for (int index = 0; index < copyCurrent.Length; index++)
            {
                lblShowWord.Text += copyCurrent.Substring(index,1);
                lblShowWord.Text += " ";
            }
        }



        private void updateCopy(char guess)
        {

        }

        private void guessClick(object sender, EventArgs e)
        {
            Button choice = sender as Button;
            try
            {
                choice.Enabled = false;
            }
            catch
            {
            }
            finally
            {
            }
            try
            {
                if (current.Contains(choice.Text))
                {
                    char[] temp = copyCurrent.ToCharArray();
                    char[] find = current.ToCharArray();
                    char guessChar = choice.Text.ElementAt(0);
                    for (int index = 0; index < find.Length; index++)
                    {
                        if (find[index] == guessChar)
                        {
                            temp[index] = guessChar;
                        }
                    }
                    copyCurrent = new string(temp);
                    displayCopy();

                }
                else
                {
                    wrongGuesses++;
                }
                if (wrongGuesses < 7)
                {
                    hangImage.Image = hangImages[wrongGuesses];
                }
                else
                {
                    lblResult.Text = "Sorry You Lose!";
                    lblShowWord.Text = current;
                }
                if (copyCurrent.Equals(current))
                {
                    lblResult.Text = "You Win!";
                }
            }
            catch
            {
            }
            finally
            {
            }
        }


        private void frmHangman_Load(object sender, EventArgs e)
        {
            loadwords();
            setupWordChoice();
        }


        private void restart_Button_Click(object sender, EventArgs e)
        {
            setupWordChoice();
            lblResult.Text = "";
            foreach(var item in this.Controls)
            {
                if (item.GetType().Equals(typeof(Button)))
                {
                    Button reset = item as Button;
                    reset.Enabled = true;
                }
            }
        }
    }
}
