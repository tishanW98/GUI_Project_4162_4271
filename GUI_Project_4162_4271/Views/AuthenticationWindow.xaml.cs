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

namespace GUI_Project_4162_4271.Views
{
    /// <summary>
    /// Interaction logic for AuthenticationWindow.xaml
    /// </summary>
    public partial class AuthenticationWindow : Window
    {
        public AuthenticationWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NormalUserLogingWindow normalUserLogingWindow = new NormalUserLogingWindow();
            normalUserLogingWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AdminUserLogingWindow adminUserLogingWindow = new AdminUserLogingWindow();
            adminUserLogingWindow.Show();
        }
    }
}
