using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AKSoftware.WebApi.Client;
using Webshop.Shared.Models.Requests;
using Webshop.Shared.Models.Responses;

namespace Webshop.Shared.Services
{
    public class AuthenticationService 
    {
        private readonly string _baseUrl;

       ServiceClient client = new ServiceClient();

        public AuthenticationService(string url)
        {
            _baseUrl = url;
        }

        public async Task<RegisterResponse> RegisterUserAsync(RegisterRequest request)
        {
            
            
            var result = await client.PostAsync<RegisterResponse>($"{_baseUrl}/PGM4/OD000R.PGM", request);
           // return null;
            return result.Result;
        }
    }

 
    
}
