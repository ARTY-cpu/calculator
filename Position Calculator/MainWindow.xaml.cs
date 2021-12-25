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

namespace Position_Calculator
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (RadioButton1.IsChecked == true)
            {
                var capital = float.Parse(Startingcap.Text);
                var price = float.Parse(BTCprix.Text);
                var risque = float.Parse(risk.Text);

                var entry = float.Parse(Entry.Text);
                var TP = float.Parse(TakeProfit.Text);
                var SL = float.Parse(StopLoss.Text);

                var gain = (TP / entry - 1) * 100;
                var loss = (1 - SL / entry) * 100;
                var RR = gain / loss;

                var amount = (capital * risque) / loss;

                MessageBox.Show("gain :" + Math.Abs(gain) + " %" +
                                Environment.NewLine +
                                "loss :" + Math.Abs(loss) + " %" +
                                Environment.NewLine +
                                "RR :" + RR +
                                Environment.NewLine +
                                "Amount to trade : $" +Math.Abs(amount));

            }
            else if (RadioButton2.IsChecked == true)
            {
                var capital = float.Parse(Startingcap.Text);
                var price = float.Parse(BTCprix.Text);
                var risque = float.Parse(risk.Text);

                var entry = float.Parse(Entry.Text);
                var TP = float.Parse(TakeProfit.Text);
                var SL = float.Parse(StopLoss.Text);

                var gain = (TP / entry - 1) * 100;
                var loss = (1 - SL / entry) * 100;
                var RR = gain / loss;

                var amount = (capital * risque) / loss;

                MessageBox.Show("gain :" + Math.Abs(gain) + " %" +
                                Environment.NewLine +
                                "loss :" + Math.Abs(loss) + " %" +
                                Environment.NewLine +
                                "RR :" + RR +
                                Environment.NewLine +
                                "Amount to trade : $" +Math.Abs(amount));

            }
        }
    }
}