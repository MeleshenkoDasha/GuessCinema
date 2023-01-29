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
    public partial class fPlayGame : Form
    {
        public fPlayGame()
        {
            InitializeComponent();
        }

        private void fPlayGame_Load(object sender, EventArgs e)
        {
            Image imageBack = new Bitmap(@"Resources\\1.jpg");
            if (clsManagerForms.modeMusic)
            {
                imageBack = new Bitmap(@"Resources\\Fotolia_66907464_L.jpg");                
                btnNext.BackColor = Color.FromArgb(108, 84, 248);
                btnPause.BackColor = Color.FromArgb(203, 18, 207);
                btnContinue.BackColor = Color.Red;
                btnEndGame.BackColor = Color.FromArgb(255,128,0);
                lblNameFirstGamer.BackColor = Color.Blue;
                lblCounterFirstGamer.BackColor = Color.Blue;
                lblNameSecondGamer.BackColor = Color.Yellow;
                lblCounterSecondGamer.BackColor = Color.Yellow;
            }
            else
            {
                imageBack = new Bitmap("Resources\\Color-explosion-Presentation-Template-Backgrounds.jpg");
                btnNext.BackColor = Color.FromArgb(192, 192, 255);
                btnPause.BackColor = Color.FromArgb(244, 162, 247);
                btnContinue.BackColor = Color.FromArgb(255, 244, 192);
                btnEndGame.BackColor = Color.FromArgb(192, 255, 192);
                lblNameFirstGamer.BackColor = Color.FromArgb(128, 128, 255);
                lblCounterFirstGamer.BackColor = Color.FromArgb(128, 128, 255);
                lblNameSecondGamer.BackColor = Color.FromArgb(0, 192, 0);
                lblCounterSecondGamer.BackColor = Color.FromArgb(0, 192, 0);
            }
            BackgroundImage = imageBack;
            WMP.Visible = false;
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            fEndGame endgame = new fEndGame();
            endgame.ShowDialog();
        }

        private void pctStartGame_Click(object sender, EventArgs e)
        {
            pctStartGame.Visible = false;
            tableLayoutPanel1.SetColumnSpan(pctStartGame, 1);
            tableLayoutPanel1.SetCellPosition(pctStartGame, new TableLayoutPanelCellPosition(0, 0));
            pctStartGame.Enabled = false;
            if (clsManagerForms.modeVideo)
            {
                WMP.Visible = true;
                WMP.uiMode = "none";
                tableLayoutPanel1.SetColumnSpan(WMP, 9);

            }
        }
    }
}
