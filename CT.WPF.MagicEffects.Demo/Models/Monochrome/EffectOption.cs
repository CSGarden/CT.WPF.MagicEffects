using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CT.WPF.MagicEffects.Demo.Models.Monochrome {
    public partial class EffectOption : ObservableObject {
        public string? Name { get; set; }
        [ObservableProperty]
        private Color filterColor;
    }
}
