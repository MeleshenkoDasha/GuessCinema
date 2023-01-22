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
    public partial class fRules : Form
    {
        public fRules()
        {
            InitializeComponent();
        }

        /**
         * 
         * fRules - класс реализующий окно, с правилами игры
         * Класс содержит единственный обработчик событий - закрытие окна 
         * 
         * **/

        private void pctExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
