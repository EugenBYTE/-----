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

namespace Calculator
{
    public partial class MainWindow : Window
    {
        long number1 = 0;
        long number2 = 0;
        string operation = "";


        public MainWindow()
        {
            InitializeComponent();
        }
        //Btn number
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                Disp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                Disp.Text = number2.ToString();
            }
        }


        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                Disp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                Disp.Text = number2.ToString();
            }
        }


        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                Disp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                Disp.Text = number2.ToString();
            }
        }


        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                Disp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                Disp.Text = number2.ToString();
            }
        }


        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                Disp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                Disp.Text = number2.ToString();
            }
        }


        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                Disp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                Disp.Text = number2.ToString();
            }
        }


        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                Disp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                Disp.Text = number2.ToString();
            }
        }


        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                Disp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                Disp.Text = number2.ToString();
            }
        }


        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                Disp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                Disp.Text = number2.ToString();
            }
        }


        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                Disp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                Disp.Text = number2.ToString();
            }
        }
        //btn Math
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation ="+";
            Disp.Text = "0";
        }

        private void btnMinul_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            Disp.Text = "0";
        }

        private void btnUmnog_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            Disp.Text = "0";
        }

        private void btnDelit_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            Disp.Text = "0";
        }


        private void btnRavno_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    Disp.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    Disp.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    Disp.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    Disp.Text = (number1 / number2).ToString();
                    break;
            }
        }

        //btn delete
        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            if (operation=="")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            Disp.Text = "0";
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            Disp.Text = "0";
        }
        private void btnBackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                Disp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                Disp.Text = number2.ToString();
            }
        }
        //btn negativ positiv
        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *=-1;
                Disp.Text = number1.ToString();
            }
            else
            {
                number2 *= -1; 
                Disp.Text = number2.ToString();
            }
        }
    }
}

