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

namespace RatonTeclado
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BotonDerechoRectangle.Fill = Brushes.White;
            BotonIzquierdoRectangle.Fill = Brushes.White;
        }

        private void Ayuda(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                ((TextBox)sender).Text = "AYUDA";
            }
        }

        private void CambiarColor1(object sender, MouseButtonEventArgs e)
        {
            BotonIzquierdoRectangle.Fill = Brushes.Aqua;
        }

        private void RestaurarColor1(object sender, MouseButtonEventArgs e)
        {
            BotonIzquierdoRectangle.Fill = Brushes.White;
        }

        private void CambiarColor2(object sender, MouseButtonEventArgs e)
        {
            BotonDerechoRectangle.Fill = Brushes.Aqua;
        }

        private void RestaurarColor2(object sender, MouseButtonEventArgs e)
        {
            BotonDerechoRectangle.Fill = Brushes.White;
        }

        private void RatonSobre(object sender, MouseEventArgs e)
        {
            RatonSobreTextBox.Text = ((TextBox)sender).Name;
        }

        private void RatonSale(object sender, MouseEventArgs e)
        {
            RatonSobreTextBox.Text = "";
        }

        private void FocusSobreTextBox(object sender, RoutedEventArgs e)
        {
            FocoTextoBox.Text = ((TextBox)sender).Name;
        }

        private void LostFocusTextBox(object sender, RoutedEventArgs e)
        {
            FocoTextoBox.Text = "";
        }

        private void EliminarVocales(object sender, TextChangedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            char[] vocales = "aeiouAEIOU".ToCharArray();
            StringBuilder textoSinVocales = new StringBuilder("");
            for (int i = 0; i < tb.Text.Length; i++)
            {
                if (!vocales.Contains(tb.Text[i]))
                {
                    textoSinVocales.Append(tb.Text[i]);
                }
            }
            tb.Text = textoSinVocales.ToString();
            tb.CaretIndex = tb.Text.Length;
        }
    }
}
