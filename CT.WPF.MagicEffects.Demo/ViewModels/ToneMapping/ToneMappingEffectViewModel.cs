using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CT.WPF.MagicEffects.Demo.Models.ToneMapping;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CT.WPF.MagicEffects.Demo.ViewModels.ToneMapping {
    partial class ToneMappingEffectViewModel : ObservableObject {
        [ObservableProperty]
        private ObservableCollection<ToneMappingEffectOptions> effectOptions;
        [ObservableProperty]
        private ToneMappingEffectOptions selectedEffectOption;
        public ToneMappingEffectViewModel() {
            EffectOptions = new ObservableCollection<ToneMappingEffectOptions> {
                 new ToneMappingEffectOptions() { Name = "无", Gamma = null, Defog = null, BlueShift = null, FogColor = Colors.Transparent, Exposure = null, VignetteAmount = null, VignetteCenter =null, VignetteRadius = null },
                 new ToneMappingEffectOptions() { Name = "1", Gamma = 1.8, Defog = 0.09, BlueShift = -0.07, FogColor = Colors.Red, Exposure = 0.14, VignetteAmount = 0.0, VignetteCenter = new System.Windows.Point(0.5,0.5), VignetteRadius = 0.5 },
                 new ToneMappingEffectOptions() { Name = "2", Gamma = 0.5, Defog = 0.18, BlueShift = 0.40, FogColor = Colors.Gray, Exposure = -0.20, VignetteAmount = 0.0, VignetteCenter = new System.Windows.Point(0.5, 0.5), VignetteRadius = 1.0 },
                 new ToneMappingEffectOptions() { Name = "3", Gamma = 2.2, Defog = 0.05, BlueShift = 0.0, FogColor = Colors.Blue, Exposure = 0.07, VignetteAmount = 0.0, VignetteCenter = new System.Windows.Point(0.5, 0.5), VignetteRadius = 1.0 },
                 new ToneMappingEffectOptions() { Name = "4", Gamma = 1.0, Defog = 0.18, BlueShift = 0.20, FogColor = Colors.Yellow, Exposure = 0.20, VignetteAmount = 0.0, VignetteCenter = new System.Windows.Point(0.5,0.5), VignetteRadius = 1.0 },
                 new ToneMappingEffectOptions() { Name = "5", Gamma = 0.55, Defog = 0.09,BlueShift = 0.33, FogColor = Colors.LightGray, Exposure = 0.20, VignetteAmount = 0.0, VignetteCenter = new System.Windows.Point(0.5,0.5), VignetteRadius = 1.0 },
                 new ToneMappingEffectOptions() { Name = "6", Gamma = 0.97, Defog = 0.17,BlueShift = 0.33, FogColor = Colors.Orange, Exposure = 0.30, VignetteAmount = 0.0, VignetteCenter = new System.Windows.Point(0.5,0.5), VignetteRadius = 1.0 },
                 new ToneMappingEffectOptions() { Name = "7", Gamma = 1.15, Defog = 0.17,BlueShift = 0.00, FogColor = Colors.LightGreen, Exposure = 0.20, VignetteAmount = -1.0, VignetteCenter = new System.Windows.Point(0.5,0.5), VignetteRadius = 1.0 },


               };
            if (EffectOptions.Any()) {
                SelectedEffectOption = EffectOptions[0];
            }
        }
    }
}
