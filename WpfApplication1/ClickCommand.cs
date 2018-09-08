using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication1
{
    public class ClickCommand : ICommand
    {
        public CheckBoxViewModel ViewModel { get; set; }

        public ClickCommand(CheckBoxViewModel viewModel)
        {
            this.ViewModel = viewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {         
            this.ViewModel.Click();
        }
    }
}
