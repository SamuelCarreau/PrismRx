using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismRx.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage
    {
        public MenuPage()
        {
            InitializeComponent();

            this.WhenActivated(
                (CompositeDisposable viewDisposables) =>
                {
                    this.BindCommand(this.ViewModel, vm => vm.NavigateCommand, view => view.searchPageButton);
                });
        }
    }
}