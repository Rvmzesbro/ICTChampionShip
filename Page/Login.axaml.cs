using System;
using System.ComponentModel;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using ICTChampionShip.Models;

namespace ICTChampionShip.Page;

public partial class Login : UserControl
{
    public Employee EmployeeContext { get; set; }
    public Login()
    {
        InitializeComponent();
        EmployeeContext = new Employee();
    }

    private void Button_Ok(object? sender, RoutedEventArgs e)
    {
        var username = Username.Text;
        var password = Password.Text;
        if (string.IsNullOrWhiteSpace(Username.Text) || string.IsNullOrWhiteSpace(Password.Text) || Remember.IsChecked == false)
        {
            return;
        }
        // else if (Remember.IsChecked == true)
        // {
        //     
        // }
        else
        {
            using (var db = new NewictContext())
            {
                EmployeeContext = db.Employees.FirstOrDefault(p => p.Username == username && p.Password == password);
                if (EmployeeContext != null)
                {
                    App.MainWindow.MyContent.Content = new Main();
                }
                else
                {
                    
                }
            }
        }
    }

    private void Button_Cancel(object? sender, RoutedEventArgs e)
    {
        App.MainWindow.Close();
    }


    private void Password_OnGotFocus(object? sender, GotFocusEventArgs e)
    {
        if (true)
        {
            Password.PasswordChar = '*';
        }
    }

    private void Password_OnLostFocus(object? sender, RoutedEventArgs e)
    {
        Password.PasswordChar = '\0';
    }
}