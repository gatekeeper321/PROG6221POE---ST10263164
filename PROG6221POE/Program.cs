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
        static void Main(string[] args)
        {
            string option = " ";
            
            Console.WriteLine("Welcome to the Cooking Helper!"); //menu
            Console.WriteLine("Please select an option below");
            Console.WriteLine("1) Create a new recipe");
            Console.WriteLine("2) View Recipe");
            Console.WriteLine("3) ");
            Console.WriteLine("4) EXIT");

            option = Console.ReadLine();

            if (option == "1") 
            {

            }
            else if (option == "2") 
            {

            }
            else if (option == "3") 
            {

            }
            else if(option == "4") 
            {
                System.Environment.Exit(0); //https://www.c-sharpcorner.com/UploadFile/c713c3/how-to-exit-in-C-Sharp/
            }
            else 
            {

            }

 
        }

        private string CreateRecipe()
        {
            string recipe = "";
            string ingredient = "";
            double amount = 0;



            return "Recipe recorded!"; 
        }

        private string ViewRecipe()
        {
            string recipe = "";

            return recipe;
        }

    }
}
