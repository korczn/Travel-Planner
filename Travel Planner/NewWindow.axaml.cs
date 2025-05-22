using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Travel_Planner;

public partial class NewWindow : Window
{
    public NewWindow(string imie, string nazwisko, string wybranyKraj, string wybraneMiejsca, string wybranyTransport, string wybraneMiasta)
    {
        InitializeComponent();
        statsImie.Text = $"Imie: {imie}";
        statsNazwisko.Text = $"Nazwisko: {nazwisko}";
        statsWybranyKraj.Text = $"Wybrany Kraj: {wybranyKraj}";
        statsWybraneMiejsca.Text = $"Wybrane Miejsca do Odwiedzenia: " + string.Join(", ", wybraneMiejsca);
        statsWybranyTransport.Text = $"Wybrany Transport: {wybranyTransport}";
        statsWybraneMiasta.Text = $"Wybrane Miasta do Odwiedzenia: {wybraneMiasta}";
    }
    
    private void CloseButton_Click(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }
}