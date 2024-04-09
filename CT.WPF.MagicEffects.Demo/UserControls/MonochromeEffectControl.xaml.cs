using CommunityToolkit.Mvvm.Input;
using CT.WPF.MagicEffects.Demo.ViewModels.Monochrome;
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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CT.WPF.MagicEffects.Demo.UserControls {
    /// <summary>
    /// MonochromeEffectControl.xaml 的交互逻辑
    /// </summary>
    public partial class MonochromeEffectControl : UserControl {
        public MonochromeEffectControl() {
            InitializeComponent();
            monochromeViewModel = this.DataContext as MonochromeEffectViewModel;

        }
        private MonochromeEffectViewModel monochromeViewModel;
        private void ColorPicker_ColorChange(object sender,EventArgs e) {
            if (ColorPicker.Background is SolidColorBrush solid) {
                monochromeViewModel.ChangeFilterColorCommand.Execute(solid.Color);
            }
        }
    }
}
