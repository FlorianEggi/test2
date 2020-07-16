using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.DTO;
using Webshop.Shared.Models.Requests.ArticleDetails;
using Webshop.Shared.Models.Requests.Search;
using static Webshop.Shared.Services.Service;


namespace Webshop.Pages
{
    public partial class Index
    {
        string baseUrl = "https://www.online.holter.at/PGM4";

        string[] warenkorbItems = new[]
                      {
                "w1",
                "w2",
                "w3",
            };



        #region Search

        public List<Webshop.DTO.Product> ListProducts = new List<DTO.Product>();

        private string searchTerm;
        public string SearchTerm
        {
            get { return searchTerm; }
            set { searchTerm = value; }
        }

        public bool Lagerware { get; set; } = false;



        public async void SearchClicked()
        {
            SearchRequest model = new SearchRequest();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Lagerware: " + Lagerware);
            if (!String.IsNullOrEmpty(searchTerm))
            {
                Console.WriteLine("SearchTerm: " + searchTerm);
                ListProducts.Clear();
                var searchUrl = $"{baseUrl}/OD300R.PGM";
                model.searchterms = searchTerm;
                model.displaycount = "5";   //paginator
                var searched = await service.SearchResponseAsync(searchUrl, model);
                //Console.WriteLine("SearchResults: " + searched.Data.Searchresults);
                searched.Data.Searchresults
                    .ForEach(x => ListProducts.Add(new DTO.Product
                    {
                        itemid = x.Itemid,
                        Datanormname1 = x.Datanormname1,
                        Datanormname2 = x.Datanormname2,
                        Codestockitem = x.Codestockitem,
                        Unit = x.Unit,
                        Grossprice = x.Grossprice,
                        Discountgroup = x.Discountgroup
                    }));

                if (Lagerware)
                {
                    ListProducts
                        .Where(x => x.Codestockitem.Equals('L'))
                        .ToList();
                }
                StateHasChanged();
                Console.WriteLine("SearchResults: " + ListProducts[3].Datanormname1);
            }
            else
            {
                StateHasChanged();
                Console.WriteLine("Searchterm is null or empty");
            }

        }
        #endregion

        #region DoubleClickOnItem / Dialog
        public void OnPersonDbClicked(object item)
        {
            Console.WriteLine("SelectedItem: " + item);
            var currentProduct = (Product) item;
            OpenDialog(currentProduct.itemid);
        }

        public bool dialogIsOpen = false;
        public string DetailName = null;
        public double ProductPrice = -1;
        public int OrderQuantity = -1;
        
        public double TotalPrice;




        public async void OpenDialog(string itemid)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("ItemID of CurrentProduct: "+ itemid);
            dialogIsOpen = true;

            ArticleDetailRequest model = new ArticleDetailRequest();
            var articleDetailUrl = $"{baseUrl}/OD310R.PGM";
            var articleDetail = await service.ArticleDetailResponseAsync(articleDetailUrl, model);
            DetailName = articleDetail.Data.Datanormname1;
            ProductPrice = double.Parse(articleDetail.Data.Grossprice);
            TotalPrice = OrderQuantity * ProductPrice;

            StateHasChanged();
        }

        public void OkClick()
        {
            dialogIsOpen = false;
        }
        #endregion
    }
}
