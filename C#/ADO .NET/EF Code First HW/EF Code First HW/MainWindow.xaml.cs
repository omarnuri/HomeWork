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
using EF_Code_First_HW.Context;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace EF_Code_First_HW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using var dbContext = new ShopDBContext();
            if (!dbContext.Database.Exists())
            {
                dbContext.Database.Create();
            }

            Elements.ItemsSource = dbContext.Items.ToList();




        }

    

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Item item = new Item();
            item.Name = txtProductName.Text;
            item.Property = txtProductProperty.Text;
            using var dbContext = new ShopDBContext();
            dbContext.Items.Add(item);
            dbContext.SaveChanges();    
            Elements.ItemsSource = dbContext.Items.ToList();
            
            
        }
    }
}