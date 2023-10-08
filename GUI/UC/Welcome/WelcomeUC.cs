using System;
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
    public partial class WelcomeUC : UserControl
    {
        public WelcomeUC()
        {
            InitializeComponent();
        }

        private void Company_Doc_Btn_Click(object sender, EventArgs e)
        {
            var frm = Application.OpenForms.Cast<MainMenuForm>().Where(x => x.Name == "MainMenuForm").FirstOrDefault();
            frm.SelectedUC(frm.patientUC1);
        }

        private void A2PictureboxPro3_Click(object sender, EventArgs e)
        {
            var frm = Application.OpenForms.Cast<MainMenuForm>().Where(x => x.Name == "MainMenuForm").FirstOrDefault();
            frm.SelectedUC(frm.supplierUC1);

        }

        private void Accounting_Doc_Btn_Click(object sender, EventArgs e)
        {
            var frm = Application.OpenForms.Cast<MainMenuForm>().Where(x => x.Name == "MainMenuForm").FirstOrDefault();
            frm.SelectedUC(frm.doctorUC1);

        }

        private void Reports_Doc_Btn_Click(object sender, EventArgs e)
        {
            var frm = Application.OpenForms.Cast<MainMenuForm>().Where(x => x.Name == "MainMenuForm").FirstOrDefault();
            frm.SelectedUC(frm.medicationUC1);
        }
    }
}
