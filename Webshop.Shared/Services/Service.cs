using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AKSoftware.WebApi.Client;
using Newtonsoft.Json;
using Webshop.Shared.Models.Requests;
using Webshop.Shared.Models.Requests.Register;
using Webshop.Shared.Models.Requests.Search;
using Webshop.Shared.Models.Responses.Search;
using Webshop.Shared.Models.Responses.Register;
using Webshop.Shared.Models.Responses.ArticleDetails;
using Webshop.Shared.Models.Requests.ArticleDetails;
using Webshop.Shared.Models.Responses.ShoppingCarts;
using Webshop.Shared.Models.Requests.ShoppingCarts;

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
        //   Console.WriteLine(responseBody);
            var returnedUser =   JsonConvert.DeserializeObject<RegisterResponse>(responseBody);

            if(returnedUser.Status == "OK")
            {
                sessionIds = returnedUser.Data.Sessionid;

            }
            return returnedUser;

        }


        public async Task<SearchResponse> SearchResponseAsync(string url, SearchRequest model)
        {
            // var loginUrl = $"{url}/OD000R.PGM";
            var formDictionary = new Dictionary<string, string>();
            //formDictionary.Add("sessionid", sessionIds);
            //formDictionary.Add("searchterms", "HAG");
            //formDictionary.Add("displaycount", "5");

            formDictionary.Add("sessionid", sessionIds);
            formDictionary.Add("searchterms", model.searchterms);
            formDictionary.Add("displaycount", model.displaycount);
            formDictionary.Add("codestockitems", model.codestockitems);


            var formContent = new FormUrlEncodedContent(formDictionary);
            var searchRequest = await Http.PostAsync(url, formContent);


            Console.WriteLine(searchRequest.StatusCode);


            var responseBody = await searchRequest.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            var returnedSearch = JsonConvert.DeserializeObject<SearchResponse>(responseBody);

            //var x = JsonConvert.DeserializeObject<>
            if (returnedSearch.Status == "OK")
            {
                Console.WriteLine(returnedSearch.Data.Itemidlist);
                foreach (var item in returnedSearch.Data.Searchresults)
                {
                    Console.WriteLine(item);
                }
            
                //sessionIds = returnedUser.Data.Sessionid;

            }
            return returnedSearch;

        }


        public async Task<ArticleDetailResponse> ArticleDetailResponseAsync(string url, ArticleDetailRequest model)
        {
            var formDictionary = new Dictionary<string, string>();
         
            formDictionary.Add("sessionid", sessionIds);
            //formDictionary.Add("ean", model.ean);
            formDictionary.Add("itemid", "AT90V10");
            //formDictionary.Add("customeritemid", model.customeritemid);


            var formContent = new FormUrlEncodedContent(formDictionary);
            var articleRequest = await Http.PostAsync(url, formContent);


            Console.WriteLine(articleRequest.StatusCode);


            var responseBody = await articleRequest.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            var returnedArticle = JsonConvert.DeserializeObject<ArticleDetailResponse>(responseBody);

            //var x = JsonConvert.DeserializeObject<>
            if (returnedArticle.Status == "OK")
            {
                Console.WriteLine(returnedArticle);
              

                //sessionIds = returnedUser.Data.Sessionid;

            }
            return returnedArticle;

        }


        public async Task<ShoppingCartResponse> ShoppingCartResponseAsync(string url)
        {
            var formDictionary = new Dictionary<string, string>();

            formDictionary.Add("sessionid", sessionIds);

            var formContent = new FormUrlEncodedContent(formDictionary);
            var cartRequest = await Http.PostAsync(url, formContent);


            Console.WriteLine(cartRequest.StatusCode);


            var responseBody = await cartRequest.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            var returnedCartList = JsonConvert.DeserializeObject<ShoppingCartResponse>(responseBody);

            //var x = JsonConvert.DeserializeObject<>
            if (returnedCartList.Status == "OK")
            {
                Console.WriteLine(returnedCartList);

            }
            return returnedCartList;

        }
    }
}

 
    
