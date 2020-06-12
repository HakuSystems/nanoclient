using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Aprogram
{
    /// <summary>
    /// Interaction logic for UserControlAccount.xaml
    /// </summary>
    public partial class UserControlAccount : UserControl
    {
        public UserControlAccount()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            accountdata.Text = $" Username: {User.Username} \n Email: {User.Email} \n HWID: {User.HWID} \n IP: {User.IP} \n RegisterDate: {User.RegisterDate}";
            notification.Message.Content = $"Expiry: {User.Expiry}";
        }

        private void SnackbarMessage_ActionClick(object sender, RoutedEventArgs e)
        {
            notification.IsActive = false;
        }
    }
}
