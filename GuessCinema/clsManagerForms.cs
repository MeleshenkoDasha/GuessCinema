using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessCinema
{
    public static class clsManagerForms
    {
        // check select game mode

        public static bool modeMusic = false;
        public static bool modeVideo = false;

        // check select count gamers

        public static bool modePvE = false; //  person vs ethernet
        public static bool modePvP = false; // person vs person

        // check select contents
        public static bool modeOurFiles = false; //  person vs ethernet
        public static bool modeYourFiles = false; // person vs person

        // cancel select game mode
        public static void cancelSelectModeGame() 
        {
            modeMusic = false;
            modeVideo = false;
        }

        // cancel select count gamers
        public static void cancelSelectCountGamers()
        {
            modePvE = false;
            modePvP = false;
        }

        // cancel select contents
        public static void cancelSelectcontents()
        {
            modeOurFiles = false; 
            modeYourFiles = false; 
        }
    }
}
