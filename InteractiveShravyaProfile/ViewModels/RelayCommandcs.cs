using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModels
{

    public class RelayCommand : ICommand
    {
        private readonly Action<object> _methodToExecute;
        private readonly Predicate<object> _canExecuteEvaluator;

        public RelayCommand(Action<object> methodToExecute, Predicate<object> canExecuteEvaluator)
        {
            this._methodToExecute = methodToExecute;
            this._canExecuteEvaluator = canExecuteEvaluator;
        }
        public RelayCommand(Action<object> methodToExecute) : this(methodToExecute, null) { }
        public void Execute(object parameter)
        {
            _methodToExecute(parameter);

        }
        public bool CanExecute(object parameter)
        {
            return _canExecuteEvaluator == null ? true : _canExecuteEvaluator(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }




    }
}
