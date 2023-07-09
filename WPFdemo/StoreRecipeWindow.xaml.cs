using System.Collections.Generic;
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
        /// Variable to store Recipe Name
        /// </summary>
        public string RecipeName { get; set; }

        /// <summary>
        /// Variable to store Recipe Ingredient Name
        /// </summary>
        public string RecipeIngName { get; set; }

        /// <summary>
        /// Stores amount of ingredients
        /// </summary>
        public int RecipeIngNum { get; set; }

        /// <summary>
        /// Store Recipe Ingredient unit of Measurement
        /// </summary>
        public string RecipeIngUnit { get; set; }

        /// <summary>
        /// Store Recipe ingredient Quantity
        /// </summary>
        public int RecipeIngQuantity { get; set; }

        /// <summary>
        /// Store Recipe ingredient Food Ground
        /// </summary>
        public string RecipeIngFoodGroup { get; set; }

        /// <summary>
        /// Store recipe Ingredients Calories number
        /// </summary>
        public int RecipeIngCalories { get; private set; }

        /// <summary>
        /// Store Recipe Num of Steps
        /// </summary>
        public int RecipeStepsNum { get; set; }

        /// <summary>
        /// Store Recipe Step Description
        /// </summary>
        public string RecipeStepDescription { get; set; }

        /// <summary>
        /// Store currnt recipe step to display in label
        /// </summary>
        public int LabelDisplayStepNum = 1;
      
        /// <summary>
        /// List to store details of each ingredient in recipe
        /// </summary>
        public List<IngredientsClass> IngredientsList = new List<IngredientsClass>();

        /// <summary>
        /// List to store recipe Steps Descriptions
        /// </summary>
        public List<string> StepList = new List<string>();

        /// <summary>
        /// Recipe Object
        /// </summary>
        public RecipeClass RecipeObj = new RecipeClass();

        /// <summary>
        /// Default Constructor
        /// </summary>
        public StoreRecipeWindow()
        {
            InitializeComponent();
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
        /// Delete Recipe Window
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

        //-------------------------------------------------------------------//
        /// <summary>
        /// Recipe Name TextBox Changed event
        /// Input Validation Implemented
        /// Method Gets Text from TextBox to Save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxChangedRecipeName(object sender, TextChangedEventArgs e)
        {
            // Get the current text from the TextBox
            string recipeName = txtRecipeName.Text;

            // Perform validation
            if (string.IsNullOrWhiteSpace(recipeName))
            {
                MessageBox.Show("Recipe name cannot be empty.");
            }
            else
            {
                // Valid input, do something with the recipe name
                this.RecipeName = recipeName;
            }
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Recipe Name TextBox Changed event
        /// Input Validation Implemented
        /// Method makes label for ingrdients to change
        /// Method Validates Input and displays error message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIngredientNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            //int ingredientNum = int.Parse(txtIngredient.Text);

            //New code
            if (int.TryParse(txtIngredient.Text, out int ingredientNum))
            {
                // Update the label based on the ingredient number
                if (ingredientNum == 0 && !string.IsNullOrEmpty(txtIngredient.Text) && !int.TryParse(txtIngredient.Text, out _))
                {
                    lblMessage.Content = "0";
                }
                else
                {
                    lblMessage.Content = $"{ingredientNum}";

                    SaveIngredientNum(ingredientNum);
                }
            }
            else
            {
                //lblMessage.Content = "Invalid ingredient number.";
                MessageBox.Show("Invalid ingredient number.");
            }

            //Old code
            // Update the label based on the ingredient text
           /* if (string.IsNullOrEmpty(ingredientNum))
            {
                lblMessage.Content = "0";
            }
            else
            {
                lblMessage.Content = $"{ingredientNum}";

                SaveIngredientNum(ingredientNum);

            } */
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Method Saves Number of Ingredients Selected by User
        /// </summary>
        /// <param name="IngNum"></param>
        public void SaveIngredientNum(int IngNum)
        {
            this.RecipeIngNum = IngNum;
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Store Unit of meauserement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cmdBoxUnit(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            if (selectedItem != null)
            {
                this.RecipeIngUnit = selectedItem.Content.ToString();
            }
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Store Ing Quantity
        /// Input Validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxQuantityTextChange(object sender, TextChangedEventArgs e)
        {      
            if (int.TryParse(txtBoxQuantity.Text, out int ingredientQuantity))
            {
                this.RecipeIngQuantity = int.Parse(txtBoxQuantity.Text);
            }
            else
            {               
                MessageBox.Show("Invalid ingredient quantity.");
            }
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Recipe Ing Calories
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxCaloriesTextChange(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(txtBoxCalories.Text, out int ingredientCalories))
            {
                this.RecipeIngCalories = int.Parse(txtBoxCalories.Text);
            }
            else
            {
                MessageBox.Show("Invalid ingredient calorie");
            }
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Store Ing Food Group
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdFoodGroup(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedValue = comboBox.SelectedItem as string;

            if (selectedValue != null)
            {
                this.RecipeIngFoodGroup = selectedValue;
            }
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
            IngredientsClass NewIngredient = new IngredientsClass();

            NewIngredient.IngredientName = this.RecipeIngName;

            NewIngredient.UnitOfMeasurement = this.RecipeIngUnit;

            NewIngredient.IngredientQuantity = this.RecipeIngQuantity;

            NewIngredient.IngredientCalories = this.RecipeIngCalories;

            NewIngredient.IngredientFoodGroup = this.RecipeIngFoodGroup;

            IngredientsList.Add(NewIngredient);
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Store Steps Num
        /// Input Validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtStepsNumTextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(txtBoxStepsNum.Text, out int recipeStep))
            {
                this.RecipeStepsNum = int.Parse(txtBoxStepsNum.Text);

                if (this.RecipeStepsNum == 0 && !string.IsNullOrEmpty(txtIngredient.Text) && !int.TryParse(txtIngredient.Text, out _))
                {
                    lblStepMessage.Content = "0";
                }
                else
                {
                    lblStepMessage.Content = $"{this.LabelDisplayStepNum}";
                }
            }
            else
            {
                MessageBox.Show("Invalid Step number");
            }
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
            this.LabelDisplayStepNum++;

            lblStepMessage.Content = $"{this.LabelDisplayStepNum}";

            txtBoxDescription.Text = string.Empty;      //Clear txtBox

            string Description = this.RecipeStepDescription;

            this.StepList.Add(Description);
        }

        //-------------------------------------------------------------------//
        /// <summary>
        /// Stores Description of Step
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_DescriptionTextChanged(object sender, TextChangedEventArgs e)
        {
            this.RecipeStepDescription = txtBoxDescription.Text.ToString();
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

            NewRecipeObj.RecipeName = this.RecipeName;
            NewRecipeObj.StepDescriptionsList = this.StepList;
            NewRecipeObj.IngredientsList = this.IngredientsList;

            this.RecipeObj.RecipeList.Add(NewRecipeObj);
        }
    }
}
//-----------------------------------------< END >--------------------------------------//    