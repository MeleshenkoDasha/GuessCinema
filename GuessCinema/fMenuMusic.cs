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
    public partial class fMenuMusic : Form
    {
        public fMenuMusic()
        {
            InitializeComponent();
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemeMusic_Click(object sender, EventArgs e)
        {
            fMusicTheme musicTheme= new fMusicTheme();
            musicTheme.ShowDialog();
        }
    }
}
