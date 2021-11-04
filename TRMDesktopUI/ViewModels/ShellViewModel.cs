using System;

namespace TRMDesktopUI.ViewModels
{
    public class ShellViewModel
    {
        private ICalculations calculations;

        public ShellViewModel(ICalculations calculations)
        {
            this.calculations = calculations;

            Console.WriteLine($"Adding: {calculations.Add(1.3, 4.3)}");
        }
    }
}
