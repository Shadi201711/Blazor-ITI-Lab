using System.Net.Http.Json;

namespace Day3.Services
{
    public class ProductServices : IServices<Product>
    {
        HttpClient httpClient;

        public ProductServices(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task Add(Product item)
        {
            var res = await httpClient.PostAsJsonAsync<Product>("api/Products", item);

            if (!res.IsSuccessStatusCode)
            {
                throw new Exception("Error adding product");
            }
        }

        public async Task Delete(int id)
        {
            await httpClient.DeleteAsync($"api/Products/{id}");
        }

        public async Task<List<Product>> GetAll()
        {
            List<Product> prod = await httpClient.GetFromJsonAsync<List<Product>>("api/Products");
            return prod;
        }

        public async Task<Product> GetById(int id)
        {
            Product prod = await httpClient.GetFromJsonAsync<Product>($"api/Products/{id}");
            return prod;
        }

        public async Task Update(int id, Product item)
        {
            await httpClient.PutAsJsonAsync<Product>($"api/Products/{id}", item);
        }
    }
}
