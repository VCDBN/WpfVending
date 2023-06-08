using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using WpfVending.Models;
using WpfVending.Utils;
using WpfVending.Windows;

namespace WpfVending
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Product? currentProduct = null;
        public MainWindow()
        {
            InitializeComponent();
            ProductListUtil.populateList();
            RenderProducts();
        }

        private void RenderProducts()
        {
            ItemsPanel.Children.Clear();

            int index = 0;
            StackPanel? nestedStackPanel = null;

            foreach (Product p in ProductListUtil.products)
            {

                if (index % 3 == 0)
                {
                    nestedStackPanel = new StackPanel
                    {
                        Orientation = Orientation.Horizontal,
                        Margin = new Thickness(5)
                    };
                    ItemsPanel.Children.Add(nestedStackPanel);
                }

                StackPanel singleItemPanel = new StackPanel();

                Image image = new Image
                {
                    Source = new BitmapImage(new Uri(p.Url)),
                    Height = 100,
                    Margin = new Thickness(5)

                };
                
                singleItemPanel.Children.Add(image);

                Label name = new Label
                {
                    Content = p.Name,
                    HorizontalAlignment= HorizontalAlignment.Center,
                    Margin = new Thickness(3),
                    Foreground = Brushes.White
            };
                singleItemPanel.Children.Add(name);

                Label price = new Label
                {
                    Content = "ZAR " + p.Price,
                    FontWeight= FontWeights.Bold,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin= new Thickness(3),
                    Foreground = Brushes.White
                };
                singleItemPanel.Children.Add(price);

                singleItemPanel.MouseDown += (sender, e) => image_Click(p, sender, e);
                nestedStackPanel.Children.Add(singleItemPanel);

                index++;
            }
        }

        private void DisplayProductDetails(Product p)
        {
            QtySelected.Text = "1";

            NameLabel.Content = "You have selected: \n" + p.Name;

            string allergensString = "Allergens: \n";

            if (p.Allergens.Count > 0)
            {
                foreach (string allergens in p.Allergens)
                {
                    allergensString += "- " + allergens + "\n";
                }

            } else
            {
                allergensString += "- None!!";
            }

            AllergensLabel.Content = allergensString;

            UpdatePrice(p.Price, 1);
        }

        private void image_Click(Product p, object sender, MouseButtonEventArgs e)
        {
            currentProduct = p;
            TransactionPanel.Visibility = Visibility.Visible;
            DisplayProductDetails(p);
        }


        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            ProcessTransaction();
            TransactionPanel.Visibility = Visibility.Hidden;
        }

        private void ProcessTransaction()
        {
            int newId = TransactionListUtil.transactions.Count;
            DateTime now = DateTime.Now;
            int qty = Convert.ToInt32(QtySelected.Text);
            double price = qty * currentProduct.Price;
            Transaction t = new Transaction(newId, now, currentProduct, qty, price);

            TransactionListUtil.transactions.Add(t);

            MessageBox.Show("Thank you for your purchase!");
        }

        private void DecreaseButton_Click(object sender, RoutedEventArgs e)
        {
            int currentValue = Convert.ToInt32(QtySelected.Text);
            if (currentValue != 0)
            {
                currentValue--;
                QtySelected.Text = currentValue.ToString();
            }
            UpdatePrice(currentProduct.Price, currentValue);
        }

        private void IncreaseButton_Click(object sender, RoutedEventArgs e)
        {
            int currentValue = Convert.ToInt32(QtySelected.Text);
            currentValue++;
            QtySelected.Text = currentValue.ToString();
            UpdatePrice(currentProduct.Price, currentValue);
        }

        private void UpdatePrice(double price, int qty)
        {
            PriceLabel.Content = "Price: ZAR " + (price * qty).ToString();
        }

        private void Admin_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow adminWindow = new AdminWindow();
            this.Hide();
            adminWindow.ShowDialog();
            RenderProducts();
            this.Show();
        }
    }
}
