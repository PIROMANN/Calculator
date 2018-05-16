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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       string A, B;
        string Action;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            ClassCalculator c = new ClassCalculator();
            B = ( textBox.Text);
            if((sender as Button).Content.ToString() == "+" || (sender as Button).Content.ToString() == "-" || (sender as Button).Content.ToString() == "*" || (sender as Button).Content.ToString() == "/")
            {
                Action = (sender as Button).Content.ToString();
                A = (textBox.Text);
                textBox.Text = "";
                return;
            }
            else if((sender as Button).Content.ToString() == "=")
            {
                
               switch (Action)
                {
                    case "+":
                        {
                            textBox.Text = c.Plus(A, B).ToString();
                            break;
                        }
                    case "-":
                        {
                            textBox.Text = c.Minus(A, B).ToString();
                            break;
                        }
                    case "*":
                        {
                            textBox.Text = c.Multiplication(A, B).ToString();
                            break;
                        }
                    case "/":
                        {
                            textBox.Text = c.Division(A, B).ToString();
                            break;
                        }
                }
            }
            else
            {
                textBox.Text += (sender as Button).Content.ToString();
            }
            
        }



    }
}
