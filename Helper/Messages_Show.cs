using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Managemnet_System.Helper
{
    public class Messages_Show
    {
        public void SnackbarShow(Bunifu.UI.WinForms.BunifuSnackbar snackbar,Form FormOwner,string message)
        {
            snackbar.Show(FormOwner, message,Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
        }
        public void SnackbarShow(Bunifu.UI.WinForms.BunifuSnackbar snackbar, Form FormOwner, string message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes messageTypes)
        {
            snackbar.Show(FormOwner, message, messageTypes);
        }
        public void SnackbarShow(Bunifu.UI.WinForms.BunifuSnackbar snackbar, Form FormOwner, string message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes messageTypes,int messageDuration)
        {
            snackbar.Show(FormOwner, message, messageTypes, messageDuration*1000);
        }
        public void SnackbarShow(Bunifu.UI.WinForms.BunifuSnackbar snackbar, Form FormOwner, string message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes messageTypes, int messageDuration,string Actionbtntxt)
        {
            snackbar.Show(FormOwner, message, messageTypes, messageDuration*1000, Actionbtntxt);
        }
    }
}
