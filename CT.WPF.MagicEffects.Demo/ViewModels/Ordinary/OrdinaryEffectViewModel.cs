using CommunityToolkit.Mvvm.ComponentModel;
using CT.WPF.MagicEffects.Demo.Models.Ordinary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT.WPF.MagicEffects.Demo.ViewModels.Ordinary {
    partial class OrdinaryEffectViewModel : ObservableObject {
        public OrdinaryEffectViewModel() {
            Ordinarys = new ObservableCollection<Ordinarys> {
                new Ordinarys(){ Title="灰度", ObjectShaderEffect= new GrayScaleEffect ()},
                new Ordinarys(){ Title="位移", ObjectShaderEffect= new DirectionalBlurEffect ()},
                new Ordinarys(){ Title="老电影", ObjectShaderEffect= new OldMovieEffect ()},
                new Ordinarys(){ Title="锐化", ObjectShaderEffect= new SharpenEffect ()},
            };
        }
        [ObservableProperty]
        private ObservableCollection<Ordinarys> ordinarys;
        [ObservableProperty]
        private Ordinarys selectedOrdinary;
    }
}
