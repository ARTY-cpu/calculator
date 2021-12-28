using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
using System.Xml.Serialization;
using Binance.Net;

namespace Position_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    /*public class MySettings
    {
        public string Setting1 { get; set; }
        public string Setting2 { get; set; }
        
        

        public void Save(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                XmlSerializer xmls = new XmlSerializer(typeof(MySettings));
                xmls.Serialize(sw, this);
            }
        }
        public MySettings Read(string filename)
        {
            using (StreamReader sw = new StreamReader(filename))
            {
                XmlSerializer xmls = new XmlSerializer(typeof(MySettings));
                return xmls.Deserialize(sw) as MySettings;
            }
        }
    }
    */
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string json;

            using (var web = new System.Net.WebClient())
            {
                var url = @"https://api.coindesk.com/v1/bpi/currentprice.json";
                json = web.DownloadString(url);
            }

            dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            var currentPrice = Convert.ToDecimal(obj.bpi.USD.rate.Value);


            dynamic price = 0;
            var capital = float.Parse(Startingcap.Text);

            if (BTCprix.Text == "")
                price = currentPrice;
            else if (BTCprix.Text != "")
            {
                price = BTCprix.Text;
            }

            var risque = float.Parse(risk.Text);


            var entry = float.Parse(Entry.Text);

            var datetemp = DateTime.Now;
            var date_str = datetemp.ToString("g");
            
            var TP = float.Parse(TakeProfit.Text);
            var SL = float.Parse(StopLoss.Text);

            var gain = (TP / entry - 1) * 100; 
            var loss = (1 - SL / entry) * 100;
            var RR = gain / loss;

            var amount = (capital * risque) / loss;


            var lineStr = date_str + " " + price + " " + entry +" "+ TP +" "+ SL + (TP > SL ? " LONG": " SHORT");

            // async Task SaveCalcul(dynamic line_str)
            // {
            //     using StreamWriter file = new("History.txt", append:true);
            //     await file.WriteLineAsync(line_str);
            // }

            StreamWriter myWriter = File.AppendText("History.txt");
            myWriter.WriteLine(lineStr);
            myWriter.Close();
            
            //SaveCalcul(lineStr);

            MessageBox.Show("Price BTC :" + price + Environment.NewLine +
                            "gain :" + Math.Abs(gain) + " %" +
                            Environment.NewLine +
                            "loss :" + Math.Abs(loss) + " %" +
                            Environment.NewLine +
                            "RR :" + RR +
                            Environment.NewLine +
                            "Amount to trade : $" +Math.Abs(amount), "Result");
                
        }
    }
}