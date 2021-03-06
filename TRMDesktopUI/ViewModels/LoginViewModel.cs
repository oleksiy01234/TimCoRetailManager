using Caliburn.Micro;
using System;
using System.Threading.Tasks;
using TRMDesktopUI.EventModels;
using TRMDesktopUI.Library.Api;

namespace TRMDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _userName;
        private string _password;
        private readonly IAPIHelper _apiHelper;
        private readonly IEventAggregator _eventAggregator;

        public LoginViewModel(IAPIHelper apiHelper, IEventAggregator eventAggregator)
        {
            _apiHelper = apiHelper;
            _eventAggregator = eventAggregator;
        }

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public bool IsErrorVisible => ErrorMessage?.Length > 0;

        private string _errorMessage;

        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                _errorMessage = value;
                NotifyOfPropertyChange(() => ErrorMessage);
                NotifyOfPropertyChange(() => IsErrorVisible);
            }
        }

        public bool CanLogIn => UserName?.Length > 0 && Password?.Length > 0;

        public async Task LogIn()
        {
            ErrorMessage = "";
            Console.WriteLine($"Logging in with username \"{UserName}\" and password \"{Password}\"...");

            try
            {
                var result = await _apiHelper.Authenticate(UserName, Password);
                Console.WriteLine($"Result: {result}");

                // Capture more information about the user
                await _apiHelper.GetLoggedInUserInfo(result.Access_Token);

                // raise an event
                // use empty event model class to differentiate it from other calls
                await _eventAggregator.PublishOnUIThreadAsync(new LogInEvent());
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }
    }
}
