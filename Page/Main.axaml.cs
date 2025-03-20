using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using ICTChampionShip.Models;
namespace ICTChampionShip.Page;

public partial class Main : UserControl
{
    public List<Chatroom> Chatrooms { get; set; } 
    public Employee EmployeeContext { get; set; }
    public Chatroom ChatroomContext { get; set; }
    public Main(Employee employeeContext, Chatroom chatroomContext)
    {
        InitializeComponent();
        Chatrooms = App.dbContext.Chatrooms.ToList();
        EmployeeContext = employeeContext;
        DataContext = this;
        ChatroomContext = chatroomContext;
    }

    private void Button_CloseApplication(object? sender, RoutedEventArgs e)
    {
        App.MainWindow.Close();
    }

    private void Button_EmployeeFinder(object? sender, RoutedEventArgs e)
    {
        App.MainWindow.MyContent.Content = new EmployeeFinder();
    }

    private void SelectingItemsControl_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        throw new System.NotImplementedException();
    }
}