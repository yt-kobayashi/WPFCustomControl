using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive;
using Reactive.Bindings;
using System.Reactive.Linq;
using System.ComponentModel;
using System.Windows;

namespace SlideButton
{
    public class SlideButtonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ReactiveProperty<int> Width { get; set; } = new ReactiveProperty<int>();
        public ReactiveProperty<int> Height { get; set; } = new ReactiveProperty<int>();
        public ReactiveProperty<double> CornerRadius { get; set; } = new ReactiveProperty<double>();
        public ReactiveProperty<int> LeftPosition { get; set; } = new ReactiveProperty<int>();
        public ReactiveProperty<int> RightPosition { get; set; } = new ReactiveProperty<int>();
        public ReactiveProperty<double> ElipseSize { get; set; } = new ReactiveProperty<double>();

        public SlideButtonViewModel()
        {
            Width.Value = 50;
            Height.Value = 18;
            CornerRadius.Value = Height.Value / 2.0;
        }
    }
}
