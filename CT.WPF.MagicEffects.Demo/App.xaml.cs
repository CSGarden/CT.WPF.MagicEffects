using AduSkin.Controls.Metro;
using System.Windows;

namespace CT.WPF.MagicEffects.Demo {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        protected override void OnStartup(StartupEventArgs e) {
            new SplashScreen("Images/Resources/Start.png").Show(true);
            base.OnStartup(e);
            NoticeManager.Initialize();
        }

        protected override void OnExit(ExitEventArgs e) {
            NoticeManager.ExitNotifiaction();
            base.OnExit(e);
        }
    }

}
