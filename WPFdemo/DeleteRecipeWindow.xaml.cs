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
    /// Interaction logic for DeleteRecipeWindow.xaml
    /// </summary>
    public partial class DeleteRecipeWindow : Window
    {
        /// <summary>
        /// RecipeBook Object
        /// </summary>
        private List<RecipeClass> _recipes;

        //----------------------------------------------------------------//
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="_recipes"></param>
        public DeleteRecipeWindow(List<RecipeClass> book)
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

        //----------------------------------------------------------------//
        /// <summary>
        /// Delete Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            int RecNum = int.Parse(txtRecipeNum.Text);

            if (RecNum > 0 && RecNum <= _recipes.Count)
            {
                _recipes.RemoveAt(RecNum - 1);

                MessageBox.Show("Recipe Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Recipe number does not exist");
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
        /// Allow only numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRecipeNum_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
//---------------------------------------< END >---------------------------------------//