using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFBank.Commands
{
    public class RelayCommand : ICommand
    {

        //Delegates created
        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;

        //execute
        public RelayCommand(Action<object> execute) : this(execute, null)
        { }

        //execute , canexecute
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute method is missing");
            }
            _execute = execute;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)  // when to execute
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public void Execute(object parameter)  //what to execute
        {
            _execute(parameter);  //delegate invoke - method invoke
        }

    }
}
