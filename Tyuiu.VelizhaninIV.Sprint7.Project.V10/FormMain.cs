
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VelizhaninIV.Sprint7.Project.V10.Lib;
using System.IO;
using System.Diagnostics;

namespace Tyuiu.VelizhaninIV.Sprint7.Project.V10
{
    public partial class FormMain : Form
    {
        private Form activeForm;
        private Button currentButton;

        public FormMain()
        {
            InitializeComponent();
            BtnCloseChildForm_VIV.Visible = false;
            this.Text = string.Empty;
        }

        // Методы
        private void OpenChildForm (Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelMain_VIV.Controls.Add(childForm);
            this.PanelMain_VIV.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LabelTitle_VIV.Text = childForm.Text;
        }

        private void btnAbout_VIV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAbout_VIV(), sender);
            BtnCloseChildForm_VIV.Visible = true;
        }

        private void btnOrders_VIV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOrders_VIV(), sender);
            BtnCloseChildForm_VIV.Visible = true;
        }

        private void BtnCloseChildForm_VIV_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
           
        }

        private void Reset()
        {
            LabelTitle_VIV.Text = "Главная";
            currentButton = null;
            BtnCloseChildForm_VIV.Visible = false;
        }


    }
}
