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

        /**
         * 
         *  This class contains the implementation of a window that prompts you to select the game mode
         * 
         * **/


        // Handling the form load event
        private void fMenuGame_Load(object sender, EventArgs e)
        {
            // Depending on the selected game in the previous step, choose the layout of the window form
            System.Drawing.Image imageBack = new Bitmap(@"Resources\\1.jpg");
            if (clsManagementSelectForms.modeMusic)
            {
                imageBack = new Bitmap(@"Resources\\фон.jpg");
                System.Drawing.Image imageButton = new Bitmap(@"Resources\\www.GetBg.net_Backgrounds_Blue_background_with_highlights_035592_.jpg");
                btnOnePlayerMusic.BackgroundImage = imageButton;
                btnTwoPlayersMusic.BackgroundImage = imageButton;
                btnSelectTheme.BackgroundImage = imageButton;
            }
            else
            {
                imageBack = new Bitmap("Resources\\в.jpg");
                Color btnColor = Color.FromArgb(128, 255, 128);
                btnOnePlayerMusic.BackColor = btnColor;
                btnTwoPlayersMusic.BackColor = btnColor;
                btnSelectTheme.BackColor = btnColor;
            }
            BackgroundImage = imageBack;
            
        }

        // Handling the form close event
        private void pctExit_Click(object sender, EventArgs e)
        {
            clsManagementSelectForms.cancelSelectModeGame();
            Close();
        }

        // Function to call the form of the start menu of the game
        void callStartMenuGame()
        {
            fStartMenuGame startMenuGame = new fStartMenuGame();
            startMenuGame.ShowDialog();
        }

        // Handling a button press event
        private void btnOnePlayerMusic_Click(object sender, EventArgs e)
        {
            clsManagementSelectForms.modePvE = true;
            callStartMenuGame();
        }

        // Handling a button press event
        private void btnTwoPlayersMusic_Click(object sender, EventArgs e)
        {
            clsManagementSelectForms.modePvP= true;
            callStartMenuGame();
        }

        // Handling a button press event
        private void btnSelectTheme_Click(object sender, EventArgs e)
        {
            clsManagementSelectForms.modePvE = true;
            fSelectedTheme theme = new fSelectedTheme();
            theme.ShowDialog();
        }
    }
}
