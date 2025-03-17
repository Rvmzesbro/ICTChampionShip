using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace ICTChampionShip.Page;

public partial class EmployeeFinder : UserControl
{
    public EmployeeFinder()
    {
        InitializeComponent();
    }

    private void InputElement_OnGotFocus(object? sender, GotFocusEventArgs e)
    {
        if (Search.Text == "search employee")
        {
            Search.Text = "";
        }
    }

    private void InputElement_OnLostFocus(object? sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(Search.Text))
        {
            Search.Text = "search employee";
        }
    }
}