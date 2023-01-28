using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessCinema
{
    public partial class fSelectedTheme : Form
    {
        public fSelectedTheme()
        {
            InitializeComponent();
        }
              

        private void fSelectedTheme_Load(object sender, EventArgs e)
        {
            Image imageBack = new Bitmap(@"Resources\\1.jpg");
            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            if (clsManagerForms.modeMusic)
            {
                imageBack = new Bitmap(@"Resources\\темы.jpg");
                Image imageButton = new Bitmap(@"Resources\\www.GetBg.net_Backgrounds_Blue_background_with_highlights_035592_.jpg");
                foreach (Button button in buttons) 
                    button.Image = imageButton;
            }
            else
            {
                imageBack = new Bitmap("Resources\\ффф.jpg");
                Color colour = Color.FromArgb(128, 255, 128);
                foreach (Button button in buttons)
                    button.BackColor = colour;                
            }
            BackgroundImage = imageBack;
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        void callStartMenuGame() 
        {
            fStartMenuGame startMenuGame= new fStartMenuGame();
            startMenuGame.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            callStartMenuGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            callStartMenuGame();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            callStartMenuGame();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            callStartMenuGame();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            callStartMenuGame();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            callStartMenuGame();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            callStartMenuGame();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            callStartMenuGame();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            callStartMenuGame();
        }
    }
}
