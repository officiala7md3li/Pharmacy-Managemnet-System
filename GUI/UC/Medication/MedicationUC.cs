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
    public partial class MedicationUC : Master_UC.MasterUC
    {
        public MedicationUC()
        {
            InitializeComponent();
        }

        private void Browse_Btn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Image_Capture = this.Username_Pic;
            var mainMenuForm = Application.OpenForms.Cast<MainMenuForm>().Where(x => x.Name == "MainMenuForm").FirstOrDefault();
                mainMenuForm.Showing_Page_On_Screen(false, true, "Camera_Shot");
                mainMenuForm.Refresh();

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Discount_Txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
