using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfButtonsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            RadioButton r3 = new() { GroupName = "Group2", Content = "Radio 33", IsChecked = true };
            stack.Children.Add(r3);
            ToolTip tp = new ToolTip();
            
            
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("button 1");
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("button 2");
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("button 3");
        }

        private void Increase(object sender, RoutedEventArgs e)
        {
            valueText.Text = (Int32.Parse(valueText.Text) + 1).ToString();
        }

        private void Decrease(object sender, RoutedEventArgs e)
        {
            valueText.Text = (Int32.Parse(valueText.Text) - 1).ToString();
        }

        private void chk1_Checked(object sender, RoutedEventArgs e)
        {
            if(chk1.IsThreeState)
            {
                if (chk1.IsChecked == null)
                    MessageBox.Show("Неопределено");
                if (chk1.IsChecked == true)
                    MessageBox.Show("Checked");
                else
                    MessageBox.Show("UnChecked");

            }
        }

        private void RadioButton_Checked1(object sender, RoutedEventArgs e)
        {
            var selectRb = (sender as RadioButton);
            MessageBox.Show(selectRb.Content.ToString());
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            popup.IsOpen = true;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            //popup.IsOpen = false;
        }
    }
}
