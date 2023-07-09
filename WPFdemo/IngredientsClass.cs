using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFdemo
{
        public class IngredientsClass
        {
            /// <summary>
            /// Store the number of ingredients of each recipe
            /// </summary>
            public int NumberOfIngredients { get; set; } = 0;

            /// <summary>
            /// Store Ingredient Name
            /// </summary>
            public string IngredientName { get; set; } = string.Empty;

            /// <summary>
            /// Store Ingredient Quantity
            /// </summary>
            public double IngredientQuantity { get; set; } = 0.0;
            
            /// <summary>
            /// Store Ingredient Unit Of Measurement
            /// </summary>
            public string UnitOfMeasurement { get; set; } = string.Empty;

            /// <summary>
            /// Store Ingredient number of Calories
            /// </summary>
            public int IngredientCalories { get; set; } = 0;

            /// <summary>
            /// Store Ingredient Food Group
            /// </summary>
            public string IngredientFoodGroup { get; set; } = string.Empty;
            
            //---------------------------------------------------------------------------------------//
            /// <summary>
            /// Default Constructor
            /// </summary>
            public IngredientsClass()
            {

            }

            //---------------------------------------------------------------------------------------//
            /// <summary>
            /// Parameterized constructor
            /// </summary>
            /// <param name="numberOfIngredients"></param>
            /// <param name="ingredientName"></param>
            /// <param name="ingredientQuantity"></param>
            /// <param name="unitOfMeasurement"></param>
            /// <param name="ingredientCalories"></param>
            /// <param name="ingredientFoodGroup"></param>
            public IngredientsClass(int numberOfIngredients, string ingredientName, double ingredientQuantity, string unitOfMeasurement, int ingredientCalories, string ingredientFoodGroup)
            {
                NumberOfIngredients = numberOfIngredients;
                IngredientName = ingredientName;
                IngredientQuantity = ingredientQuantity;
                UnitOfMeasurement = unitOfMeasurement;
                IngredientCalories = ingredientCalories;
                IngredientFoodGroup = ingredientFoodGroup;
            }                        
        }
    }
//---------------------------------------------------------< END >-----------------------------------------------------//

