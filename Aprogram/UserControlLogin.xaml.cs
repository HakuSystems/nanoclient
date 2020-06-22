using MaterialDesignThemes.Wpf;
using MySql.Data.MySqlClient;
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
    /// Interaction logic for UserControlLogin.xaml
    /// </summary>
    public partial class UserControlLogin : UserControl
    {
        MySqlConnection connection = new MySqlConnection("Database=nanoclient;Data Source=127.0.0.1;User Id=lyze;Password=Noah@2017");

        public UserControlLogin()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, RoutedEventArgs e)
        {
            if (RememberCheck.IsChecked == true)
            {
                Properties.Settings.Default.Username = usernameinput.Text;
                Properties.Settings.Default.Password = passinput.Password;
                Properties.Settings.Default.Save();
            }
            if (RememberCheck.IsChecked == false)
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
            if (API.Login(usernameinput.Text, passinput.Password))
            {
                notification.IsActive = true;
                string insertQuery = "INSERT INTO logindata(nanoclient_username) VALUES('" + usernameinput.Text + "')";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        InitWindow init = new InitWindow();
                        init.InitializeComponent();
                        init.Show();
                        ((MainWindow)Window.GetWindow(this)).Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ((MainWindow)Window.GetWindow(this)).Close();
                connection.Close();
            }
            else
            {
                notification.IsActive = true;
                notification.Message.Content = "Failed to Login.";
                notification.Message.ActionContent = "Ok";
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.Username != string.Empty)
            {
                usernameinput.Text = Properties.Settings.Default.Username;
                passinput.Password = Properties.Settings.Default.Password;
            }
        }

        private void SnackbarMessage_ActionClick(object sender, RoutedEventArgs e)
        {
            notification.IsActive = false;
        }
    }
}
