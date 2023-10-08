using Pharmacy_Managemnet_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Managemnet_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Branch branch= new Branch();
            branch.Name = "Ahmed";
            branch.Address = "Belqas";
            branch.Phone = "01020485785";
            branch.IsDeleted = false;
            bunifuTextBox1.Text=branch.Name;
            BranchRepo branchRepo = new BranchRepo();
            branchRepo.Add(branch);
        }
    }
}
