using System.Collections.Generic;
using System.Windows;

namespace WPFdemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// 
        /// </summary>
        private List<RecipeClass> _recipes;

        //-------------------------------------------------------------------//
        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            _recipes = new List<RecipeClass>();
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainWindow(List<RecipeClass> book)
        {
            InitializeComponent();
            _recipes = book;
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Store Recipe Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StoreRecipe_Click(object sender, RoutedEventArgs e)
        {
            StoreRecipeWindow storeRecipeWindow = new StoreRecipeWindow(_recipes);
            storeRecipeWindow.Show();
            Hide();
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Display Recipe Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayRecipe_Click(object sender, RoutedEventArgs e)
        {         
            DisplayRecipeWindow displayRecipeWindow = new DisplayRecipeWindow(_recipes);
            displayRecipeWindow.Show();
            Hide();
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Scale Up Recipe Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScaleUpRecipe_Click(object sender, RoutedEventArgs e)
        {
            ScaleUpRecipeWindow scaleUpRecipeWindow = new ScaleUpRecipeWindow(_recipes);
            scaleUpRecipeWindow.Show();
            Hide();
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Delete Recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DeleteRecipe_Click(object sender, RoutedEventArgs e)
        {
            DeleteRecipeWindow deleteRecipeWindow = new DeleteRecipeWindow(_recipes);
            deleteRecipeWindow.ShowDialog();
            Hide();
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