using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace WPFdemo
{
    /// <summary>
    /// Interaction logic for StoreRecipeWindow.xaml
    /// </summary>
    public partial class StoreRecipeWindow : Window
    {
        /// <summary>
        /// Store current recipe step to display in label
        /// </summary>
        private int _stepNum = 1;

        /// <summary>
        /// List to store details of each ingredient in recipe
        /// </summary>
        private List<IngredientsClass> _ingredientsList;

        /// <summary>
        /// List to store recipe Steps Descriptions
        /// </summary>
        private List<string> _stepList;

        /// <summary>
        /// RecipeBook Object
        /// </summary>
        private List<RecipeClass> _recipes;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public StoreRecipeWindow(List<RecipeClass> book)
        {
            InitializeComponent();
            _ingredientsList = new List<IngredientsClass>();
            _stepList = new List<string>();
            _recipes = book;
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
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Delete Recipe Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DeleteRecipe_Click(object sender, RoutedEventArgs e)
        {
            DeleteRecipeWindow deleteRecipeWindow = new DeleteRecipeWindow(_recipes);
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

        //-------------------------------------------------------------------//
        /// <summary>
        /// Button to Save ingredient
        /// Event saves Object Ingredients in List for Ing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveIngredientDataClick(object sender, RoutedEventArgs e)
        {
            var ingredientName = txtIngName.Text;
            var unitOfMeasurement = ComboBoxUnit.Text;
            var ingredientQuantity = double.Parse(txtBoxQuantity.Text);
            var ingredientCalories = int.Parse(txtBoxCalories.Text);
            var ingredientFoodGroup = ComboBoxFoodGroup.Text;

            IngredientsClass NewIngredient = new IngredientsClass(ingredientName, ingredientQuantity, unitOfMeasurement, ingredientCalories, ingredientFoodGroup);
            _ingredientsList.Add(NewIngredient);
            DisplayIngrediants.Items.Add(NewIngredient.OutputString());

            //Clear txtBoxes
            txtIngName.Text = string.Empty;
            ComboBoxUnit.SelectedIndex = 0;
            txtBoxQuantity.Text = string.Empty;
            txtBoxCalories.Text = string.Empty;
            ComboBoxFoodGroup.SelectedIndex = 0;
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Button to Save Description
        /// Button when clicked also clears textbox
        /// Button Clears TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_SaveStepDescrClick(object sender, RoutedEventArgs e)
        {

            _stepList.Add(txtBoxDescription.Text);
            txtBoxDescription.Text = string.Empty;      //Clear txtBox
            _stepNum++;
            lblStepMessage.Content =_stepNum;
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Button to Save recipe details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveRecipeClick(object sender, RoutedEventArgs e)
        {            
            RecipeClass NewRecipeObj = new RecipeClass();

            NewRecipeObj.RecipeName = txtRecipeName.Text;
            NewRecipeObj.StepDescriptionsList = _stepList;
            NewRecipeObj.IngredientsList = _ingredientsList;

            _recipes.Add(NewRecipeObj);

            //Clear txt
            txtRecipeName.Text = string.Empty;
            txtIngName.Text = string.Empty;
            txtBoxQuantity.Text = string.Empty;
            txtBoxCalories.Text = string.Empty;
            txtBoxDescription.Text = string.Empty;

            //Reser Labels
            lblStepMessage.Content = "1";

            MainWindow mainWindow = new MainWindow(_recipes);
            mainWindow.Show();
            Hide();
        }

        //-----------------------------------------------------------//
        /// <summary>
        /// Allow only Numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxQuantity_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        //-----------------------------------------------------------//
        /// <summary>
        /// Allow only Numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxCalories_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
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
//-----------------------------------------< END >--------------------------------------//    