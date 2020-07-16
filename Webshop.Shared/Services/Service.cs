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
using Webshop.Shared.Models.Responses.NewShoppingCart;
using Webshop.Shared.Models.Requests.NewShoppingCart;
using Webshop.Shared.Models.Responses.ChangeCurrentCart;
using Webshop.Shared.Models.Requests.ChangeCurrentCart;
using Webshop.Shared.Models.Responses.ShowShoppingCart;
using Webshop.Shared.Models.Requests.ShowShoppingCart;
using Webshop.Shared.Models.Responses.AddItemToCart;
using Webshop.Shared.Models.Requests.AddItemToCart;

namespace Webshop.Shared.Services
{
    public class Service : IService
    {
        private readonly string _baseUrl;
        HttpClient Http = new HttpClient();
        string sessionIds;

        public Service(string url)
        {
            _baseUrl = url;
        }

        #region HOW TO CALL THIS METHODS 

        #region DemoServiceRequests
        //var searchUrl = $"{baseUrl}/OD300R.PGM";
        //var req = await authService.SearchResponseAsync(searchUrl,model);
        //foreach (var item in req.Data.Searchresults)
        //{
        //    Console.WriteLine(item.Itemid + " " + item.Datanormname1);
        //}


        //var articleDetailUrl = $"{baseUrl}/OD310R.PGM";
        //var articleDetail = await authService.ArticleDetailResponseAsync(articleDetailUrl, model);
        //Console.WriteLine(articleDetail.Data.Datanormname1);




        //var shoppingCartListUrl = $"{baseUrl}/OD201R.PGM";
        //var shoppingCarts = await authService.ShoppingCartResponseAsync(shoppingCartListUrl);



        //var newShoppingCart = $"{baseUrl}/OD200R.PGM";
        //var shoppingCarts = await authService.NewShoppingCartResponseAsync(newShoppingCart, model);

        //var changeShoppingCart = $"{baseUrl}/OD210R.PGM";
        //var shoppingCartChange = await authService.ChangeCurrentCartResponseAsync(newShoppingCart, model);


        //var showShoppingCar = $"{baseUrl}/OD202R.PGM";
        //var shoppingCartShow = await authService.ChangeCurrentCartResponseAsync(showShoppingCar, model);

        //var addToItemCart = $"{baseUrl}/OD220R.PGM";
        //var addToCart = await authService.AddShoppingCartResponseAsync(addToItemCart, model);

        #endregion

        #endregion

        #region POST Register
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
        #endregion

        #region POST Search
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
        #endregion

        #region POST ArticleDetail
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
        #endregion

        #region POST ShoppingCartList
        public async Task<ShoppingCartResponse> ShoppingCartListResponseAsync(string url)
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

        #endregion

        #region POST NewShoppingCart

        public async Task<NewShoppingCartResponse> NewShoppingCartResponseAsync(string url, NewShoppingCartRequest model)
        {
            var formDictionary = new Dictionary<string, string>();

            formDictionary.Add("sessionid", sessionIds);
            if(model != null)
            {
                formDictionary.Add("commissionid", model.commissionid);

            }

            var formContent = new FormUrlEncodedContent(formDictionary);
            var cartRequest = await Http.PostAsync(url, formContent);


            Console.WriteLine(cartRequest.StatusCode);


            var responseBody = await cartRequest.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            var returnedNewCart = JsonConvert.DeserializeObject<NewShoppingCartResponse>(responseBody);

            if (returnedNewCart.Status == "OK")
            {
                Console.WriteLine(returnedNewCart);

            }
            return returnedNewCart;
        }


        #endregion

        #region POST CurrentCart
        public async Task<ChangeCurrentCartResponse> ChangeCurrentCartResponseAsync(string url, ChangeCurrentCartRequest model)
        {
            var formDictionary = new Dictionary<string, string>();

            formDictionary.Add("sessionid", sessionIds);
            //formDictionary.Add("cartid", "3897264");

            formDictionary.Add("cartid", model.cartid);

            

            var formContent = new FormUrlEncodedContent(formDictionary);
            var cartRequest = await Http.PostAsync(url, formContent);


            Console.WriteLine(cartRequest.StatusCode);


            var responseBody = await cartRequest.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            var returnedChangeCart = JsonConvert.DeserializeObject<ChangeCurrentCartResponse>(responseBody);

            if (returnedChangeCart.Status == "OK")
            {
                Console.WriteLine(returnedChangeCart);

            }
            return returnedChangeCart;
        }

        #endregion

        #region POST ShowShoppingCart

        public async Task<ShowShoppingCartResponse> ShowShoppingCartResponseAsync(string url, ShowShoppingCartRequest model)
        {
            var formDictionary = new Dictionary<string, string>();

            formDictionary.Add("sessionid", sessionIds);
            formDictionary.Add("cartid", model.cartid);


            var formContent = new FormUrlEncodedContent(formDictionary);
            var cartRequest = await Http.PostAsync(url, formContent);


            Console.WriteLine(cartRequest.StatusCode);


            var responseBody = await cartRequest.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            var showCarts = JsonConvert.DeserializeObject<ShowShoppingCartResponse>(responseBody);

            if (showCarts.Status == "OK")
            {
                Console.WriteLine(showCarts);

            }
            return showCarts;
        }
        #endregion

        #region POST AddItemToShoppingCart
       
        public async Task<AddItemToCartResponse> AddShoppingCartResponseAsync(string url, AddItemToCartRequest model)
        {
            var formDictionary = new Dictionary<string, string>();

            formDictionary.Add("sessionid", sessionIds);
            formDictionary.Add("cartid", model.cartid);
            formDictionary.Add("itemid", model.itemid);
            formDictionary.Add("orderamount", model.orderamount);



            var formContent = new FormUrlEncodedContent(formDictionary);
            var cartRequest = await Http.PostAsync(url, formContent);


            Console.WriteLine(cartRequest.StatusCode);


            var responseBody = await cartRequest.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            var showCarts = JsonConvert.DeserializeObject<AddItemToCartResponse>(responseBody);

            if (showCarts.Status == "OK")
            {
                Console.WriteLine(showCarts);

            }
            return showCarts;
        }
        #endregion
    }
}

 
    
