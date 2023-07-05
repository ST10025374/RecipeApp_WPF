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

namespace WPFdemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //-------------------------------------------------------------------//
        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Store Recipe Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StoreRecipe_Click(object sender, RoutedEventArgs e)
        {
            StoreRecipeWindow storeRecipeWindow = new StoreRecipeWindow();
            storeRecipeWindow.Show();
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Display Recipe Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayRecipe_Click(object sender, RoutedEventArgs e)
        {
            DisplayRecipeWindow displayRecipeWindow = new DisplayRecipeWindow();
            displayRecipeWindow.Show();
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Scale Up Recipe Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScaleUpRecipe_Click(object sender, RoutedEventArgs e)
        {
            ScaleUpRecipeWindow scaleUpRecipeWindow = new ScaleUpRecipeWindow();
            scaleUpRecipeWindow.Show();
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Delete Recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DeleteRecipe_Click(object sender, RoutedEventArgs e)
        {
            DeleteRecipeWindow deleteRecipeWindow = new DeleteRecipeWindow();
            deleteRecipeWindow.ShowDialog();
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Filter Recipe Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterRecipes_Click(object sender, RoutedEventArgs e)
        {
            //FilterRecipesWindow filterRecipesWindow = new FilterRecipesWindow();
            //filterRecipesWindow.Show();
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Create Menu Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateMenu_Click(object sender, RoutedEventArgs e)
        {
            //CreateMenuWindow createMenuWindow = new CreateMenuWindow();
            //createMenuWindow.Show();
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Exit Program Option Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
//-----------------------------------------< END >--------------------------------------//