using System.Collections.Generic;
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
    }
}
//--------------------------------------< END >----------------------------------------//