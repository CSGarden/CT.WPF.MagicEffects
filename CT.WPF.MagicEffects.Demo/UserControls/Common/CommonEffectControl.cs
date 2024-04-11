using OpenCvSharp;
using OpenCvSharp.WpfExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CT.WPF.MagicEffects.Demo.UserControls.Common {
    public class CommonEffectControl : Control {
        private Image videoImage;
        static CommonEffectControl() {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CommonEffectControl), new FrameworkPropertyMetadata(typeof(CommonEffectControl)));
        }
        private VideoCapture capture;
        private CascadeClassifier cascadeClassifier;
        private BackgroundWorker bkgWorker;
        public CommonEffectControl() {
            Loaded += CommonEffectControl_Loaded;
        }

        private void CommonEffectControl_Loaded(object sender, RoutedEventArgs e) {
            videoImage.Loaded += VideoImage_Loaded;
            videoImage.Unloaded += VideoImage_Unloaded;
        }
        private void VideoImage_Unloaded(object sender, RoutedEventArgs e) {
            bkgWorker?.CancelAsync();
            capture?.Dispose();
            cascadeClassifier?.Dispose();

            capture = null;
            cascadeClassifier = null;
            bkgWorker = null;
        }

        private void VideoImage_Loaded(object sender, RoutedEventArgs e) {
            capture = new VideoCapture(1, VideoCaptureAPIs.DSHOW);
            cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_default.xml");

            bkgWorker = new BackgroundWorker { WorkerSupportsCancellation = true };
            bkgWorker.DoWork += Worker_DoWork;
            if (!capture.IsOpened()) {
                capture.Dispose();
                capture = new VideoCapture(0, VideoCaptureAPIs.DSHOW);
            }
            bkgWorker.RunWorkerAsync();

        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e) {
            var worker = (BackgroundWorker)sender;
            while (!worker.CancellationPending) {
                if (capture != null) {
                    using (var frameMat = capture.RetrieveMat()) {
                        var rects = cascadeClassifier.DetectMultiScale(frameMat, 1.1, 5, HaarDetectionTypes.ScaleImage, new OpenCvSharp.Size(30, 30));

                        foreach (var rect in rects) {
                            Cv2.Rectangle(frameMat, rect, Scalar.Red);
                        }

                        // Must create and use WriteableBitmap in the same thread(UI Thread).
                        Dispatcher.Invoke(() => {
                            videoImage.Source = frameMat.ToWriteableBitmap();
                        });
                    }
                }
                Thread.Sleep(30);
            }
        }

        public override void OnApplyTemplate() {
            base.OnApplyTemplate();
            videoImage = GetTemplateChild("PartVideoImage") as Image;
        }
        public object Option {
            get { return (object)GetValue(OptionProperty); }
            set { SetValue(OptionProperty, value); }
        }

        public Effect ImageEffect {
            get { return (Effect)GetValue(ImageEffectProperty); }
            set { SetValue(ImageEffectProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageEffect.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageEffectProperty =
            DependencyProperty.Register("ImageEffect", typeof(Effect), typeof(CommonEffectControl), new PropertyMetadata(null));



        // Using a DependencyProperty as the backing store for Option.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OptionProperty =
            DependencyProperty.Register("Option", typeof(object), typeof(CommonEffectControl), new PropertyMetadata(null));


    }
}
