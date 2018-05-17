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
using Aerolinia;
using Aerolinia.Servicios;
namespace Formulario
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Colleccion registro = new Colleccion();
        int cont=1;
        public MainWindow()
        {
            InitializeComponent();
            comboBox1.ItemsSource = Enum.GetValues(typeof(Ciudad));
            comboBox2.ItemsSource = Enum.GetValues(typeof(Ciudad));
            comboBox3.ItemsSource = Enum.GetValues(typeof(TipoPasaje));
            comboBox1.SelectedValue = Ciudad.Seleccione;
            comboBox2.SelectedValue = Ciudad.Seleccione;
            comboBox3.SelectedValue = TipoPasaje.Seleccione;
            Limpiar();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Btn_Mostrar(object sender, RoutedEventArgs e)
        {
           
            dataGrid1.ItemsSource = registro;
            dataGrid1.Items.Refresh();
        }
        public void Limpiar()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            dataGrid1.ItemsSource = null;
            comboBox1.SelectedValue = Ciudad.Seleccione;
            comboBox2.SelectedValue = Ciudad.Seleccione;
            comboBox3.SelectedValue = TipoPasaje.Seleccione;
            datePicker1.SelectedDate = DateTime.Now;
            datePicker2.SelectedDate = DateTime.Now;

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void Btn_Agregar(object sender, RoutedEventArgs e)
        {

            try
            {
                RegistroPasaje regg = new RegistroPasaje();
                PoblarPasajes(ref regg);
                cont++;
                registro.Add(regg);
                Create_user create_User = new Create_user();
                string nombre = textBox1.Text;
                string apellido = textBox2.Text;
                create_User.Agregar(nombre,apellido);

                MessageBox.Show("Pasaje registrado", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Estadistica form = new Estadistica();
            form.Pasajes = registro;
            form.ShowDialog();
        }
        private void PoblarPasajes(ref RegistroPasaje regg)
        {

            switch ((TipoPasaje)comboBox1.SelectedValue)
            {
                case TipoPasaje.Ida:
                    SoloIda ss = new SoloIda();
                    ss.FechaV = (DateTime)datePicker1.SelectedDate;
                    ss.ciudadO = (Ciudad)comboBox2.SelectedValue;
                    ss.ciudadD = (Ciudad)comboBox1.SelectedValue;
                    ss.ValorB = int.Parse(textBox3.Text);
                    ss.ID = "PSJ-IDA-000"+cont.ToString();
                    int x = int.Parse(textBox3.Text);
                    ss.ValorT = ss.Costo(x);
                    textBox5.Text = ss.Costo(x).ToString();
                    ss.ValorB = int.Parse(textBox3.Text);
                    textBox4.Text = ss.ID;
                    break;
                case TipoPasaje.Ida_Regreso:
                    IdaRegreso ii = new IdaRegreso();
                    ii.FechaI = (DateTime)datePicker1.SelectedDate;
                    ii.FechaR = (DateTime)datePicker2.SelectedDate;
                    ii.ciudadO = (Ciudad)comboBox2.SelectedValue;
                    ii.ciudadD = (Ciudad)comboBox1.SelectedValue;
                    ii.ValorB = int.Parse(textBox3.Text);
                    ii.ID = "PSJ-IYR-000" + cont.ToString();
                    int c = int.Parse(textBox3.Text);
                    ii.ValorT = ii.Costo(c);
                    textBox5.Text=ii.Costo(c).ToString();
                    ii.ValorB = int.Parse(textBox3.Text);
                    textBox4.Text = ii.ID;
                    break;
            }
            regg.Nombre = textBox1.Text;
            regg.Apellidos = textBox2.Text;
            regg.Tipo = (TipoPasaje)comboBox3.SelectedValue;
            regg.ValorB = int.Parse(textBox3.Text);
            regg.Total = int.Parse(textBox5.Text);
            regg.Nombres = "hola";

        }

       
    }
}
