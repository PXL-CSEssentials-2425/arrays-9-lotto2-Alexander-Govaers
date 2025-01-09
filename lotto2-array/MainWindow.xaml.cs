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

namespace lotto2_array
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

        int[] willekeurigeGetallenArray = new int[6];

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random getal = new Random();





            
                for (int i = 0; i < willekeurigeGetallenArray.Length; i++)
            {

                int gekozenGetal;  

                do
                {
                    gekozenGetal = getal.Next(1, 46);

                   

                }
                while 
                
                (willekeurigeGetallenArray.Contains(gekozenGetal));

                willekeurigeGetallenArray[i] = gekozenGetal;

            }
                

      

            lottoGetallenTextbox.Text = ($"De 6 LOTTO-gettalen zijn: \r\n GETAL1 : {willekeurigeGetallenArray[0]} \r\n GETAL2 : {willekeurigeGetallenArray[1]} \r\n GETAL3 : {willekeurigeGetallenArray[2]} \r\n GETAL4 : {willekeurigeGetallenArray[3]} \r\n GETAL5 : {willekeurigeGetallenArray[4]} \r\n GETAL6 : {willekeurigeGetallenArray[5]}");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lottoGetallenTextbox.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
