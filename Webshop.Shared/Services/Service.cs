using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AKSoftware.WebApi.Client;
using Newtonsoft.Json;
using Webshop.Shared.Models.Requests;
using Webshop.Shared.Models.Requests.Register;
using Webshop.Shared.Models.Responses.Register;

namespace Webshop.Shared.Services
{
    public class Service 
    {
        private readonly string _baseUrl;
        HttpClient Http = new HttpClient();
        string sessionIds;
        //  ServiceClient client = new ServiceClient();

        public Service(string url)
        {
            _baseUrl = url;
        }

        public async Task<RegisterResponse> RegisterUserAsync(string url, RegisterRequest model )
        {
            // var loginUrl = $"{url}/OD000R.PGM";
            var formDictionary = new Dictionary<string, string>();
            formDictionary.Add("mail", model.mail);
            formDictionary.Add("password", model.password);

            var formContent = new FormUrlEncodedContent(formDictionary);
            var loginRequest = await Http.PostAsync(url, formContent);


            Console.WriteLine(loginRequest.StatusCode);


            var responseBody = await loginRequest.Content.ReadAsStringAsync();
           Console.WriteLine(responseBody);
            var returnedUser =   JsonConvert.DeserializeObject<RegisterResponse>(responseBody);

            if(returnedUser.Status == "OK")
            {
                sessionIds = returnedUser.Data.Sessionid;

            }
            return returnedUser;

        }
    }

 
    
}
