using ReactiveUI.Fody.Helpers;
using System;

namespace PrismRx.ViewModels.Search
{
    public class TextSearchViewModel
    {
        [Reactive]
        public string Text { get; set; }
        [Reactive]
        public DateTime Time { get; set; }

        public TextSearchViewModel(string text, DateTime time)
        {
            Text = text;
            Time = time;
        }
    }
}
