﻿using System;
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

        void openModelWindow() 
        {
            fMenuGame menuGame = new fMenuGame();
            menuGame.ShowDialog();
        }

        // Обработка нажатия кнопки, реализующей закрытие формы игры
        private void pctExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Обработка нажатия кнопки, реализующей вызов формы с помощью
        private void pctHelp_Click(object sender, EventArgs e)
        {
            // создание экземпляра класса 
            fRules rules = new fRules();
            // его вызов
            rules.ShowDialog();
        }

        // Обработка нажатия кнопки, реализующей вызов формы меню музыкальной игры
        private void btnMenuMusic_Click(object sender, EventArgs e)
        {
            clsManagerForms.modeMusic = true;
            openModelWindow();
        }

        // Обработка нажатия кнопки, реализующей вызов формы меню видео игры
        private void btnMenuVideo_Click(object sender, EventArgs e)
        {
            clsManagerForms.modeVideo = true;
            openModelWindow();
        }

        private void fMainWindow_Activated(object sender, EventArgs e)
        {
            clsManagerForms.cancelSelectModeGame();
        }
    }
}
