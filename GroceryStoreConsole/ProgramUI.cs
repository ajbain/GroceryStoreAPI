using GroceryStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace GroceryStoreConsole
{
    public class ProgramUI
    {
       
        //static async Task RunAsync()
        //{
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("https://localhost:44326/");
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    }
        //}


        public bool keepRunning = true;
        public void Menu()
        {
            while (keepRunning)
            {
                ConsoleIngredients consoleIngredients = new ConsoleIngredients();
                Ingredients ingredients = consoleIngredients.RunAsync().Result;

                Console.Clear();

                Console.WriteLine("Welcome to the Grocello! Your all-in-one Grocery Store App!");
                Console.WriteLine("Press 1 for a list of groceries already added into your list");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine(ingredients.Id);
                        Console.WriteLine(ingredients.Name);
                        Console.WriteLine(ingredients.Price);
                        break;
                    case "2":
                        keepRunning = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
