﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.VelizhaninIV.Sprint7.Project.V10.Forms
{
    public partial class FormAbout_VIV : Form
    {
        public FormAbout_VIV()
        {
            InitializeComponent();
        }

        private void BtnAboutCreator_VIV_Click(object sender, EventArgs e)
        {
            FormCreator_VIV info = new FormCreator_VIV();
            info.ShowDialog();
        }
    }
}
