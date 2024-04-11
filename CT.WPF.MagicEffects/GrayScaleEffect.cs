using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Windows.Media.Effects;

namespace CT.WPF.MagicEffects {
    public class GrayScaleEffect : ShaderEffect {
        public static readonly DependencyProperty InputProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("Input",typeof(GrayScaleEffect),0);
        public GrayScaleEffect() {
            PixelShader pixelShader = new PixelShader();
            pixelShader.UriSource = new Uri("pack://application:,,,/CT.WPF.MagicEffects;component/Shaders/GrayScaleEffect.ps",UriKind.Absolute);
            this.PixelShader = pixelShader;

            this.UpdateShaderValue(InputProperty);
        }
        public Brush Input {
            get {
                return ((Brush)(this.GetValue(InputProperty)));
            }
            set {
                this.SetValue(InputProperty,value);
            }
        }
    }
}
