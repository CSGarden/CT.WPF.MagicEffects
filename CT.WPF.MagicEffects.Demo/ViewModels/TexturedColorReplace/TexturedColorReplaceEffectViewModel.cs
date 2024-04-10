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
        private Color targetColor;

        [RelayCommand]
        public void SetTargetColor(SolidColorBrush targetColor) {
            TargetColor = targetColor.Color;
        }

        [ObservableProperty]
        private Color replacementColor;

        [RelayCommand]
        public void SetReplacementColor(SolidColorBrush replacementColor) {
            ReplacementColor = replacementColor.Color;
        }

        [ObservableProperty]
        private double threshold=0.33;

        [ObservableProperty]
        private double tolerance=0.54;
    }
}
