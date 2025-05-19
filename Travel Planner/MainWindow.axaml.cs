using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Travel_Planner;

public partial class MainWindow : Window
{
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClickMiastoAdder(object? sender, RoutedEventArgs e)
    {
        Console.WriteLine("Dodano Nowe Miasto");
        
    }
}