using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//---
using System.IO;
using Microsoft.Win32;
using System.Threading;
using System.Windows.Threading;

namespace WpfFormularzStudenta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ContextMenu kontextFormularza = null;
        //------
        private string[] uczelnie =
        {"Politechnika Gdańska","Politechnika Poznańska",
            "Politechnika Koszalińska","Politechnika Warszawska",
            "Politechnika Wrocławska","Politechnika Łódzka"};
        private string[] jezyki =
        {"język angielski", "język francuski", "język niemiecki",
        "język włoski","język rosyjski"};
        //---
        public MainWindow()
        {
            InitializeComponent();
            this.Reset();
            //---
            MenuItem kontextZapiszStud = new MenuItem();
            kontextZapiszStud.Header = "Zapisz Dane Studenta";
            kontextZapiszStud.Click += new RoutedEventHandler(zapiszDane_Click);
            //---
            MenuItem kontextWyczyscForm = new MenuItem();
            kontextWyczyscForm.Header = "Wyczyść Formularz";
            kontextWyczyscForm.Click += new RoutedEventHandler(wyczysc_Click);
            //---
            kontextFormularza = new ContextMenu();
            kontextFormularza.Items.Add(kontextZapiszStud);
            kontextFormularza.Items.Add(kontextWyczyscForm);
        }
        //--------------
        public void Reset()
        {
            this.imie.Text = String.Empty;
            this.nazwisko.Text = string.Empty;
            this.listaUczelni.Items.Clear();
            foreach (string szkola in uczelnie)
            {
                this.listaUczelni.Items.Add(szkola);
            }
            this.listaUczelni.Text = this.listaUczelni.Items[0] as string;
            //---
            this.listaJezykow.Items.Clear();
            CheckBox cbJezyk = null;
            foreach (string jezyk in jezyki)
            {
                cbJezyk = new CheckBox();
                cbJezyk.Margin = new Thickness(0, 0, 0, 10);
                cbJezyk.Content = jezyk;
                listaJezykow.Items.Add(cbJezyk);
            }
            this.czyElektrotech.IsChecked = false;
            this.rok1.IsChecked = true;
            this.dataPraktyki.Text = DateTime.Today.ToString();
        }
        //---------
        private void dodaj_Click(object sender, RoutedEventArgs e)
        {
            string nazwiskoUczelnia = String.Format(
                "Nazwisko studenta: {0} {1} z {2} \nZnajomość języków:",
                this.imie.Text, this.nazwisko.Text, this.listaUczelni.Text);
            StringBuilder info = new StringBuilder();
            info.AppendLine(nazwiskoUczelnia);
            foreach (CheckBox cb in this.listaJezykow.Items)
            {
                if (cb.IsChecked.Value)
                {
                    info.AppendLine(cb.Content.ToString());
                }
            }
            MessageBox.Show(info.ToString(), "Dane studenta");
        }
        //-------------------------
        private void wyczysc_Click(object sender, RoutedEventArgs e)
        {
            this.Reset();
        }
        //------------------------
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult key = MessageBox.Show(
                "Czy chcesz zamknąć aplikację?",
                "Potwierdzenie",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question,
                MessageBoxResult.No);
            if (key == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
        //---------------------
        private void nowyStazysta_Click(object sender, RoutedEventArgs e)
        {
            this.Reset();
            zapiszDane.IsEnabled = true;
            imie.IsEnabled = true;
            nazwisko.IsEnabled = true;
            listaUczelni.IsEnabled = true;
            czyElektrotech.IsEnabled = true;
            dataPraktyki.IsEnabled = true;
            groupBox1.IsEnabled = true;
            listaJezykow.IsEnabled = true;
            wyczysc.IsEnabled = true;
            dodaj.IsEnabled = true;
            //---
            this.ContextMenu = kontextFormularza;
        }
        //-------------
        private void wyjscie_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //--------------
        private void zapiszDane_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "txt";
            saveDialog.AddExtension = true;
            saveDialog.FileName = "Stażysta_";
            saveDialog.InitialDirectory = @"C:\Staze\Staze2016\";
            saveDialog.OverwritePrompt = true;
            saveDialog.Title = "Stażysta 2016";
            saveDialog.ValidateNames = true;
            //---
            if (saveDialog.ShowDialog().Value)
            {
                Member member = new Member();
                member.Imie = imie.Text;
                member.Nazwisko = nazwisko.Text;
                member.Uczelnia = listaUczelni.Text;
                member.CzyElektrotechnika = czyElektrotech.IsChecked.Value;
                member.Jezyki = new List<string>();
                foreach (CheckBox cb in listaJezykow.Items)
                {
                    if (cb.IsChecked.Value)
                    {
                        member.Jezyki.Add(cb.Content.ToString());
                    }
                }
                //---
                Thread watek = new Thread(() => this.saveData(saveDialog.FileName, member));
                watek.Start();
            }
        }
        //------------------------
        private void info_Click(object sender, RoutedEventArgs e)
        {
            Informacja dialogInfo = new Informacja();
            dialogInfo.ShowDialog();
        }
        //-------------------
        private void usunNazwisko_Click(object sender, RoutedEventArgs e)
        {
            imie.Clear();
            nazwisko.Clear();
        }
        //---------------------
        private void otworzDane_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.DefaultExt = "txt";
            openDialog.FileName = "Stażysta_";
            openDialog.InitialDirectory = @"C:\Staze\Staze2016\";
            openDialog.Title = "Stażysta 2016";
            if (openDialog.ShowDialog().Value)
            {
                using (StreamReader reader = new StreamReader(openDialog.FileName))
                {
                    imie.Text = reader.ReadLine();
                    nazwisko.Text = reader.ReadLine();
                    string uczelnia = reader.ReadLine().Substring(9);
                }
            }
        }
        //---------------------
        private void saveData(string nazwaPliku, Member member)
        {
            using (StreamWriter writer = new StreamWriter(nazwaPliku))
            {
                writer.WriteLine("Imię: {0}", member.Imie);
                writer.WriteLine("Nazwisko: {0}", member.Nazwisko);
                writer.WriteLine("Uczelnia: {0}", member.Uczelnia);
                writer.WriteLine("Elektrotech.: {0}", member.CzyElektrotechnika.ToString());
                writer.WriteLine("Języki:");
                foreach (string jezyk in member.Jezyki)
                {
                    writer.WriteLine(jezyk);
                }
                Thread.Sleep(10000);
                //MessageBox.Show("Dane stażysty zapisano", "Zapis danych");
                //---
                Action action = new Action(() => { status.Items.Add("Dane stażysty zapisano"); });
                this.Dispatcher.Invoke(action, DispatcherPriority.ApplicationIdle);
            }
        }
    }
}
