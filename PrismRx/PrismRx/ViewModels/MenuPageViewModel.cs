using Prism.Navigation;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismRx.ViewModels
{
    public class MenuPageViewModel : ViewModelBase
    {
        public ReactiveCommand<string, INavigationResult> NavigateCommand { get; set; }
        public MenuPageViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
            Title = "Menu";
            NavigateCommand =
                ReactiveCommand.CreateFromTask<string, INavigationResult>(path => NavigationService.NavigateAsync(path));
        }
    }
}
