using NyamNyam.Models;
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

namespace NyamNyam.Pages
{
    /// <summary>
    /// Логика взаимодействия для DishPage.xaml
    /// </summary>
    public partial class DishPage : Page
    {
        Dish curentDish = new Dish();
        public DishPage()
        {
           
            InitializeComponent();
            CMBcategory.ItemsSource = Manager.db.Categories.ToList();
            
            LVDishes.ItemsSource = Manager.db.Dishes.ToList();
        }

        private void LVDishes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void CMBcategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CMBcategory.SelectedIndex>=0)
            {
                List<Dish> currentDishes = Manager.db.Dishes.ToList();
                currentDishes = currentDishes.Where(x => x.Category1.CategoryName.Contains(CMBcategory.Text)).ToList();
                LVDishes.ItemsSource = null;
                LVDishes.ItemsSource = currentDishes;
            }
         }

        private void TBName_SelectionChanged(object sender, RoutedEventArgs e)
        {
            List<Dish> currentDishes = Manager.db.Dishes.ToList();
            currentDishes = currentDishes.Where(x => x.DishName.Contains(TBName.Text)).ToList();
            LVDishes.ItemsSource = null;
            LVDishes.ItemsSource = currentDishes;
        }
    }
}
