using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace CT.WPF.MagicEffects.Demo.Models.ToneMapping {
    partial class ToneMappingEffectOptions : ObservableObject {
        public string? Name { get; set; }
        [ObservableProperty]
        private double? gamma;
        [ObservableProperty]
        private double? defog;
        [ObservableProperty]
        private double? blueShift;
        [ObservableProperty]
        private Color fogColor;
        [ObservableProperty]
        private double? exposure;
        [ObservableProperty]
        private double? vignetteAmount;
        [ObservableProperty]
        private Point? vignetteCenter;
        [ObservableProperty]
        private double? vignetteRadius;

    }
}
