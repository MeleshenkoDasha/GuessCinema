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
    public partial class fEndGame : Form
    {
        public fEndGame()
        {
            InitializeComponent();
        }

        private void fEndGame_Load(object sender, EventArgs e)
        {
            Image image;
            if (clsManagerForms.modeMusic)
            {
                image = new Bitmap(@"Resources\\nota15.png");
                btnExit.BackgroundImage = new Bitmap(@"Resources\\www.GetBg.net_Backgrounds_Blue_background_with_highlights_035592_.jpg");
            }
            else 
            {
                image = new Bitmap(@"Resources\\575fa66c789961554da217ce.png");
                btnExit.BackColor = Color.FromArgb(128, 255, 128);
            }
            pctShow.Image = image;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
