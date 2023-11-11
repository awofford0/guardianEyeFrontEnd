using guardianEyeMAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guardianEyeMAUI.Services
{
    public interface IDetectionServices
    {
        Task<List<Detection>> RefreshDataAsync();

        Task DeleteDetectionAsync(string id);
    }
}
