using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Hosting;
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
        MySqlConnection connection = new MySqlConnection("Database=nanoclient;Data Source=127.0.0.1;User Id=lyze;Password=Noah@2017");

        public UserControlAccount()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            string insertQuery = "INSERT INTO accountdata(nanoclient_username,nanoclient_email,nanoclient_hwid,nanoclient_ip,nanoclient_id) VALUES('" + User.Username + "','" + User.Email + "','" + User.HWID + "','" + User.IP + "','" + User.ID + "')";
            
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    accountdata.Text = $" Username: {User.Username} \n Email: {User.Email} \n HWID: {User.HWID} \n IP: {User.IP} \n RegisterDate: {User.RegisterDate}";
                    notification.Message.Content = $"Expiry: {User.Expiry}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void SnackbarMessage_ActionClick(object sender, RoutedEventArgs e)
        {
            notification.IsActive = false;
        }
    }
}
