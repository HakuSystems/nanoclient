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
using System.Windows.Shapes;

namespace Aprogram
{
    /// <summary>
    /// Interaction logic for InitWindow.xaml
    /// </summary>
    public partial class InitWindow : Window
    {
        public InitWindow()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void minibtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Accbtn_Click(object sender, RoutedEventArgs e)
        {
            Accbtn.IsEnabled = false;
            Accicon.Foreground = new SolidColorBrush(Colors.DarkGray);

            adobebtn.IsEnabled = true;
            adobeicon.Foreground = new SolidColorBrush(Colors.White);
            

            UserControlAccount main = new UserControlAccount();
            Usercontrol.Children.Add(main);
        }

        private void adobebtn_Click(object sender, RoutedEventArgs e)
        {

            Accbtn.IsEnabled = true;
            Accicon.Foreground = new SolidColorBrush(Colors.White);

            adobebtn.IsEnabled = false;
            adobeicon.Foreground = new SolidColorBrush(Colors.DarkGray);

            UserControlAdobe main = new UserControlAdobe();
            Usercontrol.Children.Add(main);
        }
    }
}
