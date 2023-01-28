using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GuessCinema
{
    public partial class fMenuGame : Form
    {
        public fMenuGame()
        {
            InitializeComponent();
        }

        private void fMenuGame_Load(object sender, EventArgs e)
        {
            System.Drawing.Image imageBack = new Bitmap(@"Resources\\1.jpg");
            if (clsManagerForms.modeMusic)
            {
                imageBack = new Bitmap(@"Resources\\фон.jpg");
                System.Drawing.Image imageButton = new Bitmap(@"Resources\\www.GetBg.net_Backgrounds_Blue_background_with_highlights_035592_.jpg");
                btnOnePlayerMusic.BackgroundImage = imageButton;
                btnTwoPlayersMusic.BackgroundImage = imageButton;
                btnThemeMusic.BackgroundImage = imageButton;
            }
            else
            {
                imageBack = new Bitmap("Resources\\в.jpg");
                btnOnePlayerMusic.BackColor = Color.FromArgb(128, 255, 128);
                btnTwoPlayersMusic.BackColor = Color.FromArgb(128, 255, 128);
                btnThemeMusic.BackColor = Color.FromArgb(128, 255, 128);
            }
            BackgroundImage = imageBack;
            
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemeMusic_Click(object sender, EventArgs e)
        {
            fSelectedTheme theme = new fSelectedTheme();
            theme.ShowDialog();
        }

        void callStartMenuGame()
        {
            fStartMenuGame startMenuGame = new fStartMenuGame();
            startMenuGame.ShowDialog();
        }

        private void btnOnePlayerMusic_Click(object sender, EventArgs e)
        {
            callStartMenuGame();
        }

        private void btnTwoPlayersMusic_Click(object sender, EventArgs e)
        {
            callStartMenuGame();
        }
    }
}
