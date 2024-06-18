using Data.Object;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Data.Repository
{
    public class ProductsRepo
    {
        string urlApi = "https://products-6704.restdb.io/rest/products";
        string apiKey = "6670a71ab5eda1c7a6fce8bc";

        // Create a client object to using functions
        HttpClient client = new HttpClient();

        public ProductsRepo()
        {
            // Configure connections headers
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("apikey", apiKey);
        }

        // Get the products and deserialize these and convert to Observable Collections using Product properties.

        public async Task<ObservableCollection<Product?>> get()
        {
            var res = await client.GetStringAsync(urlApi);
            var products = JsonConvert.DeserializeObject<ObservableCollection<Product?>>(res);
            return products;
        }

        public async Task<Product?> add(string Name, string Category, string Description, int Quantity, float Price)
        {

            // Create a new product based in the arguments
            Product product = new Product()
            {
                Name = Name,
                Category = Category,
                Description = Description,
                Quantity = Quantity,
                Price = Price
            };

            // Desarialize object to convert a Json

            var productJson = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");

            // Send Object Desarialized to API
            var res = await client.PostAsync(urlApi, productJson);

            // Desarialize Json to Object
            var jsonString = await res.Content.ReadAsStringAsync();


            var newProduct = JsonConvert.DeserializeObject<Product>(jsonString);

            return newProduct;
        }

        public async Task<Product?> Update(string Id,string Name, string Category, string Description, int Quantity, float Price)
        {
            Product product = new Product()
            {
                Name = Name,
                Category = Category,
                Description = Description,
                Quantity = Quantity,
                Price = Price
            };

            // Serialize object to convert a Json

            var productJson = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");

            // Put id product
            var res = await client.PutAsync($"{urlApi}/{Id}", productJson);

            // Desarialize Json to Object

            var jsonRes = await res.Content.ReadAsStringAsync();

            var productUpdated = JsonConvert.DeserializeObject<Product>(jsonRes);

            return productUpdated;

        }

        public async Task<Product?> getId(string Id)
        {
            var res = await client.GetStringAsync($"{urlApi}/{Id}");

            var productGetted = JsonConvert.DeserializeObject<Product>(res);

            return productGetted;
        }

        public async Task<bool> Remove(string Id)
        {
            var res = await client.DeleteAsync($"{urlApi}/{Id}");
            return res.IsSuccessStatusCode;
        }
    }
}
