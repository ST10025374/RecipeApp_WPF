using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;

namespace WPFdemo
{
    /// <summary>
    /// Interaction logic for DisplayRecipeWindow.xaml
    /// </summary>
    public partial class DisplayRecipeWindow : Window
    {

        /// <summary>
        /// RecipeBook Object
        /// </summary>
        private List<RecipeClass> _recipes;

        //-----------------------------------------------------------//
        /// <summary>
        /// Default Constructor
        /// </summary>
        public DisplayRecipeWindow(List<RecipeClass> book)
        {
            InitializeComponent();

            _recipes = book;

            //Sort Alphabetically
            _recipes.Sort((Recipe1, Recipe2) => string.Compare(Recipe1.RecipeName, Recipe2.RecipeName));

            for (int i = 0; i < _recipes.Count; i++)
            {
                int number = i + 1;
                string ouput = number + ": "+ _recipes[i].RecipeName;
                lstRecipeList.Items.Add(ouput);
            }
        }


        //-----------------------------------------------------------//
        /// <summary>
        /// Button to Display Recipe Selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisplayRecipeSelected_Click(object sender, RoutedEventArgs e)
        {
            int inputNumber = int.Parse(txtRecipeNum.Text);
            if (inputNumber > _recipes.Count)
            {
                MessageBox.Show("Recipe Not on List!","ERROR",MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var recipe = _recipes[inputNumber-1];

            DisplayOneRecipe displayOneRecipe = new DisplayOneRecipe(recipe, _recipes);
            displayOneRecipe.Show();
            Hide();
        }

        //-----------------------------------------------------------//
        /// <summary>
        /// Allow only numbers to be entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRecipeNum_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        //-----------------------------------------------------------//
        /// <summary>
        /// Open Main When Window Closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closed(object sender, System.EventArgs e)
        {
            MainWindow mainWindow = new MainWindow(_recipes);
            mainWindow.Show();
            Hide();
        }
    }
}
//--------------------------------------< END >----------------------------------------//