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
            /// <param name="ingredientName"></param>
            /// <param name="ingredientQuantity"></param>
            /// <param name="unitOfMeasurement"></param>
            /// <param name="ingredientCalories"></param>
            /// <param name="ingredientFoodGroup"></param>
            public IngredientsClass(string ingredientName, double ingredientQuantity,
                string unitOfMeasurement, int ingredientCalories, string ingredientFoodGroup)
            {
                IngredientName = ingredientName;
                IngredientQuantity = ingredientQuantity;
                UnitOfMeasurement = unitOfMeasurement;
                IngredientCalories = ingredientCalories;
                IngredientFoodGroup = ingredientFoodGroup;
            }

            //---------------------------------------------------------------------------------------//
            /// <summary>
            /// Return String Of Ing Details
            /// </summary>
            /// <returns></returns>
            public string OutputString()
            {
                return IngredientQuantity + " " + UnitOfMeasurement + " of " + IngredientName;
            }
        }
    }
//---------------------------------------------------------< END >-----------------------------------------------------//

