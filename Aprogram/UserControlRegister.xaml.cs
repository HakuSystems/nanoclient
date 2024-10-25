﻿using MySql.Data.MySqlClient;
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
    /// Interaction logic for UserControlRegister.xaml
    /// </summary>
    public partial class UserControlRegister : UserControl
    {
        MySqlConnection connection = new MySqlConnection("Database=nanoclient;Data Source=127.0.0.1;User Id=lyze;Password=Noah@2017");

        public UserControlRegister()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, RoutedEventArgs e)
        {
            if (API.Register(userinput.Text, passinput.Password, emailinput.Text, licenseinput.Text))
            {
                notification.IsActive = true;
                notification.Message.Content = "Register has been successful.";
                notification.Message.ActionContent = "Login";

            }
            else
            {
                notification.IsActive = true;
                notification.Message.Content = "Register Failed.";
                notification.Message.ActionContent = "Ok";
            }
        }

        private void SnackbarMessage_ActionClick(object sender, RoutedEventArgs e)
        {
            if (notification.Message.ActionContent.ToString().Equals("Login"))
            {
                if (API.Login(userinput.Text, passinput.Password))
                {
                    notification.IsActive = true;
                    notification.Message.Content = "Please Wait..";

                    string insertQuery = "INSERT INTO registerdata(nanoclient_username,nanoclient_email,nanoclient_licenseKey) VALUES('" + userinput.Text + "','" + emailinput.Text + "','" + licenseinput.Text + "')";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                    try
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            InitWindow init = new InitWindow();
                            init.InitializeComponent();
                            init.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    ((MainWindow)Window.GetWindow(this)).Close();
                }
            }
            else
            {
                notification.IsActive = false;
            }
        }
    }
}
