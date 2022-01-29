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

namespace Ejercicio2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double Nbase, Nexponente;
       double resultado;
        public MainWindow()
        {
            InitializeComponent();
        }

          private void ButtonClick_Calcular(object sender, RoutedEventArgs e)
        {
            string?strBase, strExponente;
            strBase = this.txtBase.Text;
            double.TryParse(strBase, out Nbase);

            strExponente = this.txtExponente.Text;
            double.TryParse(strExponente, out Nexponente);


            this.Resultado.Items.Clear();

            resultado = Math.Pow(Nbase,Nexponente);
            this.Resultado.Items.Add(Nbase + "^" + Nexponente + " = " + resultado);

        }

        private void ButtonClick_Limpiar(object sender, RoutedEventArgs e)
        {
            this.txtBase.Text = string.Empty;

            this.txtExponente.Text = string.Empty;
            

            this.Resultado.Items.Clear();


        }

    }
}
