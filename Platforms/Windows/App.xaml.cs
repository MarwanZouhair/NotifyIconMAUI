using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using WinRT.Interop;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NotifyIconMAUI.WinUI
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : MauiWinUIApplication
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            base.OnLaunched(args);

            var nativeWindow = GetNativeWindow();
            nativeWindow?.Hide(); // Hide window immediately before it's displayed
        }

        private AppWindow? GetNativeWindow()
        {
            if (Application.Windows.Count == 0)
                return null;

            var mauiWindow = Application.Windows[0]; // Get the first window
            var nativeWinUIWindow = (mauiWindow?.Handler?.PlatformView as Microsoft.UI.Xaml.Window);

            if (nativeWinUIWindow == null)
                return null;

            IntPtr hWnd = WindowNative.GetWindowHandle(nativeWinUIWindow);
            var id = Win32Interop.GetWindowIdFromWindow(hWnd);
            return AppWindow.GetFromWindowId(id);
        }
    }
}
