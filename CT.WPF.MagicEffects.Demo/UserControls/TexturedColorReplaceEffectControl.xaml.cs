using CT.WPF.MagicEffects.Demo.ViewModels.TexturedColorReplace;
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
    /// TexturedColorReplaceEffectControl.xaml 的交互逻辑
    /// </summary>
    public partial class TexturedColorReplaceEffectControl : UserControl {
        public TexturedColorReplaceEffectControl() {
            InitializeComponent();
            //replaceEffect = this.DataContext as TexturedColorReplaceEffectViewModel;
        }
        //private TexturedColorReplaceEffectViewModel replaceEffect;
        //private void BeforeColor_ColorChange(object sender,EventArgs e) {
        //    if (BeforeColor.Background is SolidColorBrush solid) {
        //        replaceEffect.SetTargetColorCommand.Execute(solid.Color);
        //    }
        //}

        //private void AfterColor_ColorChange(object sender,EventArgs e) {
        //    if (AfterColor.Background is SolidColorBrush solid) {
        //        replaceEffect.SetReplacementColorCommand.Execute(solid.Color);
        //    }
        //}
    }
}
