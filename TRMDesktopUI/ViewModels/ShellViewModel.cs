using Caliburn.Micro;
using System;

namespace TRMDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private LoginViewModel loginVM;

        public ShellViewModel(LoginViewModel loginVM)
        {
            this.loginVM = loginVM;
            ActivateItemAsync(loginVM);
        }

        private ICalculations calculations;

        public ShellViewModel(ICalculations calculations)
        {
            this.calculations = calculations;

            Console.WriteLine($"Adding: {calculations.Add(1.3, 4.3)}");
        }
    }
}
