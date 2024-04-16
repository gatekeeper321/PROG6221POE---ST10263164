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
            string recipeName;
            while (bMenu == true) //having while loop allows menu to redisplay when finsihed with a specific task
            {
                string option = Program.DisplayMenu();

                if (option == "1")
                {
                    Console.WriteLine("Please enter the of this recipe");
                    recipeName = Console.ReadLine();

                    Console.WriteLine("Please enter the number of ingredients in this recipe");
                    int arraySize = int.Parse(Console.ReadLine());
                    string[] ingredients = new string[arraySize];
                    int[] amounts = new int[arraySize];
                    string[] measurements = new string[arraySize];

                    Console.WriteLine("Please enter the number of steps in this recipe");
                    int arrayStepsSize = int.Parse(Console.ReadLine());
                    string[] steps = new string[arrayStepsSize];

                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                    Recipe recipe = new Recipe();
                    recipe.CreateRecipe(ingredients, amounts, measurements, steps);

                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                }
                else if (option == "2")
                {
                    
                }

            }  
        }

        public static string DisplayMenu() //menu
        {
            string option = "";
            bool validOption= false;

            Console.WriteLine("Welcome to the Cooking Helper!\nPlease select an option below:\n1) Create a new recipe\n2) View Recipe\n3)\n4) EXIT");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            option = Console.ReadLine();

            while (validOption == false) 
            {
                if (option == "1" || option == "2" || option == "3")
                {
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                    validOption = true;
                }
                else if (option == "4")
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
