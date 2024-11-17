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
            Button button = (Button)sender;
            Display.Text += button.Content;
        }
        private void eq_fun(object sender, RoutedEventArgs e)
        {
            string First_part = "";
            string Second_part = "";
            char op = ' ';
            string Part = Display.Text;
            decimal total = 0;
          

            for (int i = 0; i < Part.Length; i++)
            {

                if (char.IsDigit(Part[i]))
                {

                    if (op == ' ')
                    {


                        First_part += Part[i];
                    }
                    else
                    {
                        Second_part += Part[i];
                    }
                }
                else
                {
                    op = Part[i];
                }
            }
            if (op == '+')
            {
                total = Convert.ToDecimal(First_part) + Convert.ToDecimal(Second_part);
            }
            else if (op == '-')
            {
                total = Convert.ToDecimal(First_part) - Convert.ToDecimal(Second_part);
           
            }
            else if (op == 'x')
            {
                total = Convert.ToDecimal(First_part) * Convert.ToDecimal(Second_part);
       
            }
            else if (op == '/' )
            {
                  
                    if(Convert.ToDecimal(Second_part)!=0)
                    {
                total = Convert.ToDecimal(First_part) / Convert.ToDecimal(Second_part);

          
                    }
                    else
                    {
                    Display.Text = "ERORR";
                    return;
                    }
                    
            Display.Text = total.ToString();
                   
            }
            

            }
           
        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Display.Text = Display.Text.Remove(Display.Text.Length-1);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Display.Clear();
        }
    }
}
