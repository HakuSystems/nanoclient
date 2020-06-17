using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
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
    /// Interaction logic for UserControlAdobe.xaml
    /// </summary>
    public partial class UserControlAdobe : UserControl
    {
        public UserControlAdobe()
        {
            InitializeComponent();
            API.Log(User.Username, "Opened Adobe Window");
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (File.Exists("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Creative Cloud.exe"))
            {
                API.Log(User.Username, "Checking if Creative Could Exists");
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("It seems u dont have the Creative Cloud Installed. Do you want to install it?", "Creative Cloud Installer", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    notification.IsActive = true;
                    using (WebClient webClient = new WebClient())
                    {
                        API.Log(User.Username, "Downloading Creative Cloud");
                        webClient.DownloadFile("https://notlyze.de/hBnSJPyWCOActKmENpwA/Set-up.exe", "Set-up.exe");
                        System.Diagnostics.Process.Start("Set-up.exe");
                        notification.Message.Content = "Please install Creative Cloud.";
                    }
                }
            }

            ProgramBox.Items.Add(new KeyValuePair<string, string>("AfterEffects", "1"));
            ProgramBox.Items.Add(new KeyValuePair<string, string>("Photoshop", "2"));
            ProgramBox.Items.Add(new KeyValuePair<string, string>("PremierePro", "3"));
            ProgramBox.Items.Add(new KeyValuePair<string, string>("MediaEncoder", "4"));

            ProgramBox.DisplayMemberPath = "Key";
            ProgramBox.SelectedValue = "value";
        }
        private void ProgramBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            patchbtn.IsEnabled = true;
            notification.IsActive = true;
            notification.Message.Content = "Click Patch!";
            API.Log(User.Username, "Showing Patch Button");
        }

        private void SnackbarMessage_ActionClick(object sender, RoutedEventArgs e)
        {
            notification.IsActive = false;
        }

        private void patchbtn_Click(object sender, RoutedEventArgs e)
        {
            API.Log(User.Username, "Patching Adobe Files");
            notification.IsActive = true;
            notification.Message.Content = "Waiting for file..";
            if (ProgramBox.SelectedValue.ToString().Contains("PremierePro"))
            {

                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                dlg.FileName = "Registration";
                dlg.DefaultExt = ".dll";
                dlg.Filter = "dll (*.dll) | *.dll";
                Nullable<bool> result = dlg.ShowDialog();
                if (result.Value.Equals(true))
                {
                    dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    WebClient webClient = new WebClient();
                    notification.IsActive = true;
                    notification.Message.Content = "Please Wait..";
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                    webClient.DownloadFileAsync(new Uri("https://notlyze.de/hBnSJPyWCOActKmENpwA/Registration.dll"),
                        dlg.FileName);
                    string filename = dlg.FileName;
                    notification.IsActive = true;
                    notification.Message.Content = "Patching File, Please Wait";
                    ((InitWindow)Window.GetWindow(this)).maingrid.IsEnabled = false;
                    ((InitWindow)Window.GetWindow(this)).closebtn.IsEnabled = false;
                }
                else
                {
                    API.Log(User.Username, "Caneled Patching");

                    notification.IsActive = true;
                    notification.Message.Content = "Canceled";
                }
            }
            if (ProgramBox.SelectedValue.ToString().Contains("MediaEncoder"))
            {
                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                dlg.FileName = "Adobe Media Encoder";
                dlg.DefaultExt = ".exe";
                dlg.Filter = "exe (*.exe) | *.exe";
                Nullable<bool> result = dlg.ShowDialog();
                if (result.Value.Equals(true))
                {
                    dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    WebClient webClient = new WebClient();
                    notification.IsActive = true;
                    notification.Message.Content = "Please Wait..";
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                    webClient.DownloadFileAsync(new Uri("https://notlyze.de/hBnSJPyWCOActKmENpwA/Adobe%20Media%20Encoder.exe"),
                        dlg.FileName);
                    string filename = dlg.FileName;
                    notification.IsActive = true;
                    notification.Message.Content = "Patching File, Please Wait";
                    ((InitWindow)Window.GetWindow(this)).maingrid.IsEnabled = false;
                    ((InitWindow)Window.GetWindow(this)).closebtn.IsEnabled = false;
                }
                else
                {
                    API.Log(User.Username, "Caneled Patching");
                    notification.IsActive = true;
                    notification.Message.Content = "Canceled";
                }
            }
            if (ProgramBox.SelectedValue.ToString().Contains("Photoshop"))
            {
                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                dlg.FileName = "Photoshop";
                dlg.DefaultExt = ".exe";
                dlg.Filter = "exe (*.exe) | *.exe";
                Nullable<bool> result = dlg.ShowDialog();
                if (result.Value.Equals(true))
                {
                    dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    WebClient webClient = new WebClient();
                    notification.IsActive = true;
                    notification.Message.Content = "Please Wait..";
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                    webClient.DownloadFileAsync(new Uri("https://notlyze.de/hBnSJPyWCOActKmENpwA/Photoshop.exe"),
                        dlg.FileName);
                    string filename = dlg.FileName;
                    notification.IsActive = true;
                    notification.Message.Content = "Patching File, Please Wait";
                    ((InitWindow)Window.GetWindow(this)).maingrid.IsEnabled = false;
                    ((InitWindow)Window.GetWindow(this)).closebtn.IsEnabled = false;
                }
                else
                {
                    API.Log(User.Username, "Caneled Patching");
                    notification.IsActive = true;
                    notification.Message.Content = "Canceled";
                }
            }
            if (ProgramBox.SelectedValue.ToString().Contains("AfterEffects"))
            {
                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                dlg.FileName = "AfterFXLib";
                dlg.DefaultExt = ".dll";
                dlg.Filter = "dll (*.dll) | *.dll";
                Nullable<bool> result = dlg.ShowDialog();
                if (result.Value.Equals(true))
                {
                    dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    WebClient webClient = new WebClient();
                    notification.IsActive = true;
                    notification.Message.Content = "Please Wait..";
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                    webClient.DownloadFileAsync(new Uri("https://notlyze.de/hBnSJPyWCOActKmENpwA/AfterFXLib.dll"),
                        dlg.FileName);
                    string filename = dlg.FileName;
                    notification.IsActive = true;
                    notification.Message.Content = "Patching File, Please Wait";
                    ((InitWindow)Window.GetWindow(this)).maingrid.IsEnabled = false;
                    ((InitWindow)Window.GetWindow(this)).closebtn.IsEnabled = false;
                }
                else
                {
                    API.Log(User.Username, "Caneled Patching");
                    notification.IsActive = true;
                    notification.Message.Content = "Canceled";
                    ((InitWindow)Window.GetWindow(this)).maingrid.IsEnabled = true;
                    ((InitWindow)Window.GetWindow(this)).closebtn.IsEnabled = true;
                }
            }
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            API.Log(User.Username, "Completed Patching Adobe Files");
            notification.IsActive = true;
            notification.Message.Content = "Completed.";
            System.Windows.MessageBox.Show("Completed and Patched!");

            ((InitWindow)Window.GetWindow(this)).maingrid.IsEnabled = true;
            ((InitWindow)Window.GetWindow(this)).closebtn.IsEnabled = true;
        }
    }
}
