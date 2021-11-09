using Caliburn.Micro;
using System.ComponentModel;

namespace TRMDesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {
        private BindingList<string> _products;

        public BindingList<string> Products
        {
            get => _products;
            set
            {
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        private BindingList<string> _cart;

        public BindingList<string> Cart
        {
            get => _cart;
            set
            {
                _cart = value;
                NotifyOfPropertyChange(() => Cart);
            }
        }

        private string _itemQuantity;

        public string ItemQuantity
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
