using Caliburn.Micro;
using System;
using System.Threading.Tasks;
using TRMDesktopUI.Helpers;

namespace TRMDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _userName;
        private string _password;
        private IAPIHelper _apiHelper;

        public LoginViewModel(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public bool CanLogIn
        {
            get
            {
                return UserName?.Length > 0 && Password?.Length > 0;
            }
        }

        public async Task LogIn()
        {
            try
            {
                Console.WriteLine($"Logging in with username \"{UserName}\" and password \"{Password}\"...");
                var result = await _apiHelper.Authenticate(UserName, Password);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception thrown: {e.Message}");
            }
        }
    }
}
