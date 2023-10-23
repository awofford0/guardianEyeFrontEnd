

using guardianEyeMAUI.Models;
using System.Text.Json;

namespace guardianEyeMAUI.Services
{
    public class DetectionServices : IDetectionServices
    {
        HttpClient _httpClient = new HttpClient();
        public List<Detection> dbDetections { get; private set; }

        public async Task<List<Detection>> RefreshDataAsync()
        {
            dbDetections = new List<Detection>();

            Uri uri = new Uri(string.Format(Constants.baseAddress));
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(uri);
                int foo = 0;
                foo = foo + 1;
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    dbDetections = JsonSerializer.Deserialize<List<Detection>>(content);
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }

            return dbDetections;
        }

        public async Task DeleteDetectionAsync(string id)
        {
            Uri uri = new Uri(string.Format(Constants.baseAddress, id));

            try
            {
                HttpResponseMessage response = await _httpClient.DeleteAsync(uri);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
