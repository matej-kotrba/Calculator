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
using System.Threading;
using System.Timers;

namespace Kalkulacka
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int cislo = 0;
        int cislo1 = 0;
        char znamenko;
        static public bool stalo;
        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
            //Color test = new Color();
            //int test; 
            //Color.FromRgb(Convert.ToByte(rnd.Next(0, 255)), Convert.ToByte(rnd.Next(0, 255)), Convert.ToByte(rnd.Next(0, 255)));
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button tlactitko = sender as Button;
            
            if (Convert.ToString(hodnota.Content) != "Some Value ..." && Convert.ToString(tlactitko.Content) != "+" &&
                Convert.ToString(tlactitko.Content) != "-" && Convert.ToString(tlactitko.Content) != "=" && Convert.ToString(tlactitko.Content) != "C") {
                hodnota.Content += Convert.ToString(tlactitko.Content);
                    }
            else if (Convert.ToString(hodnota.Content) == "Some Value ..." || Convert.ToString(hodnota.Content) == "Math Error")
            {
                hodnota.Content = "";
                if (Convert.ToString(tlactitko.Content) != "C" && Convert.ToChar(tlactitko.Content) != '+' && Convert.ToChar(tlactitko.Content) != '-')
                hodnota.Content += Convert.ToString(tlactitko.Content);
            }
            if (Convert.ToString(tlactitko.Content) == "C")
            {
                cislo = 0;
                cislo1 = 0;
                hodnota.Content = "Some Value ...";
                plus.IsEnabled = true;
                minus.IsEnabled = true;
                kalkulackaCisla.IsEnabled = true;
            }
            if (Convert.ToString(tlactitko.Content) == "+" || Convert.ToString(tlactitko.Content) == "-" || Convert.ToString(tlactitko.Content) == "=")
            {
                try
                {
                    if (cislo == 0 && cislo1 == 0 && Convert.ToString(tlactitko.Content) != "=")
                    {
                        //MessageBox.Show("cislo se zapsalo");
                        
                        cislo = Convert.ToInt32(hodnota.Content);
                        znamenko = Convert.ToChar(tlactitko.Content);
                        //MessageBox.Show(Convert.ToString(cislo));
                        //MessageBox.Show(Convert.ToString(znamenko));
                        hodnota.Content = "";
                        plus.IsEnabled = false;
                        minus.IsEnabled = false;
                    }
                    else if (cislo1 == 0 && cislo != 0 && Convert.ToString(tlactitko.Content) == "=")
                    {
                        //MessageBox.Show("cislo1 se zapsalo");
                        cislo1 = Convert.ToInt32(hodnota.Content);
                        if (znamenko == '+')
                        {
                            hodnota.Content = Convert.ToString(cislo + cislo1);
                            kalkulackaCisla.IsEnabled = false;
                        }
                        else if (znamenko == '-')
                        {
                            hodnota.Content = Convert.ToString(cislo - cislo1);
                            kalkulackaCisla.IsEnabled = false;
                        }
                        //hodnota.Content = "";
                    }
                    
                    
                }
                catch (Exception)
                {
                    hodnota.Content = "Math Error";
                }
            }
            // Create a timer with a 1 second interval.
            /*CustomTimer aTimer = new CustomTimer()
            {
                Interval = 1000,
                Data = Convert.ToString(tlactitko.Content)
            };*/

            // Hook up the Elapsed event for the timer. 
           // aTimer.Elapsed += (s,g)=> { tlactitko.Background; };

            // Only tick one time
            //aTimer.AutoReset = false;

            // Start timer
            //aTimer.Enabled = true;

            //tlactitko.Background = Brushes.White; //new SolidColorBrush(Colors.White);
            
            
            
        }

        public static void neco(object source, ElapsedEventArgs e)
        {
           // object tlacitko = (Button)FindName(tlacitko);
            //Button informace = ((CustomTimer)source).Data;
            
        }

        public static void zmena(Button tlatcitko)
        {
            //
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToString(hodnota.Content) == "Some Value ..." || Convert.ToString(hodnota.Content) == "Math Error")
            {
                hodnota.Content = "";
                
            }
            if (e.Key == Key.Escape)
            {

                System.Windows.Application.Current.Shutdown();
            }
            if (e.Key == Key.NumPad0)
            {
                hodnota.Content += Convert.ToString(0);
            }
            if (e.Key == Key.NumPad1)
            {
                hodnota.Content += Convert.ToString(1);
            }
            if (e.Key == Key.NumPad2)
            {
                hodnota.Content += Convert.ToString(2);
            }
            if (e.Key == Key.NumPad3)
            {
                hodnota.Content += Convert.ToString(3);
            }
            if (e.Key == Key.NumPad4)
            {
                hodnota.Content += Convert.ToString(4);
            }
            if (e.Key == Key.NumPad5)
            {
                hodnota.Content += Convert.ToString(5);
            }
            if (e.Key == Key.NumPad6)
            {
                hodnota.Content += Convert.ToString(6);
            }
            if (e.Key == Key.NumPad7)
            {
                hodnota.Content += Convert.ToString(7);
            }
            if (e.Key == Key.NumPad8)
            {
                hodnota.Content += Convert.ToString(8);
            }
            if (e.Key == Key.NumPad9)
            {
                hodnota.Content += Convert.ToString(9);
            }
            
        }

    }

    /*class CustomTimer : System.Timers.Timer
    {
        public string Data;
        
    }*/
}
