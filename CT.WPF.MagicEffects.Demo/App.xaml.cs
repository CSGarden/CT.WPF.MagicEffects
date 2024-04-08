using AduSkin.Controls.Metro;
using System.Text;
using System.Windows;

namespace CT.WPF.MagicEffects.Demo {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {

        protected override void OnStartup(StartupEventArgs e) {
            var splashScreen = new SplashScreen("Images/Resources/Start.png");
            splashScreen.Show(false);
            splashScreen.Close(TimeSpan.FromMilliseconds(100));
            base.OnStartup(e);
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            NoticeManager.Initialize();
        }

        protected override void OnExit(ExitEventArgs e) {
            NoticeManager.ExitNotification();
            base.OnExit(e);
        }
    }

}
