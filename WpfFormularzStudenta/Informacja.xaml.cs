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
using System.Windows.Shapes;

namespace WpfFormularzStudenta
{
    /// <summary>
    /// Interaction logic for Informacja.xaml
    /// </summary>
    public partial class Informacja : Window
    {
        public Informacja()
        {
            InitializeComponent();
        }

        private void zamknij_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
