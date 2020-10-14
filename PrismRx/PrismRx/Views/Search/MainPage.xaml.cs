using DynamicData.Kernel;
using PrismRx.ViewModels;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using Xamarin.Forms;

namespace PrismRx.Views.Search
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.WhenActivated(
                (CompositeDisposable viewDisposables) =>
                {
                    //this.OneWayBind(ViewModel, vm => vm.Title, view => view.Title)
                    //.DisposeWith(viewDisposables);

                    this.Bind(ViewModel, vm => vm.SearchTherm, view => view.searchEntry.Text)
                    .DisposeWith(viewDisposables);

                    this.OneWayBind(ViewModel, vm => vm.SearchResults, view => view.searchCollectionView.ItemsSource)
                    .DisposeWith(viewDisposables);
                });
        }
    }
}
