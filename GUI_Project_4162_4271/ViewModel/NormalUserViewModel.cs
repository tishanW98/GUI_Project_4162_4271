using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GUI_Project_4162_4271.Context;
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
using GUI_Project_4162_4271.Views;

namespace GUI_Project_4162_4271.ViewModel
{
    public partial class NormalUserViewModel : ObservableObject
    {
        [ObservableProperty]
        public string name;
        [ObservableProperty]
        public string description;
        [ObservableProperty]
        public int unit;
        [ObservableProperty]
        public int id;
        [ObservableProperty]
        public double price;

        [ObservableProperty]
        public string normalusername;
        [ObservableProperty]
        public int normaluserpassword;
        [ObservableProperty]
        public int normaluserid;
        public UserType usertype;
        [ObservableProperty]


        ObservableCollection<NormalUser> normalusers;


        public string NormalUsername { get; set; }
        public int NormalUserPassword { get; set; }
        public UserType Usertype { get; set; }
        // public int NormalUserId { get; set; }
        /*
        public string NormalUsername
        {
            get { return normalusername; }
            set { normalusername = value; }
        }
        public int NormalUserPassword
        {
            get { return normaluserpassword; }
            set { normaluserpassword = value; }
        }
        public int NormalUserId
        {
            get { return normaluserid; }
            set { normaluserid = value; }
        }
        public UserType UserType
        {
            get { return usertype; }
            set { usertype = value; }
        }

        */
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
        public void InsertNormalUser()
        {
            NormalUser n = new NormalUser()
            {
                NormalUsername = NormalUsername,
                NormalUserPassword = NormalUserPassword,
                //UserType = UserType
            };
            using (var db = new NormalUserContext())
            {
                db.NormalUsers.Add(n);
                db.SaveChanges();
                //MessageBox.Show($"Added");
                ShowCustomMessageBox("User name and Password added to the database successfully!");
            }

        }

        [RelayCommand]
        public void LoginNormal()
        {
            using (var dbContext = new NormalUserContext())
            {
                var n = dbContext.NormalUsers.FirstOrDefault(a => a.NormalUsername == NormalUsername);

                if (n != null)
                {

                    // Verify the password against the stored password

                    if (VerifyPassword(n.NormalUserPassword, NormalUserPassword))
                    {
                        // Password is correct, perform the login action
                        // You can navigate to the appropriate view here

                        UserWindow userWindow = new UserWindow();
                        userWindow.Show();
                        

                    }
                    else
                    {
                        // Incorrect password, show error message
                        // MessageBox.Show($"Error2");
                        ShowCustomMessageBox("Incorrect Password!");
                    }

                }

                else
                {
                    // User not found, show error message
                    // MessageBox.Show($"Error1");
                    ShowCustomMessageBox("Error");
                }


            }
        }

        

        private bool VerifyPassword(int storedPassword, int enteredPassword)
        {

            return storedPassword == enteredPassword;
        }




        [ObservableProperty]
        ObservableCollection<User> users;
        

        public User? SelectedUser { get; set; }
        

        [RelayCommand]
        public void InsertUser()
        {
            User p = new User()
            {
                Id = Id,
                Name = Name,
                Description = Description,
                Unit = Unit,
                Price = Price
            };
            using (var db = new UserContext())
            {
                db.Users.Add(p);
                db.SaveChanges();
            }
            LoadUser();

            // Clear the properties
            Id = 0;
            Name = string.Empty;
            Description = string.Empty;
            Price = 0;

            ShowCustomMessageBox("Item added successfully!");


        }


        [RelayCommand]
        public void DeleteUser()
        {
            if (SelectedUser != null)
            {
                using (var db = new UserContext())
                {
                    db.Users.Remove(SelectedUser);
                    db.SaveChanges();
                }
                LoadUser();
            }
            else
            {
                // MessageBox.Show("Please select a person to delete.", "Delete Person", MessageBoxButton.OK, MessageBoxImage.Warning);
                ShowCustomMessageBox("Please select a item to delete");
            }
        }


        
        
        [RelayCommand]
        public void EditUser()
        {
            if (SelectedUser == null)
            {
                MessageBox.Show("Please select a item to update.");
                return;
            }
            using (var db = new UserContext())
            {

                

                if (SelectedUser != null)
                {
                    InsertUser();

                    SelectedUser.Name = Name;  
                    Description= SelectedUser.Description;
                    Id = SelectedUser.Id;
                    Unit = SelectedUser.Unit;
                    Price = SelectedUser.Price;
                        



                    db.Users.Add(SelectedUser);

                    db.SaveChanges();
                   
                    Name = "";
                    Description = "";
                    Id= 0;
                    Unit = 0;
                    Price= 0;



                    LoadUser();
                }
                else
                {
                    MessageBox.Show("Selected user not found in database.");
                }
            }
        }

        


        public User GetUserById(int id)
        {
            using (var db = new UserContext())
            {
                return db.Users.FirstOrDefault(p => p.Id == id);
            }
        }
        [RelayCommand]
        private void ReadUsers()
        {
            if (id == 0)
            {
                //MessageBox.Show("Please enter a valid ID.");
                ShowCustomMessageBox("Please enter a valid ID");
                return;
            }

            User user = GetUserById(id);

            if (user != null)
            {
                MessageBox.Show($"Id: {user.Id}\nUser_Name: {user.Name}");
            }
            else
            {
                
                ShowCustomMessageBox("Item not found");
            }
        }




        public void LoadUser()
        {
            using (var db = new UserContext())
            {
                var list = db.Users.ToList();
                Users = new ObservableCollection<User>(list);
            }
        }
        public NormalUserViewModel()
        {
            LoadUser();
        }
    }



}

