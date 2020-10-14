using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismRx.Views.Search
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextSearchView 
    {
        public TextSearchView()
        {
            InitializeComponent();
            this.WhenActivated(
                (CompositeDisposable viewDisposables) =>
                {
                    this.OneWayBind(this.ViewModel, vm => vm.Text, view => view.textLabel.Text)
                    .DisposeWith(viewDisposables);

                    this.OneWayBind(this.ViewModel, vm => vm.Time, view => view.timeLabel.Text,x => string.Format("{0:T}",x))
                    .DisposeWith(viewDisposables);
                });
        }
    }
}