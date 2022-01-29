using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejercicio5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick_Calcular(object sender, RoutedEventArgs e)
        {
            int edad1 = 0;
            int edad2 = 0;
            int edad3 = 0;

            double promedio;

            edad1 = int.Parse(txtEdad1.Text);
            edad2 = int.Parse(txtEdad2.Text);
            edad3 = int.Parse(txtEdad3.Text);

            promedio = (edad1 + edad2 + edad3) / 3;

            txtPromedio.Text = promedio.ToString(); 
            

            if(edad1 > edad2 && edad1 > edad3)
            {
                txtEdadMayor.Text = edad1.ToString(); 
            }

            else if(edad2 > edad1 && edad2 > edad3)
            {
                txtEdadMayor.Text = edad2.ToString(); 
            }

            else if(edad3 > edad1 && edad3 > edad1)
            {
                txtEdadMayor.Text = edad3.ToString(); 
            }



            if(edad1 < edad2 && edad1 < edad3)
            {
                txtEdadMenor.Text = edad1.ToString(); 
            }

            else if(edad2 < edad1 && edad2 < edad3)
            {
                txtEdadMenor.Text = edad2.ToString(); 
            }

            else if(edad3 < edad1 && edad3 < edad1)
            {
                txtEdadMenor.Text = edad3.ToString(); 
            }

        }
    }
}
