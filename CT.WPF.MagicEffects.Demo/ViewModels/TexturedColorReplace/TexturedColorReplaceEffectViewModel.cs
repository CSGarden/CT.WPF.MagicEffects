using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace CT.WPF.MagicEffects.Demo.ViewModels.TexturedColorReplace {
    partial class TexturedColorReplaceEffectViewModel : ObservableObject {
        [ObservableProperty]
        private string selectedImagePath;
        [RelayCommand]
        public void SelectImage(RoutedPropertyChangedEventArgs<object> e) {
            SelectedImagePath = (e.NewValue as string[])[0];
        }
        [ObservableProperty]
        private Color targetColor;
        [RelayCommand]
        public void SetTargetColor(Color targetColor) {
            TargetColor = targetColor;
        }

        [ObservableProperty]
        private Color replacementColor;
        [RelayCommand]
        public void SetReplacementColor(Color replacementColor) {
            ReplacementColor = replacementColor;
        }

        [ObservableProperty]
        private double threshold=0.33;

        [ObservableProperty]
        private double tolerance=0.54;
    }
}
