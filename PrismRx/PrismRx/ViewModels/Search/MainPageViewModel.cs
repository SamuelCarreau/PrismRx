using DynamicData.Binding;
using Prism.Navigation;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;

namespace PrismRx.ViewModels.Search
{
    public class MainPageViewModel : ViewModelBase
    {
        private IObservable<TextSearchViewModel> searchThermObservable;

        [Reactive]
        public string SearchTherm { get; set; }

        [Reactive]
        public ObservableCollection<TextSearchViewModel> SearchResults { get; set; } = new ObservableCollection<TextSearchViewModel>();

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Search page";

            this.searchThermObservable = this.WhenAnyPropertyChanged(nameof(SearchTherm))
                .Throttle(TimeSpan.FromSeconds(.5))
                .Select(vm => vm.SearchTherm.Trim())
                .Where(text => !string.IsNullOrWhiteSpace(text))
                .Select(text => new TextSearchViewModel(text, DateTime.Now))
                .DistinctUntilChanged()
                .Do(text => SearchResults.Insert(0, text));
            this.searchThermObservable.Subscribe();
        }
    }
}
