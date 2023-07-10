using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MedicalCabinetUI
{
    public class MyApiClient
    {

        private readonly HttpClient httpClient;

        public MyApiClient()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:7111"); // Adresa de bază a API-ului
        }

        public async Task<List<MedicalStaff>> GetMedicalStaff()
        {
            HttpResponseMessage response = await httpClient.GetAsync("/api/MedicalStaff"); // Endpoint-ul dorit
            response.EnsureSuccessStatusCode(); // Verifică dacă cererea a fost cu succes

            string result = await response.Content.ReadAsStringAsync();
            List<MedicalStaff> medicalStaffList = JsonConvert.DeserializeObject<List<MedicalStaff>>(result);
            return medicalStaffList; 
        }
       public static async Task<List<MedicalStaff>> GetJsonHttpClient(string uri, HttpClient httpClient)
        {
            try
            {
                return await httpClient.GetFromJsonAsync<List<MedicalStaff>>(uri);
            }
            catch (HttpRequestException) // Non success
            {
                Console.WriteLine("An error occurred.");
            }
            catch (NotSupportedException) // When content type is not valid
            {
                Console.WriteLine("The content type is not supported.");
            }
            catch (JsonException) // Invalid JSON
            {
                Console.WriteLine("Invalid JSON.");
            }

            return null;
        }
    }
}
