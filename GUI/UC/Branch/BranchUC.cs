using Pharmacy_Managemnet_System.Model;
using System;
using System.Activities.Presentation.PropertyEditing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pharmacy_Managemnet_System.GUI.UC.Branch
{
    public partial class BranchUC : Master_UC.MasterUC
    {
        public BranchUC()
        {
            InitializeComponent();
        }

        public override void NewData()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 8; i++)
            {
                list.Add(i.ToString());
            }

            List<HelpingSearchForm> dataSource = new List<HelpingSearchForm>();
            for (int i = 0; i < DisplayAvailableProperties<Model.Branch>().Count; i++)
            {
                dataSource.Add(new HelpingSearchForm { Display = list[i], Value = DisplayAvailableProperties<Model.Branch>()[i] });
            }

            // Set ComboBox's data source
            Search_CmboBox.DataSource = dataSource;

            // Set ValueMember and DisplayMember
            Search_CmboBox.DisplayMember = "Display"; // DisplayMember is the "Display" property
            Search_CmboBox.ValueMember ="Value" ;

            base.NewData();
        }
        public List<string>  DisplayAvailableProperties<T>()
        {
            List<string> result = new List<string>();
            PropertyInfo[] properties = typeof(T).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                result.Add(property.Name);
            }
            return result;
        }
        public override void SaveData()
        {
            Model.Branch branch = new Model.Branch();
            branch.Name=Branch_Name_TxtBox.Text;
            branch.Phone = Branch_Phone_TxtBox.Text;
            branch.Address=Branch_Address_TxtBox.Text;
            BranchRepo branchRepo = new BranchRepo();
            branchRepo.Add(branch);
            base.SaveData();
        }
        public override void EditData()
        {
            base.EditData();
        }
        public override void Search_Data()
        {
            BranchRepo  branchRepo=new BranchRepo();
            List<Model.Branch> branch=new List<Model.Branch>();
            branch = branchRepo.GetAll();
            string Prop = Search_CmboBox.SelectedValue.ToString();
            List<Model.Branch> branches= GetRecordByProperty<Model.Branch>(branch,Prop,Branch_Name_TxtBox.Text);
            guna2ComboBox1.Items.Clear();
            foreach (var item in branch)
            {
                guna2ComboBox1.Items.Add( item.Name.ToString());//Branch_Phone_TxtBox.Text +=

            }
            base.Search_Data();
        }
        public List<T> SearchByProperty<T>(List<T> sourceList, string searchProperty, string searchValue)
        {
            PropertyInfo propertyInfo = typeof(T).GetProperty(searchProperty, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);

            if (propertyInfo == null)
            {
                Console.WriteLine($"Property '{searchProperty}' not found.");
                return new List<T>();
            }

            return sourceList.Where(x => propertyInfo.GetValue(x)?.ToString()?.Contains(searchValue) == true).ToList();
        }
        public  List<T> GetRecordByProperty<T>(List<T> sourceList, string propertyName, string searchValue)
        {
            PropertyInfo propertyInfo = typeof(T).GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);

            if (propertyInfo == null)
            {
                throw new ArgumentException($"Property '{propertyName}' not found in type '{typeof(T).Name}'.");
            }

            // return sourceList.FirstOrDefault(item => propertyInfo.GetValue(item)?.ToString() == searchValue);

            return sourceList.Where(item =>(propertyInfo.GetValue(item)?.ToString()).Contains(searchValue) == true).ToList();

        }

    }
}
