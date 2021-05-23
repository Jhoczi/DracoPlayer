using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MultimediaPlayer
{
    class CommandComponent : ICommand
    {
        private readonly Action<object> _exe;
        private readonly Predicate<object> _canExecute;

        public CommandComponent(Action<object> execute, Predicate<object> canExecute)
        {
            _exe = execute;
            _canExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
                return true;
            else
                return _canExecute(parameter);
        }
        public void Execute(object parameter)
        {
            _exe(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add 
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

    }
}
