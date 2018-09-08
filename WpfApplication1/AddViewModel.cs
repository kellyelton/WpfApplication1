using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1;

namespace WpfApplication1
{
    
    public class AddViewModel:ObservableCollection<Musician>
    {
        public AddCommand AddCommand { get; set; }

        public AddViewModel()
        {
            this.AddCommand = new AddCommand(this);
        }
        public void AddMusician(Musician musician)
        {
            Add(musician);
        }
    }
}
