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

namespace Calc
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

        string result;
        char[] validChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ',', '(', ')','=' };
        private void InPut_TextChanged(object sender, TextChangedEventArgs e)
        {
            result = "";
            int i = 0;
            int counter = 0;
            foreach (char c in InPut.Text)
            {
                if (Array.IndexOf(validChars, c) != -1)
                {
                    if (c == ',')
                    {
                        if (i != 0)
                        {
                            if (!result.Contains(','))
                            {
                                result += c;
                            }
                        }
                    }
                    else if (c == ')')
                    {
                        if (result.Contains('('))
                        {
                            counter--;
                            result += c;
                            //if(counter!=0)
                            //foreach(char a in result)
                            //{
                            //    if(a=='(')
                            //    {
                            //        counter--;
                            //    }
                            //}
                            //if (counter >= 1)
                            //{
                            //    result += c;
                            //}
                        }
                    }
                    //else if (c == '(')
                    //{
                    //    counter++;
                    //    result += c;
                    //}
                    else
                    {
                        result += c;
                    }
                }
                i++;
            }
            InPut.Text = result;
        }

        private void AddScobka2_Click(object sender, RoutedEventArgs e)
        {
            InPut.Text += ")";
        }

        private void AddScobka1_Click(object sender, RoutedEventArgs e)
        {
            InPut.Text += "(";
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            InPut.Text += ($"={result}");
        }
    }
}
