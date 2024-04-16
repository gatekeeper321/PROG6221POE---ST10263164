using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221POE
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool bMenu = true;
            string recipeName = "";
            string[] ingredients = null; //arrays are instantiated as null so their size can be altered later on
            double[] amounts = null;
            string[] measurements = null;
            string[] steps = null;

            while (bMenu == true) //having while loop allows menu to redisplay when finsihed with a specific task
            {
                string option = Program.DisplayMenu();

                if (option == "1") //CREATE RECIPE
                {
                    Console.WriteLine("Please enter the name of this recipe");
                    recipeName = Console.ReadLine();

                    Console.WriteLine("Please enter the number of ingredients in this recipe");
                    int arraySize = int.Parse(Console.ReadLine());
                    ingredients = new string[arraySize]; //setting size of arrays that user set
                    amounts = new double[arraySize];
                    measurements = new string[arraySize];

                    Console.WriteLine("Please enter the number of steps in this recipe");
                    int arrayStepsSize = int.Parse(Console.ReadLine());
                    steps = new string[arrayStepsSize]; // sets size of array to number of steps there will be

                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                    Recipe recipe = new Recipe(); //instatntiates recipe class
                    recipe.CreateRecipe(ingredients, amounts, measurements, steps);

                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                }
                else if (option == "2")
                {
                    Recipe recipe = new Recipe();
                    Console.WriteLine(recipe.ViewRecipe(recipeName, ingredients, amounts, measurements, steps));
                }
                else if (option == "3")
                {
                    Recipe recipe = new Recipe();
                    recipe.ScaleRecipe(amounts, measurements);
                }
                else if (option == "4") 
                {
                    Recipe recipe = new Recipe();
                    recipe.EraseRecipe(recipeName, ingredients, amounts, measurements, steps);
                }

            }  
        }

        public static string DisplayMenu() //menu
        {
            string option = "";
            bool validOption= false;

            while (validOption == false) // while loop allows code to loop until a valid input is entered
            {
                Console.WriteLine("Welcome to the Cooking Helper!\nPlease select an option below:\n1) Create a new recipe\n2) View Recipe\n3)Scale Recipe\n4)Erase Recipe\n5) EXIT");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                option = Console.ReadLine();

                if (option == "1" || option == "2" || option == "3" || option == "4")
                {
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                    validOption = true; // ends loop once valid option is chosen
                }
                else if (option == "5")
                {
                    System.Environment.Exit(0); //https://www.c-sharpcorner.com/UploadFile/c713c3/how-to-exit-in-C-Sharp/
                }
                else
                {
                    Console.WriteLine("Invalid input... Please enter either 1,2,3 or 4");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                }
            }
            return option;
        }

    }
}
