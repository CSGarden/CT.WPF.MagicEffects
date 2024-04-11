using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Effects;

namespace CT.WPF.MagicEffects.Demo.Models.Ordinary {
    partial class Ordinarys : ObservableObject {
        [ObservableProperty]
        private string? title;
        [ObservableProperty]
        private ShaderEffect? objectShaderEffect;
    }
}
