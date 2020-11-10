using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SlideButton
{
    /// <summary>
    /// Interaction logic for SlideButton.xaml
    /// </summary>
    public partial class SlideButtonControl : UserControl
    {
        private SlideButtonViewModel _dataContext;

        public SlideButtonControl()
        {
            InitializeComponent();

            _dataContext = new SlideButtonViewModel();
            this.DataContext = _dataContext;

            Dispatcher.BeginInvoke(new Action(() =>
            {
                _dataContext.Width.Value = (int)ActualWidth;
                _dataContext.Height.Value = (int)ActualHeight;
            }));

        }
    }
}