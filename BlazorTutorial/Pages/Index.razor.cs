using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Shared.Models.Requests.Search;
using static Webshop.Shared.Services.Service;


namespace Webshop.Pages
{
    public partial class Index
    {
        

        private string searchTerm;

       

        string[] warenkorbItems = new[]
               {
                "w1",
                "w2",
                "w3",
            };



        #region Search

        public List<Webshop.DTO.Product> ListProducts = new List<DTO.Product>();

        public string SearchTerm
        {
            get { return searchTerm; }
            set { searchTerm = value; }
        }

        public bool Lagerware { get; set; } = false;

        SearchRequest model = new SearchRequest();
        string baseUrl = "https://www.online.holter.at/PGM4";

        public async void SearchClicked()
        {
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
                Console.WriteLine("SearchResults: " + ListProducts[3].Datanormname1);
            }
            else
            {
                Console.WriteLine("Searchterm is null or empty");
            }

        }
        #endregion

        #region DoubleClickOnItem / Dialog
        public void OnPersonDbClicked(object item)
        {
            Console.WriteLine("SelectedItem: " + item.ToString());
            OpenDialog();
        }

        bool dialogIsOpen = false;
        string name = null;
        string animal = null;
        string dialogAnimal = null;

        public void OpenDialog()
        {
            dialogAnimal = null;
            dialogIsOpen = true;
        }

        public void OkClick()
        {
            animal = dialogAnimal;
            dialogIsOpen = false;
        }
        #endregion
    }
}
