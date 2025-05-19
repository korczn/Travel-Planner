using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Travel_Planner;

public partial class NewWindow : Window
{
    public NewWindow(string firstName, string lastName, string countryPicked, string wybraneMiejsca)
    {
        InitializeComponent();
        statsImie.Text = $"Imie: {firstName}";
        statsNazwisko.Text = $"Nazwisko: {lastName}";
        statsCountryPicked.Text = $"Wybrany Kraj: {countryPicked}";
        statsWybraneMiejsca.Text = $"Wybrane Miejsca: " + string.Join(", ", wybraneMiejsca);
    }
    
    private void CloseButton_Click(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }
}