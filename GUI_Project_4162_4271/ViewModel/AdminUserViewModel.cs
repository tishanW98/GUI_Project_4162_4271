using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GUI_Project_4162_4271.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using GUI_Project_4162_4271.Context;
using GUI_Project_4162_4271.Views;

namespace GUI_Project_4162_4271.ViewModel
{
    public partial class AdminUserViewModel : ObservableObject
    {
        [ObservableProperty]
        public string adminusername;
        [ObservableProperty]
        public string adminpassword;
        [ObservableProperty]
        public int adminid;
        [ObservableProperty]
        public UserType usertype;
        [ObservableProperty]
        ObservableCollection<AdminUser> admins;


        [ObservableProperty]
        public string normalusername;
        [ObservableProperty]
        public int normaluserpassword;

        [ObservableProperty]
        ObservableCollection<NormalUser> normalusers;





        public string AdminUsername
        {
            get { return adminusername; }
            set { adminusername = value; }
        }
        public string AdminPassword
        {
            get { return adminpassword; }
            set { adminpassword = value; }
        }
        public int AdminId
        {
            get { return adminid; }
            set { adminid = value; }
        }
        public UserType UserType
        {
            get { return usertype; }
            set { usertype = value; }
        }

        public string NormalUsername { get; set; }
        public int NormalUserPassword { get; set; }
        public int NormalUserId { get; set; }






        public void ShowCustomMessageBox(string message)
        {
            var messageBox = new Window()
            {
                WindowStyle = WindowStyle.None,
                ResizeMode = ResizeMode.NoResize,
                Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#545d6a")),
                Foreground = Brushes.White,
                Width = 300,
                Height = 150,
                Topmost = true,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };

            var contentStackPanel = new StackPanel();

            var messageTextBlock = new TextBlock()
            {
                Text = message,
                FontSize = 16,
                Padding = new Thickness(20),
                TextWrapping = TextWrapping.Wrap,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };

            var closeButton = new Button()
            {
                Content = "Close",
                Width = 80,
                Height = 30,
                Margin = new Thickness(10),
                Background = Brushes.LightGray,
                Foreground = Brushes.Black
            };

            closeButton.Click += (sender, e) =>
            {
                messageBox.Close();
            };

            contentStackPanel.Children.Add(messageTextBlock);
            contentStackPanel.Children.Add(closeButton);

            messageBox.Content = contentStackPanel;

            messageBox.Show();
        }




        [RelayCommand]
        public void LoginAdmin()
        {
            using (var dbContext = new AdminUserContext())
            {
                var AdminUser = dbContext.AdminUsers.FirstOrDefault(a => a.AdminUsername == AdminUsername);

                if (AdminUser != null)
                {
                    if (AdminUser.UserType == UserType.Admin)
                        // Verify the password against the stored password

                        if (VerifyPassword(AdminUser.AdminPassword, AdminPassword))
                        {
                            // Password is correct, perform the login action
                            // You can navigate to the appropriate view here

                            AdminWindow adminWindow = new AdminWindow();
                            adminWindow.Show();
                            
                        }
                        else
                        {
                            // Incorrect password, show error message
                            //MessageBox.Show($"Error2");
                            ShowCustomMessageBox("Incorrect password");
                        }

                }
                else
                {
                    // User not found, show error message
                    //MessageBox.Show($"Error1");
                    ShowCustomMessageBox("Error");
                }


            }
        }

        private bool VerifyPassword(int adminPassword1, string adminPassword2)
        {
            throw new NotImplementedException();
        }

        private bool VerifyPassword(string adminPassword1, string adminPassword2)
        {
            throw new NotImplementedException();
        }

        private bool VerifyPassword(int storedPassword, int enteredPassword)
        {

            return storedPassword == enteredPassword;
        }

    }
}