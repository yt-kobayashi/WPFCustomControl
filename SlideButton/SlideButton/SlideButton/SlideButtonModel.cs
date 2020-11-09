using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SlideButton
{
    public class SlideButtonModel
    {
    }

    public class SizeChangeCommand : ICommand
    {
        private bool _enableAccepting;                  // 受付フラグ
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _enableAccepting;
        }

        public void Execute(object parameter)
        {
            // 処理中は受付フラグを折る
            _enableAccepting = false;


            // 受付フラグを立てる
            _enableAccepting = true;
        }

        public SizeChangeCommand()
        {
            _enableAccepting = true;
        }
    }
}
