using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace CT.WPF.MagicEffects.Demo.Converters {
    public class BoolToVisibilityReConvert : IValueConverter  {
        /// <summary>
        /// 将<see langword="bool"/> 转化为<see cref="Visibility"/>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value,Type targetType,object parameter,CultureInfo culture) {
            return System.Convert.ToBoolean(value) ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value,Type targetType,object parameter,CultureInfo culture) {
            return ((Visibility)Enum.Parse(typeof(Visibility),value.ToString())).Equals(Visibility.Collapsed);
        }
    }
}
