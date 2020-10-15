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

namespace Bowling_Stats
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double gameTotal;
        double gameX;
        double gameY;
        double gameZ;
        double AvgT;
        double HC;
        
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gameX = double.Parse(game1.Text);
            gameY = double.Parse(game2.Text);
            gameZ = double.Parse(game3.Text);
            

            gameTotal = gameX + gameY + gameZ;
            AvgT = gameTotal / 3;
            HC = 200 - AvgT*.8;


            Av.Text = Convert.ToString(AvgT);
            total.Text = Convert.ToString(gameTotal);
            handicap.Text = Convert.ToString(HC);
           
            


           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            game1.Text = "";
            game2.Text = "";
            game3.Text = "";
            Av.Text = "";
            total.Text = "";
            handicap.Text = "";
            name.Text = "";

        }

        private void ExitButton_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        
      
    }
}
