using PrismRx.ViewModels;
using ReactiveUI;
using ReactiveUI.XamForms;
using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Text;

namespace PrismRx.Views
{
    public class BaseReactiveContentPage<TViewModel> : ReactiveContentPage<TViewModel>
        where TViewModel : ViewModelBase
    {
        public BaseReactiveContentPage()
        {
            this.WhenActivated((CompositeDisposable baseDisposable) => 
            {
                this.OneWayBind(ViewModel, vm => vm.Title, view => view.Title)
                .DisposeWith(baseDisposable);
            });
        }
    }
}
