using Microsoft.AspNetCore.DataProtection.KeyManagement;
using RestSharp;

namespace RecipeAPIPracticev2.Models
{
    public class RecipeDAL
    {
        public string key = "2202bc6f8655406b84a2ca9ed4af6a79";

        public Results SearchRecipe(string keyword)
        {
            string url = $"https://api.spoonacular.com/recipes/complexSearch?query={keyword}&apiKey={key}"; //replace ?s= to ?i=, per omdbapi website

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            var response = client.GetAsync<Results>(request);
            Results r = response.Result;
            return r;
        }
        
    }
}
