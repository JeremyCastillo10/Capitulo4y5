using System;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Capitulo4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num1, num, resultado;
        public MainWindow()
        {
            InitializeComponent();
            //Listaview.ItemsSource;
        }

        private void ButtonClick_Calcular(object sender, RoutedEventArgs e)
        {
            string strNum1;
            strNum1 = this.txtNum1.Text;
            int.TryParse(strNum1, out num1);
            this.Resultado.Items.Clear();

            for(int i = 0; i <= 10; i++)
            {
                resultado = num1 * i;
                this.Resultado.Items.Add(num1 + "X" + i + " = " + resultado);
            }

        }

        private void ButtonClick_Limpiar(object sender, RoutedEventArgs e)
        {
            this.txtNum1.Text = string.Empty;

            this.Resultado.Items.Clear();

        }

    }
}
