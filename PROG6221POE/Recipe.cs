// William McPetrie ST10263164 PROGPOE PART 1

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
        public string CreateRecipe(string[] ingredients, double[] amounts, string[] measurements, string[] steps) 
        {
            string input = "";

            for (int i = 0; i < ingredients.Length; i++) 
            {
                Console.WriteLine("Please enter the name of ingredient " + (i+1));
                ingredients[i] = Console.ReadLine();

                Console.WriteLine("Please enter the quantity of that ingredient");
                amounts[i] = int.Parse(Console.ReadLine()); // int parse converts string to int

                Console.WriteLine("Please choose a measurement type\n1) Millileters\n2) Teaspoons\n3) Tablespoons\n4) Cups\n5) Whole (for whole items like eggs)");
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

        public string ViewRecipe(string recipeName, string[] ingredients, double[] amounts, string[] measurements, string[] steps) 
        {
            string recipe;
            recipe = "\t" + recipeName;
            recipe = recipe + "\n\nIngredients needed\n";
            for (int i = 0; i < ingredients.Length; i++) 
            {
                recipe = recipe + "\n" + ingredients[i] + "\t" + amounts[i] + " " + measurements[i];
            }

            recipe = recipe + "\n";

            for (int i = 0; i < steps.Length; i++)
            {
                recipe = recipe + "\n\tSTEP " + i + "\n" + steps[i];
            }
            recipe = recipe + "\n-------------------------------------------------------------------------------------------------------";

            return recipe;
        }

        public string ScaleRecipe(double[] amounts, string[] measurements) 
        {
            double scale = 1;
            bool chooseScale = false;

            while (!chooseScale)
            {
                Console.WriteLine("please select one of the following scaling options:\n1) 0.5\n2) 2\n3) 3"); //scale options
                if (Console.ReadLine() == "1") 
                {
                    scale = 0.5;
                    chooseScale = true;
                }
                else if (Console.ReadLine() == "2") 
                {
                    scale = 2;
                    chooseScale = true;
                }
                else if(Console.ReadLine() == "3") 
                {
                    scale = 3;
                    chooseScale = true;
                }
            }

            for (int i = 0; i < amounts.Length; i++) 
            {
                amounts[i] = amounts[i] * scale; // sets new scale

                if (amounts[i] >= 3 && measurements[i] == "Teaspoons") // if statement changes measurements from teaspoons to tablespoons to cups and back if nescesary
                {
                    amounts[i] = amounts[i] / 3;
                    measurements[i] = "Tablespoons";
                }
                else if (amounts[i] >= 16 && measurements[i] == "Tablespoons")
                {
                    amounts[i] = amounts[i] / 16;
                    measurements[i] = "Cups";
                }
                else if (amounts[i] < 1 && measurements[i] == "Tablespoons")
                {
                    amounts[i] = amounts[i] * 3;
                    measurements[i] = "Teaspoons";
                }
                else if (amounts[i] < 1 && measurements[i] == "Cups")
                {
                    amounts[i] = amounts[i] * 16;
                    measurements[i] = "Tablespoons";
                }
                else { }
            }

       
            return "Successfully scaled recipe";
        }

        public string EraseRecipe(string recipeName, string[] ingredients, double[] amounts, string[] measurements, string[] steps) //all values are set to null so they may be ready for a new recipe
        {
            recipeName = null;
            ingredients = null;
            amounts = null;
            measurements = null;
            steps = null;

            return "Succesfully erased Recipe";
        }


    }
}
