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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long number1 = 0;
        long number2 = 0;
        string function = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        // События для кнопок с вводом цифр

        private void b_zero_Click(object sender, RoutedEventArgs e)
        {
            if (function == "")
            {
                number1 = (number1 * 10);
                b_display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                b_display.Text = number2.ToString();
            }
        }

        private void b_one_Click_1(object sender, RoutedEventArgs e)
        {
            if (function == "")
            {
                number1 = (number1 * 10) + 1;
                b_display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                b_display.Text = number2.ToString();
            }
        }

        private void b_two_Click(object sender, RoutedEventArgs e)
        {
            if (function == "")
            {
                number1 = (number1 * 10) + 2;
                b_display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                b_display.Text = number2.ToString();
            }
        }

        private void b_three_Click(object sender, RoutedEventArgs e)
        {
            if (function == "")
            {
                number1 = (number1 * 10) + 3;
                b_display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                b_display.Text = number2.ToString();
            }
        }

        private void b_four_Click(object sender, RoutedEventArgs e)
        {
            if (function == "")
            {
                number1 = (number1 * 10) + 4;
                b_display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                b_display.Text = number2.ToString();
            }
        }

        private void b_five_Click(object sender, RoutedEventArgs e)
        {
            if (function == "")
            {
                number1 = (number1 * 10) + 5;
                b_display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                b_display.Text = number2.ToString();
            }
        }

        private void b_six_Click(object sender, RoutedEventArgs e)
        {
            if (function == "")
            {
                number1 = (number1 * 10) + 6;
                b_display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                b_display.Text = number2.ToString();
            }
        }

        private void b_seven_Click(object sender, RoutedEventArgs e)
        {
            if (function == "")
            {
                number1 = (number1 * 10) + 7;
                b_display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                b_display.Text = number2.ToString();
            }
        }

        private void b_eight_Click(object sender, RoutedEventArgs e)
        {
            if (function == "")
            {
                number1 = (number1 * 10) + 8;
                b_display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                b_display.Text = number2.ToString();
            }
        }

        private void b_nine_Click(object sender, RoutedEventArgs e)
        {
            if (function == "")
            {
                number1 = (number1 * 10) + 9;
                b_display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                b_display.Text = number2.ToString();
            }
        }

        //События для кнопок с вводом действий

        private void b_plus_Click(object sender, RoutedEventArgs e)
        {
            function = "+";
            b_display.Text = "+";
        }

        private void b_minus_Click(object sender, RoutedEventArgs e)
        {
                function = "-";
                b_display.Text = "-";
        }

        private void b_times_Click(object sender, RoutedEventArgs e)
        {
            function = "*";
            b_display.Text = "*";
        }

        private void b_divide_Click(object sender, RoutedEventArgs e)
        {
            function = "/";
            b_display.Text = "/";
        }

        private void b_sqrt_Click(object sender, RoutedEventArgs e)
        {
            function = "sqrt";
            b_display.Text = "√";
        }

        // Перебор вариантов события знака равно при выборе различных действия

        private void b_equals_Click(object sender, RoutedEventArgs e)
        {
            switch (function)
            {
                case "+":
                    b_display.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    b_display.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    b_display.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    b_display.Text = (number1 / number2).ToString();
                    break;
                case "sqrt":
                    b_display.Text = (Math.Sqrt(number1)).ToString();
                    break;
            }
        }

        //Событие кнопки очистить дисплей

        private void b_clear_Click(object sender, RoutedEventArgs e)
        {
            number1= 0;
            number2= 0;
            function = "";
            b_display.Text = "0";
        }

        //Событие кнопки удалить символ

        private void b_back_Click(object sender, RoutedEventArgs e)
        {
            if (function == "")
            {
                number1 = (number1 / 10);
                b_display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                b_display.Text = number2.ToString();
            }
        }

        //Событие кнопки изменить знак +\-

        private void b_plusminus_Click(object sender, RoutedEventArgs e)
        {
            if (function == "")
            {
                number1 *= -1;
                b_display.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                b_display.Text = number2.ToString();
            }
        }
    }
}
