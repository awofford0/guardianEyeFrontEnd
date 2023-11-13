

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

        public async Task SendToken(string token)
        {
            StringContent tokenHttp = new StringContent(token);
            Uri uri = new Uri(string.Concat(Constants.baseAddress, "?token=", token));
            HttpResponseMessage response = await _httpClient.PutAsync(uri, tokenHttp);
            Console.WriteLine("Tried to send the device token to server");
        }
    }
}
