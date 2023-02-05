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
    public partial class fSettings : Form
    {
        public fSettings()
        {
            InitializeComponent();
        }

        private void fSettings_Load(object sender, EventArgs e)
        {           
            if (clsManagementSelectForms.modeMusic)
            {                
                Image imageButton = new Bitmap(@"Resources\\www.GetBg.net_Backgrounds_Blue_background_with_highlights_035592_.jpg");
                gbSettings.BackgroundImage = imageButton;
                btnSelectFolder.BackgroundImage = imageButton; 
                btnCancel.BackgroundImage = imageButton;
                btnClearList.BackgroundImage = imageButton;
                btnOk.BackgroundImage = imageButton;
                pbCapture.Image = new Bitmap(@"Resources\\0_11a2f5_dabe2f00_orig.png");
            }
            else
            {
                Color colour = Color.FromArgb(128, 255, 128);
                gbSettings.BackColor = colour;
                btnSelectFolder.BackColor= colour;
                btnClearList.BackColor = colour;
                btnOk.BackColor = colour;
                btnCancel.BackColor = colour;
                pbCapture.Image = new Bitmap(@"Resources\\camaracine.png");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
