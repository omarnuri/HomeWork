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
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Windows.Media.Animation;
using System.Collections.ObjectModel;

using System.Text.RegularExpressions;
using System.Collections.Specialized;
namespace Exam_WPF.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для WorkSpace_Window.xaml
    /// </summary>
    public partial class WorkSpace_Window : Window, IWorkSpaceView
    {

       
        public User User { get; set; }
        public WorkSpace_Window(User user)
        {
            InitializeComponent();
            DataContext = this;
            User = user;
            HelloText.Text = $"Welcome {user.Name}!";
            OrderProductDatePicker.DisplayDateStart = DateTime.Now;
        }

        public event EventHandler<EventArgs> WorkSpaceLoguot;
        public event EventHandler<ClientAddEventArgs> ClientAdd;
        public event EventHandler<ClientLoadEventArgs> ClientLoadEvent;
        public event EventHandler<ProductAddEventArgs> ProductAdd;
        public event EventHandler<EventArgs> ProductLoadEvent;
        public event EventHandler<OrderAddEventArgs> OrderAdd;
        public event EventHandler<OrderLoadEventArgs> OrderLoadEvent;

        bool IsFindAnimCalled = false;
        public IEnumerable<Client> Clients => clients;
        readonly private  ICollection<Client> clients = new ObservableCollection<Client> { };
        public IEnumerable<Product> Products => products;
        readonly private ICollection<Product> products = new ObservableCollection<Product> { };
        public IEnumerable<Order> Orders => orders;
        readonly private ICollection<Order> orders = new ObservableCollection<Order> { };

        public string selected_string;

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            Application.Current.Shutdown();

        }
        private void MenuLogOut_Click(object sender, RoutedEventArgs e)
        {
            WorkSpaceLoguot?.Invoke(this, EventArgs.Empty);
        }

        private void MenuItemClient_Click(object sender, RoutedEventArgs e)
        {
            if (!IsFindAnimCalled)
            {
                FindElemBorder.Visibility = Visibility.Visible;
                (TryFindResource("MenuFieldFindAnim") as Storyboard).Begin();
                IsFindAnimCalled = true;
            }
            input_field.Width = new GridLength(2, GridUnitType.Star);
            show_field.Width = new GridLength(1, GridUnitType.Star);
            HideInputElements();
            input_ClientField.Visibility = Visibility.Visible;
            HideShowElements();
            show_field_Clients.Visibility = Visibility.Visible;


        }
        private void MenuItemProduct_Click(object sender, RoutedEventArgs e)
        {
            if (!IsFindAnimCalled)
            {
                FindElemBorder.Visibility = Visibility.Visible;
                (TryFindResource("MenuFieldFindAnim") as Storyboard).Begin();
                IsFindAnimCalled = true;
            }
            input_field.Width = new GridLength(2, GridUnitType.Star);
            show_field.Width = new GridLength(1, GridUnitType.Star);
            HideInputElements();
            input_ProductField.Visibility = Visibility.Visible;
            HideShowElements();
            show_field_Product.Visibility = Visibility.Visible;


        }
        private void HideShowElements()
        {

            for (int i = 0; i < show_field_Elements.Children.Count; i++)
            {
                if (show_field_Elements.Children[i] is Grid && show_field_Elements.Children[i]!=null)
                {
                    if ((show_field_Elements.Children[i] as Grid).Visibility == Visibility.Visible)
                    {
                        (show_field_Elements.Children[i] as Grid).Visibility = Visibility.Hidden;
                    }
                }
            }
        }
        private void HideInputElements()
        {
            for (int i = 0; i < input_field_Elements.Children.Count; i++)
            {
                if ((input_field_Elements.Children[i] as Grid).Visibility == Visibility.Visible)
                {
                    (input_field_Elements.Children[i] as Grid).Visibility = Visibility.Hidden;
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            (TryFindResource("MenuFieldWidtAnim") as Storyboard).Begin();
            ClientLoadEvent?.Invoke(this, new(User));
            ProductLoadEvent?.Invoke(this, EventArgs.Empty);
            OrderLoadEvent?.Invoke(this, new(User));
           


        }
        public void LoadClient(ICollection<Client> _clients)
        {
            if (_clients != null)
            {
                foreach (var item in _clients)
                {
                    clients.Add(item);
                }
            }
        }
        private void MenuAnim_Completed(object sender, EventArgs e)
        {
            (TryFindResource("HelloTextOpacityEnd") as Storyboard).Begin();
        }

        private void MenuItemOrder_Click(object sender, RoutedEventArgs e)
        {
            if (!IsFindAnimCalled)
            {
                FindElemBorder.Visibility = Visibility.Visible;
                (TryFindResource("MenuFieldFindAnim") as Storyboard).Begin();
                IsFindAnimCalled = true;
            }
            input_field.Width = new GridLength(2, GridUnitType.Star);
            show_field.Width = new GridLength(1, GridUnitType.Star);
            HideInputElements();
            input_OrderField.Visibility = Visibility.Visible;
            HideShowElements();
            show_field_Order.Visibility = Visibility.Visible;

        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            Changed(sender);
        }
        public int Current_Input()
        {
            for (int i = 0; i < input_field_Elements.Children.Count; i++)
            {
                if ((input_field_Elements.Children[i] as Grid).Visibility == Visibility.Visible)
                {
                    return i;
                }
            }
            return -1;
        }
        private void DateChanged(object sender, SelectionChangedEventArgs e)
        {
            Changed(sender);
        }
        private void Changed(object sender)
        {
            if (Current_Input() != -1)
            {
                int i = 0;
                bool IsEnabled = true;
                foreach (var item in (((input_field_Elements.Children[Current_Input()] as Grid).Children[0]) as StackPanel).Children)
                {
                    i++;

              
                    if (item is ComboBox)
                    {
                        if ((item as ComboBox).SelectedIndex == -1)
                        {
                            IsEnabled = false;
                        }
                    }
                    else if (item is DatePicker)
                    {
                        if ((item as DatePicker).Text == string.Empty)
                        {
                            IsEnabled = false;
                        }
                    }
                    else if (item is TextBox)
                    {
                        if ((item as TextBox).Text == string.Empty)
                        {
                            IsEnabled = false;
                        }
                    }
              
                    else if (item is Button)
                    {
                        (FindName((item as Button).Name) as Button).IsEnabled = IsEnabled;
                    }
                    
                }

            }
        }

        private void ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            Changed(sender);
        }

        private void PreviewTextInput_OnlyValue(object sender, TextCompositionEventArgs e)
        {

            Regex regex = new Regex("^[0-9]*[.,][0-9]+$");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void ClientAddButton_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client();
            client.Name = ClientNameTextBox.Text;
            client.SureName = ClientSureNameTextBox.Text;
            client.Email = ClientEmailTextBox.Text;
            client.PhoneNumber = ClientPhoneNumber.Text;
            client.Adress = ClientAdressTextBox.Text;
            ClientListBoxClear();    
            ClientAdd?.Invoke(this, new(User, client));
            clients.Add(client);

        }
        private void ClientListBoxClear()
        {
            ClientNameTextBox.Clear();
            ClientSureNameTextBox.Clear();
            ClientEmailTextBox.Clear();
            ClientPhoneNumber.Clear();
            ClientAdressTextBox.Clear();
        }

      

        public void LoadProduct(ICollection<Product> _products)
        {
            foreach (var item in _products)
            {
                products.Add(item);
            }
        }
        public void LoadOrder(ICollection<Order> _orders)
        {
            foreach (var item in _orders)
            {
                orders.Add(item);
            }
        }

        private void ProductAddButton_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.Name = ProductNameTextBox.Text;
            product.Price = Convert.ToDecimal(ProductPriceTextBox.Text);
            product.Count = Convert.ToInt32(ProductCountTextBox.Text);
            product.Description = ProductDescriptionTextBox.Text;
            ProductAdd?.Invoke(this, new(product));
            products.Add(product);

        }

        private void OrderAddButton_Click(object sender, RoutedEventArgs e)
        {
            Order order = new();
            order.ProductName = (OrderProductNameComboBox.SelectedItem as Product).Name;
            order.ClientName = (OrderClientNameComboBox.SelectedItem as Client).Name;
            order.Date = Convert.ToDateTime(OrderProductDatePicker.SelectedDate).ToString("yyyy - MM - dd");
            order.Count = Convert.ToInt32(OrderProductCountTextBox.Text);
         
            OrderAdd?.Invoke(this, new(User, order));
            orders.Add(order);
        }

        private void FindField_GotFocus(object sender, RoutedEventArgs e)
        {
            if (FindField.Text == "Find")
            {
                FindField.Opacity = 1;
                FindField.Text = string.Empty;
                FindField.HorizontalAlignment = HorizontalAlignment.Left;
                FindField.Focus();
            }
        }

        private void FindField_LostFocus(object sender, RoutedEventArgs e)
        {
            if (FindField.Text == "")
            {
                FindField.Text = "Find";
                FindField.Opacity = 0.5;
                FindField.HorizontalAlignment = HorizontalAlignment.Center;
            }
      
            
        }
    }
}
