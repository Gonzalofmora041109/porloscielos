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
using Aerolinia;

namespace Formulario
{
    /// <summary>
    /// Lógica de interacción para Estadistica.xaml
    /// </summary>
    public partial class Estadistica : Window
    {
        public Colleccion Pasajes { get; set; }

        public Estadistica()
        {
            InitializeComponent();
            comboBox1.ItemsSource = Enum.GetValues(typeof(TipoPasaje));
            comboBox1.SelectedValue = TipoPasaje.Seleccione;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Pasajes.sumar().ToString());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Pasajes.tipo(comboBox1.SelectedValue.ToString()).ToString());
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
