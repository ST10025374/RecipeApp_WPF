using System.Collections.Generic;
using System.Windows;

namespace WPFdemo
{
    /// <summary>
    /// Interaction logic for DisplayOneRecipe.xaml
    /// </summary>
    public partial class DisplayOneRecipe : Window
    {
        /// <summary>
        /// Recipe List
        /// </summary>
        private List<RecipeClass> _recipes;

        /// <summary>
        /// RecipeClass Objecj
        /// </summary>
        private RecipeClass _displayRecipe;

        //-----------------------------------------------------------//
        /// <summary>
        /// 
        /// </summary>
        /// <param name="recipe"></param>
        /// <param name="book"></param>
        public DisplayOneRecipe(RecipeClass recipe, List<RecipeClass> book)
        {
            InitializeComponent();
            _recipes = book;
            _displayRecipe = recipe;

            for (int i = 0; i < _displayRecipe.StepDescriptionsList.Count; i++)
            {
                int number = i + 1;
                lstSteps.Items.Add(number.ToString() + _displayRecipe.StepDescriptionsList[i]);
            }

            for (int i = 0; i < _displayRecipe.IngredientsList.Count; i++)
            {
                int number = i + 1;
                lstIngrediants.Items.Add(number.ToString() + _displayRecipe.IngredientsList[i].OutputString());
            }

        }

        //-----------------------------------------------------------//
        /// <summary>
        /// Exit Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closed(object sender, System.EventArgs e)
        {
            DisplayRecipeWindow displayRecipeWindow = new DisplayRecipeWindow(_recipes);
            displayRecipeWindow.Show();
            Hide();
        }
    }
}
