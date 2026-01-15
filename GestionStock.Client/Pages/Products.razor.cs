using GestionStock.Client.Models;
using GestionStock.Client.Services;
using Microsoft.AspNetCore.Components;

namespace GestionStock.Client.Pages
{
    public partial class Products
    {
        [Inject]
        public required ProductService ProductService { get; set; }

        private List<ProductsResponse>? _products;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                _products = await ProductService.GetAllProducts();
                return;
            }
            catch (HttpRequestException)
            {

            }
        }
    }
}
