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
    public partial class fMainWindow : Form
    {

        /**
         * fMainWindow - класс, в котором описано главное окно игры
         *
         * В данном классе содержится обработчики событий: 
         * нажатия на кнопки, которые видит пользователь         
         *  Закрытие окна
         *  Вызов онка помощи
         *  Отключения/включения звука игры
         *  Вызовы дополнительных игровых меню
         */
        public fMainWindow()
        {
            InitializeComponent();
        }

        // Обработка нажатия кнопки, реализующей закрытие формы игры
        private void pctExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
