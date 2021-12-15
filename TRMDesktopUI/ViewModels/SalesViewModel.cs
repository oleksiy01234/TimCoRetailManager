using Caliburn.Micro;
using System.ComponentModel;
using System.Threading.Tasks;
using TRMDesktopUI.Library.Api;
using TRMDesktopUI.Library.Models;

namespace TRMDesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {
        IProductEndpoint _productEndpoint;

        public SalesViewModel(IProductEndpoint productEndpoint)
        {
            _productEndpoint = productEndpoint;
        }

        protected override async void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            await LoadProducts();
        }

        private async Task LoadProducts()
        {
            var productList = await _productEndpoint.GetAllAsync();
            Products = new BindingList<ProductModel>(productList);
        }

        private BindingList<ProductModel> _products;

        public BindingList<ProductModel> Products
        {
            get => _products;
            set
            {
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        private BindingList<ProductModel> _cart;

        public BindingList<ProductModel> Cart
        {
            get => _cart;
            set
            {
                _cart = value;
                NotifyOfPropertyChange(() => Cart);
            }
        }

        private int _itemQuantity;

        public int ItemQuantity
        {
            get => _itemQuantity;
            set
            {
                _itemQuantity = value;
                NotifyOfPropertyChange(() => ItemQuantity);
            }
        }

        public string SubTotal => "$0.00";
        public string Tax => "$0.00";
        public string Total => "$0.00";

        public bool CanAddToCart => false;

        public void AddToCart()
        {

        }

        public bool CanRemoveFromCart => false;

        public void RemoveFromCart()
        {

        }

        public bool CanCheckOut => false;

        public void CheckOut()
        {

        }
    }
}
