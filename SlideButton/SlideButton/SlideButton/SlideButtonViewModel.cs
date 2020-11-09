using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive;
using Reactive.Bindings;
using System.Reactive.Linq;
using System.ComponentModel;

namespace SlideButton
{
    public class SlideButtonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ReactiveProperty<int> Width { get; set; } = new ReactiveProperty<int>();
        public ReactiveProperty<int> Height { get; set; } = new ReactiveProperty<int>();

        public SlideButtonViewModel()
        {
        }
    }
}
