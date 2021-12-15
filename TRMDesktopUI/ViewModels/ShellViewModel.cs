using Caliburn.Micro;
using System.Threading;
using System.Threading.Tasks;
using TRMDesktopUI.EventModels;

namespace TRMDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogInEvent>
    {
        private readonly IEventAggregator eventAggregator;
        private readonly SalesViewModel salesVM;
        private readonly SimpleContainer container;

        public ShellViewModel(
            IEventAggregator eventAggregator,
            SalesViewModel salesVM,
            SimpleContainer container)
        {
            this.eventAggregator = eventAggregator;
            this.salesVM = salesVM;
            this.container = container;

            this.eventAggregator.SubscribeOnPublishedThread(this);

            ActivateItemAsync(container.GetInstance<LoginViewModel>());
        }

        public Task HandleAsync(LogInEvent message, CancellationToken cancellationToken)
        {
            return ActivateItemAsync(salesVM);
        }
    }
}
