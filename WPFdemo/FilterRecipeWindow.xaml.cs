using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFdemo
{   
    /// <summary>
    /// Interaction logic for FilterRecipeWindow.xaml
    /// </summary>
    public partial class FilterRecipeWindow : Window
    {
        /// <summary>
        /// RecipeBook Object
        /// </summary>
        private List<RecipeClass> _recipes;

        //-----------------------------------------------------------//
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="book"></param>
        public FilterRecipeWindow(List<RecipeClass> book)
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

        //-----------------------------------------------------------//
        /// <summary>
        /// Button to Filter Recipe By Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilterRecipe_Click(object sender, RoutedEventArgs e)
        {          
            string RecName = txtRecipeName.Text;

            string FoodGroup = ComboBoxFoodGroup.Text;

            lstRecipeList.Items.Clear();
          
            for (int i = 0; i < _recipes.Count; i++)
            {
                if (RecName.Equals(_recipes[i].RecipeName))
                {
                    int number = i + 1;
                    string ouput = number + ": " + _recipes[i].RecipeName;
                    lstRecipeList.Items.Add(ouput);
                }
                else if (!RecName.Equals(_recipes[i].RecipeName))
                {
                    for (int j = 0; j < _recipes[i].IngredientsList.Count; j++)
                    {
                        if (FoodGroup.Equals(_recipes[i].IngredientsList[j].IngredientFoodGroup))
                        {
                            int number = i + 1;
                            string ouput = number + ": " + _recipes[i].RecipeName;
                            lstRecipeList.Items.Add(ouput);
                        }
                    }
                }
            }
        }
    }
}
//--------------------------------------< END >----------------------------------------//