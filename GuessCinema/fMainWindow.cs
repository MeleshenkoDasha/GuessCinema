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
    public partial class fMainWindow : Form
    {

        /**
         * fMainWindow is the class that describes the main window of the game
         *
         * This class contains event handlers: 
         * Clicking on the buttons that the user sees         
         * Closing the window
         * Calling the help window
         * Muting/muting the game sound
         * Calling additional game menus
         */


        public fMainWindow()
        {
            InitializeComponent();
        }

        // Function that calls the game mode selection form
        void openModelWindow() 
        {
            fMenuGame menuGame = new fMenuGame();
            menuGame.ShowDialog();
        }

        // Handling the button that closes the game form
        private void pctExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Handling a button press, which brings up a form with game rules and gameplay tips
        private void pctHelp_Click(object sender, EventArgs e)
        {
            fRules rules = new fRules();
            rules.ShowDialog();
        }

        // Handling a click on a button that brings up a music game menu form
        private void btnMenuMusic_Click(object sender, EventArgs e)
        {
            clsManagementSelectForms.modeMusic = true;
            openModelWindow();
        }

        // Handling a click on the button that brings up the video game menu form
        private void btnMenuVideo_Click(object sender, EventArgs e)
        {
            clsManagementSelectForms.modeVideo = true;
            openModelWindow();
        }       

        Image pctIsSound = Image.FromFile("Resources\\выкл.png");
        Image pctNoSound = Image.FromFile("Resources\\вкл.png");

        // Handling the form load event
        private void fMainWindow_Load(object sender, EventArgs e)
        {
            clsManagementMusicControlCoreForms.LoadForm();
            pctVolume.Image = pctIsSound;
        }

        // Handling the event of pressing the mute button
        private void pctVolume_Click(object sender, EventArgs e)
        {
            if (clsManagementMusicControlCoreForms.mainWindow.wmpMain.settings.volume == 0)
                pctVolume.Image = pctIsSound;
            else 
                pctVolume.Image = pctNoSound;
            clsManagementMusicControlCoreForms.btnClickSound();

        }
    }
}
