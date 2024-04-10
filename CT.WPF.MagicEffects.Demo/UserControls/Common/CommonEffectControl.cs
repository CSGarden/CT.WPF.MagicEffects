using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CT.WPF.MagicEffects.Demo.UserControls.Common {
    public class CommonEffectControl : Control {
        static CommonEffectControl() {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CommonEffectControl), new FrameworkPropertyMetadata(typeof(CommonEffectControl)));
        }
        public object Option {
            get { return (object)GetValue(OptionProperty); }
            set { SetValue(OptionProperty, value); }
        }

        public Effect ImageEffect {
            get { return (Effect)GetValue(ImageEffectProperty); }
            set { SetValue(ImageEffectProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageEffect.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageEffectProperty =
            DependencyProperty.Register("ImageEffect", typeof(Effect), typeof(CommonEffectControl), new PropertyMetadata(null));



        // Using a DependencyProperty as the backing store for Option.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OptionProperty =
            DependencyProperty.Register("Option", typeof(object), typeof(CommonEffectControl), new PropertyMetadata(null));


    }
}
