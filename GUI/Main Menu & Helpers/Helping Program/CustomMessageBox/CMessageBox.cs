﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Managemnet_System.GUI.Main_Menu___Helpers.Helping_Program
{
    public partial class CMessageBox : Form
    {
        public CMessageBox()
        {
            // This call is required by the designer.
            InitializeComponent();
            BackColor = Properties.Settings.Default.BG_Color;
            // Add any initialization after the InitializeComponent() call.
        }

        private void Yes_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void No_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        public void Change_Btn_Names(Form form, int Int, string messageLbl = "", string A = "نعم", string B = "لا")
        {
            Yes_Btn.Text = A;
            No_Btn.Text = B;
            Message_Lbl.Text = messageLbl;
            new WaitLoaderForm(form, this, Int);
        }

        private void A2CloseButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

    }
}
