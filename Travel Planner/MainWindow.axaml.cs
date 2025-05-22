using System;
using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.ObjectModel;
using Avalonia.Media.Imaging;
using System.IO;

namespace Travel_Planner
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> miasta;

        public MainWindow()
        {
            InitializeComponent();

            miasta = new ObservableCollection<string>();
            MiastoListBox.ItemsSource = miasta;
        }

        private void Button_OnClickMiastoAdder(object? sender, RoutedEventArgs e)
        {
            var miasto = NoweMiastoTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(miasto))
            {
                miasta.Add(miasto);
                NoweMiastoTextBox.Text = string.Empty;
                Console.WriteLine("Dodano Nowe Miasto: " + miasto);
            }
        }

        private void OpenNewWindow_Click(object? sender, RoutedEventArgs e)
        {
            var wybraneMiejsca = new List<string>();

            string imie = Imie.Text;
            string nazwisko = Nazwisko.Text;
            string wybranyKraj = ComboBox.SelectionBoxItem?.ToString() ?? "";

            if (CheckBox1.IsChecked == true) wybraneMiejsca.Add("Muzea");
            if (CheckBox2.IsChecked == true) wybraneMiejsca.Add("Parki Narodowe");
            if (CheckBox3.IsChecked == true) wybraneMiejsca.Add("Zabytki");
            if (CheckBox4.IsChecked == true) wybraneMiejsca.Add("Restauracje");
            if (CheckBox5.IsChecked == true) wybraneMiejsca.Add("Burdele");
            if (CheckBox6.IsChecked == true) wybraneMiejsca.Add("Galerie Sztuki");
            if (CheckBox7.IsChecked == true) wybraneMiejsca.Add("Festiwale i Koncerty");

            string wybranyTransport = "";

            if (bicycle.IsChecked == true) wybranyTransport = "Rower";
            else if (train.IsChecked == true) wybranyTransport = "Pociąg";
            else if (ship.IsChecked == true) wybranyTransport = "Statek";
            else if (airplain.IsChecked == true) wybranyTransport = "Samolot";
            else if (helicopter.IsChecked == true) wybranyTransport = "Helikopter";
            else if (ufo.IsChecked == true) wybranyTransport = "UFO";
            else if (rocket.IsChecked == true) wybranyTransport = "Rakieta";
            else if (cannon.IsChecked == true) wybranyTransport = "Armata";
            else if (teleport.IsChecked == true) wybranyTransport = "Teleportacja";

            string wybraneMiasta = string.Join(", ", miasta);

            var noweOkno = new NewWindow(imie, nazwisko, wybranyKraj, string.Join(", ", wybraneMiejsca), wybranyTransport, wybraneMiasta);
            noweOkno.Show();
        }
    }
}
