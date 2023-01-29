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
    public partial class fAnswerForm : Form
    {
        public fAnswerForm()
        {
            InitializeComponent();
        }

        private void fAnswerForm_Load(object sender, EventArgs e)
        {            
            if (clsManagerForms.modeMusic)
            {                
                Image imageButton = new Bitmap(@"Resources\\www.GetBg.net_Backgrounds_Blue_background_with_highlights_035592_.jpg");
                btnOk.Image = imageButton;
                btnCancel.Image = imageButton;
            }
            else
            {
                btnOk.BackColor = Color.FromArgb(128, 255, 128);
                btnCancel.BackColor = Color.FromArgb(128, 255, 128);
            }
        }
    }
}
