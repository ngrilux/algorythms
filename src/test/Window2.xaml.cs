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
using System.Windows.Shapes;

namespace test
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtYe_Click(object sender, RoutedEventArgs e)
        {
            TbR.Background = Brushes.Gray;
            TbGr.Background = Brushes.Gray;
            TbYe.Background = Brushes.Yellow;
        }

        private void BtRed_Click(object sender, RoutedEventArgs e)
        {
            TbR.Background = Brushes.Red;
            TbGr.Background = Brushes.Gray;
            TbYe.Background = Brushes.Gray;
        }

        private void BtGr_Click(object sender, RoutedEventArgs e)
        {
            TbR.Background = Brushes.Gray;
            TbGr.Background = Brushes.Green;
            TbYe.Background = Brushes.Gray;
        }
    }
}
