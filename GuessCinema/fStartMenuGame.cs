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

        }
    }
}