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

namespace WpfLesson_20
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double a, b, rez;
        public int cod = 0;
        public bool znak = false;

      

        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            text.Text = text.Text + "7";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            text.Text = text.Text + "4";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            text.Text = text.Text + "5";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            text.Text = text.Text + "6";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            text.Text = text.Text + "1";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            text.Text = text.Text + "2";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            text.Text = text.Text + "3";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            text.Text = text.Text + "0";
        }

     

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            text.Text = text.Text + "8";
        }

        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            text.Text = text.Text + "9";
        }

        
        private void Button_Click_rezult(object sender, RoutedEventArgs e)
        {
            if (znak == true)
            {
                switch (cod)                                          
                {
                    case 1:
                        b = Convert.ToDouble(text.Text);
                        rez = a + b;
                        text.Text = Convert.ToString(rez);
                        break;
                    case 2:
                        b = Convert.ToDouble(text.Text);
                        rez = a - b;
                        text.Text = Convert.ToString(rez);
                        break;
                    case 3:
                        b = Convert.ToDouble(text.Text);
                        rez = a * b;
                        text.Text = Convert.ToString(rez);
                        break;
                    case 4:
                        b = Convert.ToDouble(text.Text);
                        if (b != 0)
                        {
                            rez = a / b;
                            text.Text = Convert.ToString(rez);
                        }
                        else
                            text.Text = "Error";
                        break;

                    default:
                        break;
                }
            }
        }

      

      
      
        private void Button_Click_plus(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(text.Text) != "")
            {
                a = Convert.ToDouble(text.Text);
                cod = 1;
                text.Text = "";
                znak = true;
            }
        }  
        private void Button_Click_minus(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(text.Text) != "")
            {
                a = Convert.ToDouble(text.Text);
                cod = 2;
                text.Text = "";
                znak = true;
            }
        }

        private void Button_Click_clean(object sender, RoutedEventArgs e)
        {
            text.Text = "";
        }

        private void Button_Click_multi(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(text.Text) != "")
            {
                a = Convert.ToDouble(text.Text);
                cod = 3;
                text.Text = "";
                znak = true;
            }
        }
        private void Button_Click_divis(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(text.Text) != "")
            {
                a = Convert.ToDouble(text.Text);
                cod = 4;
                text.Text = "";
                znak = true;
            }
        }
















      






    }
}
