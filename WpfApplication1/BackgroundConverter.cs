using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApplication1
{
    public class BackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.Equals(true))
            {
                return new SolidColorBrush(new Color()
                {
                    A = 255,
                    R = 0,
                    G = 255,
                    B = 0
                });
            }
            else
                return new SolidColorBrush(new Color()
                {
                    A = 255,
                    R = 255,
                    G = 0,
                    B = 0
                });
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
