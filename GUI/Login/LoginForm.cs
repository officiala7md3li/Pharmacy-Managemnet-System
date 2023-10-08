using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy_Managemnet_System.Model;
using Pharmacy_Managemnet_System.Helper;
using Pharmacy_Managemnet_System.GUI.Main_Menu___Helpers.Helping_Program;

namespace Pharmacy_Managemnet_System.GUI.Login
{
    public partial class LoginForm : Form
    {
        Messages_Show Messages = new Messages_Show();


        public LoginForm()
        {
            InitializeComponent();
            Banner_Image.BackColor = this.BackColor;
        }



        private void Login_Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username_TxtBox.Text) || string.IsNullOrWhiteSpace(Username_TxtBox.Text))
            {
                Username_TxtBox.Focus();
                Username_TxtBox.Select();
                Messages.SnackbarShow(Snackbar,this, "يرجي ادخال اسم المستخدم", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }

            if (string.IsNullOrEmpty(Pass_txt.Text) || string.IsNullOrWhiteSpace(Pass_txt.Text))
            {
                Pass_txt.Focus();
                Pass_txt.Select();
                Messages.SnackbarShow(Snackbar,this, "يرجي ادخال كلمة المرور", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }
            try
            {
                UserRepo user = new UserRepo();
                User TrueUser = user.ValidateUser(Username_TxtBox.Text, Pass_txt.Text);
            }
            catch (Exception ex)
            {
                // Handle the exception
                if (ex.Message == "No Record in Database")
                {
                    // Handle the case where there are no records in the database
                    BunifuPages2.SetPage("Add User");
                    Banner_Image.Image = Insta_Icon.InitialImage;
                    Messages.SnackbarShow(Snackbar, this, "لايوجد مستخدمين سيتم تحويلك لاضافه مستخدم جديد",Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                }
                else if (ex.Message == "User Not Found")
                {
                    // Handle the case where the user was not found
                    Messages.SnackbarShow(Snackbar, this, "المستخدم غير موجود");
                }
                else
                {
                    // Handle other exceptions
                    Messages.SnackbarShow(Snackbar, this, "An error occurred: " + ex.Message);
                }
            }

        }


        private void Frgt_Pswrd_Click(object sender, EventArgs e)
        {
            BunifuPages2.SetPage("Password Recovery");
            Banner_Image.Image = Wbsit_Icon.ErrorImage;
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            BunifuPages2.SetPage("Exit Page");
            Banner_Image.Image = Insta_Icon.ErrorImage;
        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            BunifuPages2.SetPage("Login Page");
            Banner_Image.Image = Wbsit_Icon.InitialImage;
            Restore_Wrd_Txt.Clear();
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Quick_Access_Btn_Click(object sender, EventArgs e)
        {
            BunifuPages2.SetPage("Login Page");
            Banner_Image.Image = Wbsit_Icon.InitialImage;
            Restore_Wrd_Txt.Clear();
        }

        private void Restore_Btn_Click(object sender, EventArgs e)
        {
            BunifuPages2.SetPage("Password Recovered");
            Restore_Wrd_Txt.Clear();

        }

        private void Pass_txt_OnIconLeftClick(object sender, EventArgs e)
        {
            if ((Pass_txt.IconLeft).Equals(Fb_Icon.InitialImage))
            {
                Pass_txt.IconLeft = Fb_Icon.ErrorImage;
                Pass_txt.UseSystemPasswordChar = false;
            }
            else
            {
                Pass_txt.IconLeft = Fb_Icon.InitialImage;
                Pass_txt.UseSystemPasswordChar = true;
            }

            //Pass_txt.Validate();
            Pass_txt.Refresh();

        }
        private void Password_Eye(ref Guna.UI2.WinForms.Guna2TextBox Textbox_object)
        {
            if ((Textbox_object.IconLeft).Equals(Fb_Icon.InitialImage))
            {
                Textbox_object.IconLeft = Fb_Icon.ErrorImage;
                Textbox_object.UseSystemPasswordChar = true;
            }
            else
            {
                Textbox_object.IconLeft = Fb_Icon.InitialImage;
                Textbox_object.UseSystemPasswordChar = false;                
                Textbox_object.PasswordChar = '\0';
            }
        }

        private void Pass_txt_IconLeftClick(object sender, EventArgs e)
        {
            Password_Eye(ref Pass_txt);
        }

        private void Fb_Icon_Click(object sender, EventArgs e)
        {

        }

        private void Wbsit_Icon_Click(object sender, EventArgs e)
        {
            Messages.SnackbarShow(Snackbar, this, "Ahmed");
        }

        private void Insta_Icon_Click(object sender, EventArgs e)
        {
            Messages.SnackbarShow(Snackbar, this,"Ahmed Ali",Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,5,"ok");
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
            new WaitLoaderForm(this,new CMessageBox(), 10);
        }
    }
}
