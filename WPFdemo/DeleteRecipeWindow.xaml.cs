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
using System.Windows.Shapes;

namespace WPFdemo
{
    /// <summary>
    /// Interaction logic for DeleteRecipeWindow.xaml
    /// </summary>
    public partial class DeleteRecipeWindow : Window
    {
        public DeleteRecipeWindow(List<RecipeClass> _recipes)
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------//
        /// <summary>
        /// Delete Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //
        }
    }
}
//---------------------------------------< END >---------------------------------------//