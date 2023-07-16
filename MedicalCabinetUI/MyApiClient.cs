using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MedicalCabinetUI.Models;
using Newtonsoft.Json;

namespace MedicalCabinetUI
{
    public class MyApiClient
    {

        private readonly HttpClient httpClient;
        private const string getAllSoft_uri = "https://localhost:7111/api/MedicalStaff/all-soft";
        private const string getAll_uri = "https://localhost:7111/api/MedicalStaff/all";
        private const string deleteSoft_uri = "https://localhost:7111/api/MedicalStaff/soft-delete";
        private const string delete_uri = "https://localhost:7111/api/MedicalStaff/delete";
        private const string add_uri = "https://localhost:7111/api/MedicalStaff";     
        private const string getByName_uri = "https://localhost:7111/api/MedicalStaff/name";
        private const string update_uri = "https://localhost:7111/api/MedicalStaff";
        private const string getById_uri = "https://localhost:7111/api/MedicalStaff";

        private const string MEDICATION_CRUD_URI = "https://localhost:7111/api/Medication";

        private const string PATIENT_CRUD_URI = "https://localhost:7111/api/Patient";
        
        private const string CONSULTATION_CRUD_URI = "https://localhost:7111/api/Consultation";


        public MyApiClient()
        {
            httpClient = new HttpClient();
           // httpClient.BaseAddress = new Uri("http://localhost:7111"); // Adresa de bază a API-ului
        }

       /* public async Task<List<MedicalStaff>> GetMedicalStaff()
        {
            HttpResponseMessage response = await httpClient.GetAsync("/api/MedicalStaff"); // Endpoint-ul dorit
            response.EnsureSuccessStatusCode(); // Verifică dacă cererea a fost cu succes

            string result = await response.Content.ReadAsStringAsync();
            List<MedicalStaff> medicalStaffList = JsonConvert.DeserializeObject<List<MedicalStaff>>(result);
            return medicalStaffList; 
        }*/
       public static async Task<List<MedicalStaff>> GetJsonHttpClient(HttpClient httpClient, string uri = getAllSoft_uri)
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

        public static async Task<List<MedicalStaff>> GetJsonHttpClientHard(HttpClient httpClient, string uri = getAll_uri)
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

        public static async Task<List<MedicalStaff>> GetJsonHttpClientByName(HttpClient httpClient,string name, string uri = getByName_uri)
        {

            try
            {
                string searchUri = $"{uri}/{name}";
                var httpResponse = await httpClient.GetAsync(searchUri, HttpCompletionOption.ResponseHeadersRead);
                 if(httpResponse.StatusCode != System.Net.HttpStatusCode.NoContent)
               // if (httpResponse.Content is object && httpResponse.Content.Headers.ContentType.MediaType == "application/json")
                {
                    return await httpClient.GetFromJsonAsync<List<MedicalStaff>>(searchUri);
                }
               // else return null;
                
                
            }
            catch (HttpRequestException) // Non success
            {
                Console.WriteLine("An error occurred.");
            }
            catch (NotSupportedException) // When content type is not valid
            {
                Console.WriteLine("The content type is not supported.");
            }

            return null;
        }

        public static async Task<MedicalStaff> GetJsonHttpClientById(HttpClient httpClient, Guid id, string uri = getById_uri)
        {

            try
            {
                string searchUri = $"{uri}/id/{id}";
                var httpResponse = await httpClient.GetAsync(searchUri, HttpCompletionOption.ResponseHeadersRead);
                if (httpResponse.StatusCode != System.Net.HttpStatusCode.NoContent)
                // if (httpResponse.Content is object && httpResponse.Content.Headers.ContentType.MediaType == "application/json")
                {
                    return await httpClient.GetFromJsonAsync<MedicalStaff>(searchUri);
                }
                // else return null;


            }
            catch (HttpRequestException) // Non success
            {
                Console.WriteLine("An error occurred.");
            }
            catch (NotSupportedException) // When content type is not valid
            {
                Console.WriteLine("The content type is not supported.");
            }

            return null;
        }

        public static async Task PostJsonHttpClient(HttpClient httpClient, MedicalStaffPOST medicalStaff, string uri = add_uri)
        {
            try
            {
                HttpResponseMessage response = await httpClient.PostAsJsonAsync(uri, medicalStaff);
                response.EnsureSuccessStatusCode(); // Verifică dacă răspunsul este de succes
                

                
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
        }

        public static async Task PutJsonHttpClient(HttpClient httpClient, MedicalStaffPOST medicalStaff,Guid id, string uri = update_uri)
        {
            try
            {
                string updateUri = $"{uri}?id={id}";
                HttpResponseMessage response = await httpClient.PutAsJsonAsync(updateUri, medicalStaff);
                response.EnsureSuccessStatusCode(); // Verifică dacă răspunsul este de succes

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
        }

        public static async Task DeleteResource(HttpClient httpClient, Guid id, string uri = deleteSoft_uri )
        {
            try
            {
                string deleteUri = $"{uri}?id={id}";
                HttpResponseMessage response = await httpClient.DeleteAsync(deleteUri);
                response.EnsureSuccessStatusCode(); // Verifică dacă răspunsul este de succes

               
            }
            catch (HttpRequestException) // Non success
            {
                Console.WriteLine("An error occurred.");
            }
            catch (NotSupportedException) // When content type is not valid
            {
                Console.WriteLine("The content type is not supported.");
            }
        }
        public static async Task DeleteResourceHard(HttpClient httpClient, Guid id, string uri = delete_uri)
        {
            try
            {
                string deleteUri = $"{uri}?id={id}";
                HttpResponseMessage response = await httpClient.DeleteAsync(deleteUri);
                response.EnsureSuccessStatusCode(); // Verifică dacă răspunsul este de succes


            }
            catch (HttpRequestException) // Non success
            {
                Console.WriteLine("An error occurred.");
            }
            catch (NotSupportedException) // When content type is not valid
            {
                Console.WriteLine("The content type is not supported.");
            }
        }

        //*------------------------------------------  MEDICATION --------------------------------------

        public static async Task<List<Medication>> M_GetJsonHttpClient(HttpClient httpClient, string uri = MEDICATION_CRUD_URI)
        {

            try
            {
                return await httpClient.GetFromJsonAsync<List<Medication>>(uri);
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
        public static async Task M_PostJsonHttpClient(HttpClient httpClient, MedicationPOST medicationPost, string uri = MEDICATION_CRUD_URI)
        {
            try
            {
                HttpResponseMessage response = await httpClient.PostAsJsonAsync(uri, medicationPost);
                response.EnsureSuccessStatusCode(); // Verifică dacă răspunsul este de succes



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
        }

        public static async Task M_PutJsonHttpClient(HttpClient httpClient, MedicationPOST medicationPost, Guid id, string uri = MEDICATION_CRUD_URI)
        {
            try
            {
                string updateUri = $"{uri}?id={id}";
                HttpResponseMessage response = await httpClient.PutAsJsonAsync(updateUri, medicationPost);
                response.EnsureSuccessStatusCode(); // Verifică dacă răspunsul este de succes

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
        }

        public static async Task M_DeleteResource(HttpClient httpClient, Guid id, string uri = MEDICATION_CRUD_URI)
        {
            try
            {
                string deleteUri = $"{uri}?id={id}";
                HttpResponseMessage response = await httpClient.DeleteAsync(deleteUri);
                response.EnsureSuccessStatusCode(); // Verifică dacă răspunsul este de succes


            }
            catch (HttpRequestException) // Non success
            {
                Console.WriteLine("An error occurred.");
            }
            catch (NotSupportedException) // When content type is not valid
            {
                Console.WriteLine("The content type is not supported.");
            }
        }

        //*------------------------------------------  PATIENT --------------------------------------

        public static async Task<List<Patient>> P_GetJsonHttpClient(HttpClient httpClient, string uri = PATIENT_CRUD_URI)
        {

            try
            {
                return await httpClient.GetFromJsonAsync<List<Patient>>(uri);
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
        public static async Task P_PostJsonHttpClient(HttpClient httpClient, PatientPOST patientnPost, string uri = PATIENT_CRUD_URI)
        {
            try
            {
                HttpResponseMessage response = await httpClient.PostAsJsonAsync(uri, patientnPost);
                response.EnsureSuccessStatusCode(); // Verifică dacă răspunsul este de succes



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
        }

        public static async Task P_PutJsonHttpClient(HttpClient httpClient, PatientPOST patientPost, Guid id, string uri = PATIENT_CRUD_URI)
        {
            try
            {
                string updateUri = $"{uri}?id={id}";
                HttpResponseMessage response = await httpClient.PutAsJsonAsync(updateUri, patientPost);
                response.EnsureSuccessStatusCode(); // Verifică dacă răspunsul este de succes

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
        }

        public static async Task P_DeleteResource(HttpClient httpClient, Guid id, string uri = PATIENT_CRUD_URI)
        {
            try
            {
                string deleteUri = $"{uri}?id={id}";
                HttpResponseMessage response = await httpClient.DeleteAsync(deleteUri);
                response.EnsureSuccessStatusCode(); // Verifică dacă răspunsul este de succes


            }
            catch (HttpRequestException) // Non success
            {
                Console.WriteLine("An error occurred.");
            }
            catch (NotSupportedException) // When content type is not valid
            {
                Console.WriteLine("The content type is not supported.");
            }
        }

        //*------------------------------------------  CONSULTATION --------------------------------------

        public static async Task<List<Consultation>> C_GetJsonHttpClient(HttpClient httpClient, string uri = CONSULTATION_CRUD_URI)
        {

            try
            {
                return await httpClient.GetFromJsonAsync<List<Consultation>>(uri);
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
        public static async Task C_PostJsonHttpClient(HttpClient httpClient, ConsultationPOST consultationPOST, string uri = CONSULTATION_CRUD_URI)
        {
            try
            {
                HttpResponseMessage response = await httpClient.PostAsJsonAsync(uri, consultationPOST);
                response.EnsureSuccessStatusCode(); // Verifică dacă răspunsul este de succes



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
        }

        public static async Task C_PutJsonHttpClient(HttpClient httpClient, ConsultationPUT consultationPUT, Guid id, string uri = CONSULTATION_CRUD_URI)
        {
            try
            {
                string updateUri = $"{uri}?id={id}";
                HttpResponseMessage response = await httpClient.PutAsJsonAsync(updateUri, consultationPUT);
                response.EnsureSuccessStatusCode(); // Verifică dacă răspunsul este de succes

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
        }

        public static async Task C_DeleteResource(HttpClient httpClient, Guid id, string uri = CONSULTATION_CRUD_URI)
        {
            try
            {
                string deleteUri = $"{uri}?id={id}";
                HttpResponseMessage response = await httpClient.DeleteAsync(deleteUri);
                response.EnsureSuccessStatusCode(); // Verifică dacă răspunsul este de succes


            }
            catch (HttpRequestException) // Non success
            {
                Console.WriteLine("An error occurred.");
            }
            catch (NotSupportedException) // When content type is not valid
            {
                Console.WriteLine("The content type is not supported.");
            }
        }

    }
}
