using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive;
using Reactive.Bindings;
using System.Reactive.Linq;

namespace SlideButton
{
    public class SlideButtonViewModel
    {
        public ReactiveProperty<int> Width { get; set; }
        public ReactiveProperty<int> Height { get; set; }

        public SlideButtonViewModel()
        {
            this.Width = new ReactiveProperty<int>(50);
            this.Height = this.Width.Select(x => (int)(x * 0.36)).ToReactiveProperty();
        }
    }
}
