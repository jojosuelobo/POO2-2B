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

namespace Trabalho2B
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
        int ContCatalago = 0;
        private void BotaoDireita_Click(object sender, RoutedEventArgs e)
        {
            ContCatalago++;
            if(ContCatalago%2 == 0)
            {
                CatalogoTitulo.Content = "CURSO DE JAVA";
                CatalogoCargaH.Content = "20h";
                CatalagoInstrutor.Content = "Vinicius Rosalen";
                CatalagoCodigo.Content = "2654";
            }
            if(ContCatalago%3 == 0)
            {
                CatalogoTitulo.Content = "CURSO DE JAVASCRIPT";
                CatalogoCargaH.Content = "15h";
                CatalagoInstrutor.Content = "Ricardo Ventura";
                CatalagoCodigo.Content = "1398";
            }
            else
            {
                CatalogoTitulo.Content = "CURSO DE PYTHON";
                CatalogoCargaH.Content = "9h";
                CatalagoInstrutor.Content = "Ellon Murito";
                CatalagoCodigo.Content = "9867";
            }

        }

        private void BotaoEsquerda_Click(object sender, RoutedEventArgs e)
        {
            ContCatalago--;
            if (ContCatalago % 2 == 0)
            {
                CatalogoTitulo.Content = "CURSO DE JAVA";
                CatalogoCargaH.Content = "20h";
                CatalagoInstrutor.Content = "Vinicius Rosalen";
                CatalagoCodigo.Content = "2654";
            }
            if (ContCatalago % 3 == 0)
            {
                CatalogoTitulo.Content = "CURSO DE JAVASCRIPT";
                CatalogoCargaH.Content = "15h";
                CatalagoInstrutor.Content = "Ricardo Ventura";
                CatalagoCodigo.Content = "1398";
            }
            else
            {
                CatalogoTitulo.Content = "CURSO DE PYTHON";
                CatalogoCargaH.Content = "9h";
                CatalagoInstrutor.Content = "Ellon Murito";
                CatalagoCodigo.Content = "9867";
            }
        }
    }
}
