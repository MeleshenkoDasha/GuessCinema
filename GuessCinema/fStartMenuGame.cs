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
    public partial class fStartMenuGame : Form
    {
        public fStartMenuGame()
        {
            InitializeComponent();
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fStartMenuGame_Load(object sender, EventArgs e)
        {
            Image imageBack = new Bitmap(@"Resources\\1.jpg");
            if (clsManagerForms.modeMusic)
            {
                imageBack = new Bitmap(@"Resources\\фон1.jpg");
                Image imageButton = new Bitmap(@"Resources\\www.GetBg.net_Backgrounds_Blue_background_with_highlights_035592_.jpg");
                btnStartGame.Image = imageButton;
                btnSettings.Image = imageButton;
            }
            else
            {
                imageBack = new Bitmap("Resources\\видд.jpg");
                btnStartGame.BackColor = Color.FromArgb(128, 255, 128);
                btnSettings.BackColor = Color.FromArgb(128, 255, 128);
            }
            BackgroundImage = imageBack;
        }

        private void fStartMenuGame_Activated(object sender, EventArgs e)
        {
          //  clsManagerForms.cancelSelectcontents();
          //  clsManagerForms.cancelSelectCountGamers();
        }
    }
}
