using CommunityToolkit.Mvvm.ComponentModel;
using CT.WPF.MagicEffects.Demo.Views;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CT.WPF.MagicEffects.Demo.ViewModels {
    public partial class MainViewModel : ObservableObject {
        [ObservableProperty]
        private string title = "效果demo";

        [ObservableProperty]
        private int selectedModularIndex;

        [ObservableProperty]
        private SolidColorBrush mainBackground = new SolidColorBrush(Color.FromRgb(255,255,255));
        partial void OnSelectedModularIndexChanged(int value) {
            if (value == 2)
                MainBackground = new SolidColorBrush(Color.FromRgb(28,64,139));
            else if (value == 3)
                MainBackground = new SolidColorBrush(Color.FromRgb(250,251,252));
            else
                MainBackground = new SolidColorBrush(Color.FromRgb(255,255,255));
        }


        #region 页面跳转
        [ObservableProperty]
        private UserControl topOnePage = new TopOnePage();
        #endregion
    }
}
