using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessCinema
{
    public static class clsManagementMusicControlCoreForms
    {
        /**
         * 
         * This class, implements music control of the core forms
         * 
         * **/

        public static fMainWindow mainWindow = new fMainWindow();

        public static void LoadForm() 
        {
            mainWindow.wmpMain.URL = "Resources\\фон заставка.mp3";
            mainWindow.wmpMain.Ctlcontrols.play();
        }

        public static void btnClickSound() 
        {
            if (mainWindow.wmpMain.settings.volume == 0) mainWindow.wmpMain.settings.volume = 100;
            else mainWindow.wmpMain.settings.volume = 0;
        }

    }
}
