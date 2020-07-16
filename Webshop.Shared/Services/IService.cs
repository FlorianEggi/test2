using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Webshop.Shared.Models.Requests.AddItemToCart;
using Webshop.Shared.Models.Requests.ArticleDetails;
using Webshop.Shared.Models.Requests.ChangeCurrentCart;
using Webshop.Shared.Models.Requests.NewShoppingCart;
using Webshop.Shared.Models.Requests.Register;
using Webshop.Shared.Models.Requests.Search;
using Webshop.Shared.Models.Requests.ShowShoppingCart;
using Webshop.Shared.Models.Responses.AddItemToCart;
using Webshop.Shared.Models.Responses.ArticleDetails;
using Webshop.Shared.Models.Responses.ChangeCurrentCart;
using Webshop.Shared.Models.Responses.NewShoppingCart;
using Webshop.Shared.Models.Responses.Register;
using Webshop.Shared.Models.Responses.Search;
using Webshop.Shared.Models.Responses.ShoppingCarts;
using Webshop.Shared.Models.Responses.ShowShoppingCart;

namespace Webshop.Shared.Services
{
       public  interface IService
    {
        Task<RegisterResponse> RegisterUserAsync(string url, RegisterRequest model);

        Task<SearchResponse> SearchResponseAsync(string url, SearchRequest model);

        Task<ArticleDetailResponse> ArticleDetailResponseAsync(string url, ArticleDetailRequest model);

        Task<ShoppingCartResponse> ShoppingCartListResponseAsync(string url);

        Task<NewShoppingCartResponse> NewShoppingCartResponseAsync(string url, NewShoppingCartRequest model);

        Task<ChangeCurrentCartResponse> ChangeCurrentCartResponseAsync(string url, ChangeCurrentCartRequest model);

        Task<ShowShoppingCartResponse> ShowShoppingCartResponseAsync(string url, ShowShoppingCartRequest model);

        Task<AddItemToCartResponse> AddShoppingCartResponseAsync(string url, AddItemToCartRequest model);

    }
}
