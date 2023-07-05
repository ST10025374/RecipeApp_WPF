using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFdemo
{
    public class RecipeClass
    {
        /// <summary>
        /// Variable to store Recipe Name
        /// </summary>
        public string RecipeName { get; set; }

        /// <summary>
        /// Store Recipe Steps Descriptions
        /// </summary>
        public List<string> StepDescriptionsList = new List<string>();

        /// <summary>
        /// Store Recipe Ingredients
        /// </summary>
        public List<IngredientsClass> IngredientsList = new List<IngredientsClass>();

        //---------------------------------------------------------------------------------------//
        /// <summary>
        /// Default Constructor
        /// </summary>
        public RecipeClass() 
        {
            
        }

        //---------------------------------------------------------------------------------------//
        /// <summary>
        /// Parametized Constructor
        /// </summary>
        /// <param name="recipeName"></param>
        /// <param name="recipeStepNum"></param>
        /// <param name="recipeDescription"></param>
        public RecipeClass(string recipeName, List<string> stepDescriptionsList,
            List<IngredientsClass> ingredientsList)
        {
            this.RecipeName = recipeName;
            this.StepDescriptionsList = stepDescriptionsList;
            this.IngredientsList = ingredientsList;
        }
    }
}
