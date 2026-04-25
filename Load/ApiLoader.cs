using System.Text;
using System.Text.Json;

namespace HorizonETL.Load;

public class ApiLoader
{
    private readonly HttpClient _httpClient = new();

    public async Task SendAsync(List<object> data)
    {
        var url = "https://jsonplaceholder.typicode.com/posts";

        foreach (var item in data)
        {
            var json = JsonSerializer.Serialize(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await _httpClient.PostAsync(url, content);
                Console.WriteLine($"Status: {response.StatusCode}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error enviando registro: {ex.Message}");
            }
        }
    }
}