using System;
using System.ComponentModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace ICTChampionShip.Page;

public partial class Login : UserControl
{
    public Login()
    {
        InitializeComponent();
    }

    private void Button_Ok(object? sender, RoutedEventArgs e)
    {
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
            App.MainWindow.MyContent.Content = new Main();
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