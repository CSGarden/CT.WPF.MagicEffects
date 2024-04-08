using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Windows.Media.Effects;

namespace CT.WPF.MagicEffects {

    public class TexturedColorReplaceEffect : ShaderEffect {
        public static readonly DependencyProperty InputProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("Input",typeof(TexturedColorReplaceEffect),0);
        public static readonly DependencyProperty TargetColorProperty = DependencyProperty.Register("TargetColor",typeof(Color),typeof(TexturedColorReplaceEffect),new UIPropertyMetadata(Color.FromArgb(255,0,0,0),PixelShaderConstantCallback(0)));
        public static readonly DependencyProperty ReplacementColorProperty = DependencyProperty.Register("ReplacementColor",typeof(Color),typeof(TexturedColorReplaceEffect),new UIPropertyMetadata(Color.FromArgb(255,255,255,255),PixelShaderConstantCallback(1)));
        public static readonly DependencyProperty ThresholdProperty = DependencyProperty.Register("Threshold",typeof(double),typeof(TexturedColorReplaceEffect),new UIPropertyMetadata(((double)(0D)),PixelShaderConstantCallback(3)));
        public static readonly DependencyProperty ToleranceProperty = DependencyProperty.Register("Tolerance",typeof(double),typeof(TexturedColorReplaceEffect),new UIPropertyMetadata(((double)(0.3D)),PixelShaderConstantCallback(2)));

        public TexturedColorReplaceEffect() {
            PixelShader pixelShader = new PixelShader();
            pixelShader.UriSource = new Uri("pack://application:,,,/CT.WPF.MagicEffects;component/Shaders/TexturedColorReplaceEffect.ps",UriKind.Absolute);
            this.PixelShader = pixelShader;

            this.UpdateShaderValue(InputProperty);
            this.UpdateShaderValue(TargetColorProperty);
            this.UpdateShaderValue(ReplacementColorProperty);
            this.UpdateShaderValue(ThresholdProperty);
            this.UpdateShaderValue(ToleranceProperty);
        }

        public Brush Input {
            get {
                return ((Brush)(this.GetValue(InputProperty)));
            }
            set {
                this.SetValue(InputProperty,value);
            }
        }

        public Color TargetColor {
            get {
                return ((Color)(this.GetValue(TargetColorProperty)));
            }
            set {
                this.SetValue(TargetColorProperty,value);
            }
        }

        public Color ReplacementColor {
            get {
                return ((Color)(this.GetValue(ReplacementColorProperty)));
            }
            set {
                this.SetValue(ReplacementColorProperty,value);
            }
        }

        public double Threshold {
            get {
                return ((double)(this.GetValue(ThresholdProperty)));
            }
            set {
                this.SetValue(ThresholdProperty,value);
            }
        }

        public double Tolerance {
            get {
                return ((double)(this.GetValue(ToleranceProperty)));
            }
            set {
                this.SetValue(ToleranceProperty,value);
            }
        }
    }
}