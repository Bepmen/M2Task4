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

namespace M2Task4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Обработчики закладки Валюты
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateDollar1 = Convert.ToDouble(rate1.Text);
            double sumDollar1 = Convert.ToDouble(sum1.Text);
            double resDouble1 = rateDollar1 * sumDollar1;
            resSum1.Text = resDouble1.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateDollar2 = Convert.ToDouble(rate2.Text);
            double sumDollar2 = Convert.ToDouble(sum2.Text);
            double resDouble2 = rateDollar2 * sumDollar2;
            resSum2.Text = resDouble2.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDollar3 = Convert.ToDouble(rate3.Text);
            double sumDollar3 = Convert.ToDouble(sum3.Text);
            double resDouble3 = rateDollar3 * sumDollar3;
            resSum3.Text = resDouble3.ToString();
        }

        #endregion

        #region обработчики закладки Расстояния
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double quantElem = Convert.ToDouble(quantity.Text);
            double meterResul = quantElem * 0.0254;
            meter.Text = meterResul.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double quantElem = Convert.ToDouble(quantity1.Text);
            double meterResul = quantElem * 0.3048;
            meter1.Text = meterResul.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double quantElem = Convert.ToDouble(quantity2.Text);
            double meterResul = quantElem * 1609.344;
            meter2.Text = meterResul.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double quantElem = Convert.ToDouble(quantity3.Text);
            double meterResul = quantElem * 1066.8;
            meter3.Text = meterResul.ToString();
        }
        #endregion
    }
}
