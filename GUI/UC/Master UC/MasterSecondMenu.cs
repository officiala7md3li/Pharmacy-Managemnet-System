﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Managemnet_System.GUI.UC
{
    public partial class MasterSecondMenu : UserControl
    {
        public MasterSecondMenu()
        {
            InitializeComponent();
        }
        private void Back_Button_Click(object sender, EventArgs e)
        {
            Visible = false;
            Enabled = false;
            var mainMenuForm = Application.OpenForms.Cast<MainMenuForm>().Where(x => x.Name == "MainMenuForm").FirstOrDefault();

            mainMenuForm.SelectedUC(mainMenuForm.welcomeUC1);
            if (!mainMenuForm.SidePanel.Visible)
            {
                mainMenuForm.SidePanel.Show();
            }
            mainMenuForm.SidePanel.Top = mainMenuForm.Main_Menu_Home_Btn.Top;
            mainMenuForm.A2SGradSlider1.Refresh();
            mainMenuForm.A2SGradSlider1.Invalidate();
        }

        private bool masterUCLockValue = false;
        public bool Master_UC_Lock
        {
            get { return masterUCLockValue; }
            set
            {
                masterUCLockValue = value;
                DisableLockBtn.Visible = value;
                Invalidate();
            }
        }

    }
}
