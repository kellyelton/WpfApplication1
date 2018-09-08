using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication1
{
    public class CheckBoxViewModel
    {        
        public ClickCommand ClickCommand { get; set; }

        public CheckBoxViewModel()
        {
            this.ClickCommand = new ClickCommand(this);
        }
        public void Click()
        {
            
        }
    }
}
