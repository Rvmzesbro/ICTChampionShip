using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace ICTChampionShip.Page;

public partial class Main : UserControl
{
    public Main()
    {
        InitializeComponent();
    }

    private void Button_CloseApplication(object? sender, RoutedEventArgs e)
    {
        App.MainWindow.Close();
    }

    private void Button_EmployeeFinder(object? sender, RoutedEventArgs e)
    {
        App.MainWindow.MyContent.Content = new EmployeeFinder();
    }
}