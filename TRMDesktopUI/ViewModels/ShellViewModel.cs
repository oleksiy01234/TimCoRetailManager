using Caliburn.Micro;
using System;

namespace TRMDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private readonly LoginViewModel loginVM;
        private readonly ICalculations calculations;

        public ShellViewModel(LoginViewModel loginVM)
        {
            this.loginVM = loginVM;
            ActivateItemAsync(loginVM);
        }

        public ShellViewModel(ICalculations calculations)
        {
            this.calculations = calculations;
            Console.WriteLine($"Adding: {calculations.Add(1.3, 4.3)}");
        }
    }
}
