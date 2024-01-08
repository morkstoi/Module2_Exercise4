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

namespace ConverterApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double rateSum = Convert.ToDouble(sum.Text);
            double resultDouble = rateDollar * rateSum;
            resSum.Text = resultDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rateE.Text);
            double rateSum = Convert.ToDouble(sumEuro.Text);
            double resultDouble = rateEuro * rateSum;
            resSumEuro.Text = resultDouble.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateHryvnia = Convert.ToDouble(rateH.Text);
            double rateSum = Convert.ToDouble(sumHryvnia.Text);
            double resultDouble = rateHryvnia * rateSum;
            resSumHryvnia.Text = resultDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateArmDram = Convert.ToDouble(rateAD.Text);
            double rateSum = Convert.ToDouble(sumArmeniaDr.Text);
            double resultDouble = rateArmDram * rateSum;
            resSumArmeniaDr.Text = resultDouble.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double inchesInitial = Convert.ToDouble(inches.Text);
            double inchesToM = inchesInitial * 0.00254;
            inchesToMeters.Text = inchesToM.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double footInitial = Convert.ToDouble(foot.Text);
            double footToM = footInitial * 0.3048;
            footToMeters.Text = footToM.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double milesInitial = Convert.ToDouble(miles.Text);
            double milesToM = milesInitial * 1609.344;
            milesToMeters.Text = milesToM.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double verstInitial = Convert.ToDouble(verst.Text);
            double verstToM =verstInitial * 1066.8;
            verstToMeters.Text = verstToM.ToString();
        }
    }
}
