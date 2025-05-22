using System;
using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System.IO;

namespace Travel_Planner
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<ListBoxItem> miasta;

        public MainWindow()
        {
            InitializeComponent();

            miasta = new ObservableCollection<ListBoxItem>
            {
                
            };

            MiastoListBox.ItemsSource = miasta;
        }
        
        private void Button_OnClickMiastoAdder(object? sender, RoutedEventArgs e)
        {
            var miasto = NoweMiastoTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(miasto))
            {
                var nowyItem = new ListBoxItem
                {
                    Content = miasto
                };

                miasta.Add(nowyItem);

                NoweMiastoTextBox.Text = string.Empty;

                Console.WriteLine("Dodano Nowe Miasto: " + miasto);
            }
        }
        
        private void OpenNewWindow_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {

            var wybraneMiejsca = new List<string>();
            
            string firstName = Imie.Text;
            string lastName = Nazwisko.Text;

            string countryPicked = ComboBox.SelectionBoxItem.ToString();

            if (CheckBox1.IsChecked == true)
                wybraneMiejsca.Add("Muzea");
            if (CheckBox2.IsChecked == true)
                wybraneMiejsca.Add("Parki Narodowe");
            if (CheckBox3.IsChecked == true)
                wybraneMiejsca.Add("Zabytki");
            if (CheckBox4.IsChecked == true)
                wybraneMiejsca.Add("Restauracje");
            if (CheckBox5.IsChecked == true)
                wybraneMiejsca.Add("Burdele");
            if (CheckBox6.IsChecked == true)
                wybraneMiejsca.Add("Galerie Sztuki");
            if (CheckBox7.IsChecked == true)
                wybraneMiejsca.Add("Festiwale i Koncerty");
            
            var noweOkno = new NewWindow(firstName, lastName, countryPicked, string.Join(", ", wybraneMiejsca));
            noweOkno.Show();
        }
        
    }
}