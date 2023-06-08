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
using WpfVending.Utils;

namespace WpfVending.Windows
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Transactions.ItemsSource = TransactionListUtil.transactions;
            
            Products.ItemsSource = ProductListUtil.products;
            Products.Columns[0].Visibility = Visibility.Hidden;
            Products.Columns[4].Visibility = Visibility.Hidden;
        }
    }
}
