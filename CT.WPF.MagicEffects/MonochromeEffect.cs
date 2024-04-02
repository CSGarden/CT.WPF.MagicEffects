using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Windows.Media.Effects;

namespace CT.WPF.MagicEffects {
    public class MonochromeEffect:ShaderEffect {
        public static readonly DependencyProperty InputProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("Input",typeof(MonochromeEffect),0);
        public static readonly DependencyProperty FilterColorProperty = DependencyProperty.Register("FilterColor",typeof(Color),typeof(MonochromeEffect),new UIPropertyMetadata(Color.FromArgb(255,255,255,0),PixelShaderConstantCallback(0)));
        public MonochromeEffect() {
            PixelShader pixelShader = new PixelShader();
            pixelShader.UriSource = new Uri("/Shaders/MonochromeEffect.ps",UriKind.Relative);
            this.PixelShader = pixelShader;

            this.UpdateShaderValue(InputProperty);
            this.UpdateShaderValue(FilterColorProperty);
        }
        public Brush Input {
            get {
                return ((Brush)(this.GetValue(InputProperty)));
            }
            set {
                this.SetValue(InputProperty,value);
            }
        }
        /// <summary>The color used to tint the input.</summary>
        public Color FilterColor {
            get {
                return ((Color)(this.GetValue(FilterColorProperty)));
            }
            set {
                this.SetValue(FilterColorProperty,value);
            }
        }
    }
}
