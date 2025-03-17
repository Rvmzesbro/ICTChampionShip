using Avalonia.Controls;
using ICTChampionShip.Page;

namespace ICTChampionShip;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MyContent.Content = new Login();
        App.MainWindow = this;
    }
}