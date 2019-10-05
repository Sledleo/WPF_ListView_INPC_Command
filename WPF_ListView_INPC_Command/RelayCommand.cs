﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_ListView_INPC_Command
{
    class RelayCommand : ICommand
    {
        private readonly Action<object> _action;

        public RelayCommand(Action<object> action) { _action = action; }

        public bool CanExecute(object parameter) { return true; }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter) { _action(parameter); }
    }
}
