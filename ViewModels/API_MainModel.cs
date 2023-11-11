using guardianEyeMAUI.Models;
using System.Diagnostics;
using System.Text.Json;

namespace guardianEyeMAUI
{
    public class API_MainModel
    {
        public IList<Detection> QueriedDetections { get; private set; }
        readonly HttpClient _httpClient;
        
        public API_MainModel()
        {
            _httpClient = new HttpClient();
            QueriedDetections = (IList<Detection>)RefreshDetections();
        }

        public async Task<List<Detection>> RefreshDetections()
        {
            QueriedDetections = new List<Detection>();

            Uri uri = new Uri(string.Format(Constants.baseAddress, string.Empty));
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    QueriedDetections = JsonSerializer.Deserialize<List<Detection>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return (List<Detection>)QueriedDetections;
        }
    }
}