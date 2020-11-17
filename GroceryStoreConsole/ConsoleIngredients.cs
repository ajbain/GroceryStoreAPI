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
    class ConsoleIngredients
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly string baseUrl = "https://localhost:44326/";
        public async Task<Ingredients> RunAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44326/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("api/Ingredients");
                if (response.IsSuccessStatusCode)
                {
                    Ingredients ingredients = await response.Content.ReadAsAsync<Ingredients>();
                    return ingredients;
                }
                return null; 
            }
        //public async Task<Ingredients> GetIngredientsAsync()
        //{
        //    HttpResponseMessage response = await _httpClient.GetAsync(baseUrl + "ingredients");
        //    if (response.IsSuccessStatusCode)
        //    {
        //        Ingredients ingredients = await response.Content.ReadAsAsync<Ingredients>();
        //        return ingredients;
        //    }
        //    return null;
        //}
        }
    }
}
