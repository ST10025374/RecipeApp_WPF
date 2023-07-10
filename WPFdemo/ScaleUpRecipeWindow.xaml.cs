using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;

namespace WPFdemo
{
    /// <summary>
    /// Interaction logic for ScaleUpRecipeWindow.xaml
    /// </summary>
    public partial class ScaleUpRecipeWindow : Window
    {
        /// <summary>
        /// RecipeBook Object
        /// </summary>
        private List<RecipeClass> _recipes;

        //-----------------------------------------------------------//
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="_recipes"></param>
        public ScaleUpRecipeWindow(List<RecipeClass> book)
        {
            InitializeComponent();

            _recipes = book;

            //Sort Alphabetically
            _recipes.Sort((Recipe1, Recipe2) => string.Compare(Recipe1.RecipeName, Recipe2.RecipeName));

            for (int i = 0; i < _recipes.Count; i++)
            {
                int number = i + 1;
                string ouput = number + ": " + _recipes[i].RecipeName;
                lstRecipeList.Items.Add(ouput);
            }
        }

        //-----------------------------------------------------------//
        /// <summary>
        /// Button to Scale Up recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScaleUpRecipe_Click(object sender, RoutedEventArgs e)
        {
            int RecNum = int.Parse(txtRecipeNum.Text);

            double ScaleFactor = double.Parse(txtScaleUpFactor.Text);

            for (int i = 0; i < _recipes[RecNum - 1].IngredientsList.Count; i++)
            {
                int number = i + 1;

                string output = number + ": " + _recipes[RecNum - 1].IngredientsList[i].IngredientName
                       + " " + _recipes[RecNum - 1].IngredientsList[i].IngredientFoodGroup
                       + " " + (_recipes[RecNum - 1].IngredientsList[i].IngredientQuantity * ScaleFactor)
                       + " " + _recipes[RecNum - 1].IngredientsList[i].UnitOfMeasurement
                       + " Calories: " + _recipes[RecNum - 1].IngredientsList[i].IngredientCalories;

                lstRecipeScaleUp.Items.Add(output);;
            } 
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
        private void txtIngNum_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
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
