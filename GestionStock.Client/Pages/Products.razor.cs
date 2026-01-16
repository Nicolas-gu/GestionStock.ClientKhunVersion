using GestionStock.Client.Models;
using GestionStock.Client.Services;
using Microsoft.AspNetCore.Components;
using MudBlazor;

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

        private MudMessageBox _mudMessageBox;

        private async Task OnButtonClickedAsync(int id)
        {
            bool? result = await _mudMessageBox.ShowAsync();
            if(result == true)
            {
                await ProductService.Delete(id);
                _products = await ProductService.GetAllProducts();
            }
            StateHasChanged();
        }

     
    }
}
