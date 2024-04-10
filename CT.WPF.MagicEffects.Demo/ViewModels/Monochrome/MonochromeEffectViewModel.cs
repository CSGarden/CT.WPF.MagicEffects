using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CT.WPF.MagicEffects.Demo.Models.Monochrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace CT.WPF.MagicEffects.Demo.ViewModels.Monochrome {
    partial class MonochromeEffectViewModel : ObservableObject {
        [ObservableProperty]
        private string selectedImagePath;
        [ObservableProperty]
        private EffectOption selectedEffectOption;
        [ObservableProperty]
        private ObservableCollection<EffectOption> effectOptions;
        [ObservableProperty]
        private ObservableCollection<string> imagePaths = new   ObservableCollection<string>();    
        [RelayCommand]
        public void SelectImage(RoutedPropertyChangedEventArgs<object> e) {
            SelectedImagePath = (e.NewValue as string[])[0];
        }
        public MonochromeEffectViewModel() {
            EffectOptions = new ObservableCollection<EffectOption>
            {
            new EffectOption() { Name = "银色", FilterColor = Color.FromRgb(192, 192, 192)},
            new EffectOption() { Name = "蓝色", FilterColor = Color.FromRgb(0, 0, 255)},
            new EffectOption() { Name = "白色",FilterColor = Color.FromRgb(255, 255, 255)},
            new EffectOption() { Name = "红色", FilterColor = Color.FromRgb(255, 106, 106)},
            new EffectOption() { Name = "绿色", FilterColor = Color.FromRgb(0, 255, 0)},
            new EffectOption() { Name = "黄色", FilterColor = Color.FromRgb(255, 255, 0)},
            new EffectOption() { Name = "紫色", FilterColor = Color.FromRgb(255, 0, 255)},
            new EffectOption() { Name = "青色", FilterColor = Color.FromRgb(0, 255, 255)},
            new EffectOption() { Name = "栗色", FilterColor = Color.FromRgb(128, 0, 0)},
            new EffectOption() { Name = "OldLace", FilterColor = Color.FromRgb(253 ,245 ,230)},
            new EffectOption() { Name = "DarkSeaGreen1", FilterColor = Color.FromRgb(193 ,255 ,193)},
            new EffectOption() { Name = "LightSlateBlue", FilterColor = Color.FromRgb(132 ,112 ,255)},
            new EffectOption() { Name = "HotPink", FilterColor = Color.FromRgb(255 ,105 ,180)},

            };
            if (EffectOptions.Any()) {
                SelectedEffectOption = EffectOptions[0];
            }
        }

        [RelayCommand]
        public void ChangeFilterColor(SolidColorBrush brush) {
            SelectedEffectOption.FilterColor = brush.Color;
        }
    }
}
