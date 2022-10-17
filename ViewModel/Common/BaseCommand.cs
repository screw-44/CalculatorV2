using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Input;

namespace CalculatorV2.ViewModel.Common
{
    public class BaseCommand : ICommand
    {
        private Func<object, bool> _canExecute;
        private Action<object> _execute;

        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_canExecute != null)
                {
                    CommandManager.RequerySuggested += value;
                }
            }
            remove
            {
                if (_canExecute != null)
                {
                    CommandManager.RequerySuggested -= value;
                }
            }
        }
        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
            {
                return true;
            }
            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            if (_execute != null && CanExecute(parameter))
            {
                _execute(parameter);
            }
        }

        public BaseCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            _canExecute = canExecute;
            _execute = execute;
        }

        public BaseCommand(Action<object> execute) : this(execute, null)
        {
        }

    }
}
