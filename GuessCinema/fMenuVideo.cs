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
    public partial class fMenuVideo : Form
    {
        public fMenuVideo()
        {
            InitializeComponent();
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemeVideo_Click(object sender, EventArgs e)
        {
            fVideoTheme videoTheme  = new fVideoTheme();
            videoTheme.ShowDialog();
        }
    }
}
