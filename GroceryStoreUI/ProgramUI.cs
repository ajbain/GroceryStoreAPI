using GroceryStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreUI
{
    public class ProgramUI
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        public void Run()
        {
            SeedContent();
            Menu();
        }
        private void SeedContent()
        {
            List<Ingredients> ingredients = new List<Ingredients>();
            List<Recipe> recipes = new List<Recipe>();
            List<Transaction> transactions = new List<Transaction>();
           

           
        }

        private void Menu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();

                Console.WriteLine("Enter the number of the option you'd like to select:\n" +
                    "1. Show all streaming content\n" +
                    "2. Find streaming content by title\n" +
                    "3. Add new streaming content\n" +
                    "4. Update existing streaming content\n" +
                    "5. Remove streaming content\n" +
                    "6. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        // Show all content
                        ShowAllContent();
                        break;
                    case "2":
                        //Get content by title
                        //ShowContentByTitle();
                        break;
                    case "3":
                        //Create new streaming content
                       // CreateNewContent();
                        break;
                    case "4":
                        // Update existing content
                        //UpdateExistingContent();
                        break;
                    case "5":
                        // Delete existing content
                        //DeleteContentByTitle();
                        break;
                    case "6":
                        //Exit
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option");
                        Console.ReadKey();
                        break;
                }
            }

          
        }
        private void ShowAllContent()

        {
            Console.Clear();

            List<Ingredients> ingredients = new List<Ingredients>();


            foreach (Ingredients content in ingredients)
            {
                DisplayContent(content);
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        private void DisplayContent(Ingredients content)
        {
            Console.WriteLine($"ID: {content.Id}");
            Console.WriteLine($"Name: {content.Name}");
            Console.WriteLine($"Price: {content.Price}");
            Console.WriteLine($"Quantity: {content.Quantity}");
            Console.WriteLine($"Price: {content.UPC}");
        }
     
    }
}
