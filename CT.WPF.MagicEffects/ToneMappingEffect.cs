using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Windows.Media.Effects;

namespace CT.WPF.MagicEffects {
    public class ToneMappingEffect:ShaderEffect {
        public static readonly DependencyProperty InputProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("Input",typeof(ToneMappingEffect),0);
        public static readonly DependencyProperty DefogProperty = DependencyProperty.Register("Defog",typeof(double),typeof(ToneMappingEffect),new UIPropertyMetadata(((double)(0.01D)),PixelShaderConstantCallback(0)));
        public static readonly DependencyProperty FogColorProperty = DependencyProperty.Register("FogColor",typeof(Color),typeof(ToneMappingEffect),new UIPropertyMetadata(Color.FromArgb(255,255,255,255),PixelShaderConstantCallback(1)));
        public static readonly DependencyProperty ExposureProperty = DependencyProperty.Register("Exposure",typeof(double),typeof(ToneMappingEffect),new UIPropertyMetadata(((double)(0.2D)),PixelShaderConstantCallback(2)));
        public static readonly DependencyProperty GammaProperty = DependencyProperty.Register("Gamma",typeof(double),typeof(ToneMappingEffect),new UIPropertyMetadata(((double)(0.8D)),PixelShaderConstantCallback(3)));
        public static readonly DependencyProperty VignetteCenterProperty = DependencyProperty.Register("VignetteCenter",typeof(Point),typeof(ToneMappingEffect),new UIPropertyMetadata(new Point(0.5D,0.5D),PixelShaderConstantCallback(4)));
        public static readonly DependencyProperty VignetteRadiusProperty = DependencyProperty.Register("VignetteRadius",typeof(double),typeof(ToneMappingEffect),new UIPropertyMetadata(((double)(1D)),PixelShaderConstantCallback(5)));
        public static readonly DependencyProperty VignetteAmountProperty = DependencyProperty.Register("VignetteAmount",typeof(double),typeof(ToneMappingEffect),new UIPropertyMetadata(((double)(-1D)),PixelShaderConstantCallback(6)));
        public static readonly DependencyProperty BlueShiftProperty = DependencyProperty.Register("BlueShift",typeof(double),typeof(ToneMappingEffect),new UIPropertyMetadata(((double)(0.25D)),PixelShaderConstantCallback(7)));
        public ToneMappingEffect() {
            PixelShader pixelShader = new PixelShader();
            pixelShader.UriSource = new Uri("/Shaders/ToneMappingEffect.ps",UriKind.Relative);
            this.PixelShader = pixelShader;

            this.UpdateShaderValue(InputProperty);
            this.UpdateShaderValue(DefogProperty);
            this.UpdateShaderValue(FogColorProperty);
            this.UpdateShaderValue(ExposureProperty);
            this.UpdateShaderValue(GammaProperty);
            this.UpdateShaderValue(VignetteCenterProperty);
            this.UpdateShaderValue(VignetteRadiusProperty);
            this.UpdateShaderValue(VignetteAmountProperty);
            this.UpdateShaderValue(BlueShiftProperty);
        }
        public Brush Input {
            get {
                return ((Brush)(this.GetValue(InputProperty)));
            }
            set {
                this.SetValue(InputProperty,value);
            }
        }
        /// <summary>The amount of fog to remove.</summary>
        public double Defog {
            get {
                return ((double)(this.GetValue(DefogProperty)));
            }
            set {
                this.SetValue(DefogProperty,value);
            }
        }
        /// <summary>The fog color.</summary>
        public Color FogColor {
            get {
                return ((Color)(this.GetValue(FogColorProperty)));
            }
            set {
                this.SetValue(FogColorProperty,value);
            }
        }
        /// <summary>The exposure adjustment.</summary>
        public double Exposure {
            get {
                return ((double)(this.GetValue(ExposureProperty)));
            }
            set {
                this.SetValue(ExposureProperty,value);
            }
        }
        /// <summary>The gamma correction exponent.</summary>
        public double Gamma {
            get {
                return ((double)(this.GetValue(GammaProperty)));
            }
            set {
                this.SetValue(GammaProperty,value);
            }
        }
        /// <summary>The center of vignetting.</summary>
        public Point VignetteCenter {
            get {
                return ((Point)(this.GetValue(VignetteCenterProperty)));
            }
            set {
                this.SetValue(VignetteCenterProperty,value);
            }
        }
        /// <summary>The radius of vignetting.</summary>
        public double VignetteRadius {
            get {
                return ((double)(this.GetValue(VignetteRadiusProperty)));
            }
            set {
                this.SetValue(VignetteRadiusProperty,value);
            }
        }
        /// <summary>The amount of vignetting.</summary>
        public double VignetteAmount {
            get {
                return ((double)(this.GetValue(VignetteAmountProperty)));
            }
            set {
                this.SetValue(VignetteAmountProperty,value);
            }
        }
        /// <summary>The amount of blue shift.</summary>
        public double BlueShift {
            get {
                return ((double)(this.GetValue(BlueShiftProperty)));
            }
            set {
                this.SetValue(BlueShiftProperty,value);
            }
        }
    }
}
