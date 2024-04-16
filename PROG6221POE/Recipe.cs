using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221POE
{
    internal class Recipe
    {
        public string CreateRecipe(string[] ingredients, int[] amounts, string[] measurements, string[] steps) 
        {
            string input = "";

            for (int i = 0; i < ingredients.Length; i++) 
            {
                Console.WriteLine("Please enter the name of ingredient " + (i+1));
                ingredients[i] = Console.ReadLine();


                Console.WriteLine("Please enter the quantity of that ingredient");
                amounts[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Please choose a measurement type\n1) Millileters\n2) Teaspoons\n3) Tablespoons\n4) Cups\n5) Whole(for whole items like eggs)");
                input = Console.ReadLine();
                if (input == "1")
                {
                    measurements[i] = "Millileters";
                }
                else if (input == "2")
                {
                    measurements[i] = "Teaspoons";
                }
                else if (input == "3")
                {
                    measurements[i] = "Tablespoons";
                }
                else if (input == "4")
                {
                    measurements[i] = "Cups";
                }
                else if (input == "5")
                {
                    measurements[i] = "Whole";
                }
                else 
                {
                    //invalid input
                }

                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            }

            for (int i = 0; i < steps.Length; i++) 
            {
                Console.WriteLine("Please type out step number " + (i+1));
                steps[i] = Console.ReadLine();

                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            }


                return "Well done! Recipe successfully created!\n-------------------------------------------------------------------------------------------------------";
        }

        public string ViewRecipe(string recipeName, string[] ingredients, int[] amounts, string[] measurements, string[] steps) 
        {
            string recipe;
            recipe = "\t" + recipeName;
            recipe = recipe + "\nIngredients needed";
            for (int i = 0; i < ingredients.Length; i++) 
            {
                recipe = recipe + "\n" + ingredients[i] + "\t" + amounts[i] + " " + measurements[i];
            }
            for (int i = 0; i < steps.Length; i++)
            {
                recipe = recipe + "\nSTEP " + i + "\n" + steps[i];
            }
            recipe = recipe + "\n-------------------------------------------------------------------------------------------------------";

            return recipe;
        }


    }
}
