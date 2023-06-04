using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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

namespace DB_Add_Delete
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
        private void ShowDataButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new AppDbContext())
            {
                int animalCount = int.Parse(AnimalCountTextBox.Text);

                var animalsQuery = db.Animals.Take(animalCount);
                var animals = animalsQuery.ToList();

                DataGridAnimals.ItemsSource = animals;
            }
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new AppDbContext())
            {
                string species = SpeciesTextBoxFind.Text;

                var animalsQuery = db.Animals.Where(a => a.Species == species);
                var animals = animalsQuery.ToList();

                DataGridAnimals.ItemsSource = animals;
            }
        }


     


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new AppDbContext())
            {
                string name = NameTextBoxAdd.Text;
                string species = SpeciesTextBoxAdd.Text;
                int age = int.Parse(AgeTextBoxAdd.Text);

                var newAnimal = new Animal { Name = name, Species = species, Age = age };

                db.Animals.Add(newAnimal);
                db.SaveChanges();

                
                ShowDataButton_Click(sender, e);
            }
        }





    }
}
