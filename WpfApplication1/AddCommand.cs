using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfApplication1
{  
    public class AddCommand : ICommand
    {
        public AddViewModel ViewModel { get; set; }

        public AddCommand(AddViewModel viewModel)
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
            var win = (FrameworkElement)parameter;
            var musician = (Musician)win.DataContext;
            this.ViewModel.AddMusician(musician);
            win.DataContext = new Musician();
        }
    }
}
