using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessCinema
{
    public static class clsManagementSelectForms
    {

        /**
         * This class implements a system of flags to display forms based on the choices the gamer makes
         **/


        // Flag to check if the game is music or movie
        public static bool modeMusic = false;
        public static bool modeVideo = false;


        // Flag to check the number of players
        public static bool modePvE = false; // mode person vs ethernet
        public static bool modePvP = false; // mode person vs person


        // Flag to check content selection
        public static bool modeOurFiles = false; // gamers load their contents
        public static bool modeYourFiles = false; // gamers load our contents


        // Clearing game selection flags
        public static void cancelSelectModeGame() 
        {
            modeMusic = false;
            modeVideo = false;
        }

        // Clearing the flags for selecting the number of players
        public static void cancelSelectCountGamers()
        {
            modePvE = false;
            modePvP = false;
        }

        // Clearing the content selection flags
        public static void cancelSelectContents()
        {
            modeOurFiles = false; 
            modeYourFiles = false; 
        }
    }
}
