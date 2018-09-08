using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var editableMusician = (Musician)parameter;

            var clonedMusician = (Musician)editableMusician.Clone();

            editableMusician.Clear();

            this.ViewModel.AddMusician(clonedMusician);
        }
    }
}
