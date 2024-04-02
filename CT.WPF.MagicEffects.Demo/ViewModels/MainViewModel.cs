using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT.WPF.MagicEffects.Demo.ViewModels {
    internal partial class MainViewModel : ObservableObject {
        [ObservableProperty]
        private string title="标题";
    }
}
