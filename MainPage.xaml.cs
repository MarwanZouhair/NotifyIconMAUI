using H.NotifyIcon;
using CommunityToolkit.Mvvm.Input;

namespace NotifyIconMAUI
{
    public partial class MainPage : ContentPage
    {
        private bool IsWindowVisible { get; set; } = false;
        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        [RelayCommand]
        public void ShowHideWindow()
        {
            var window = Application.Current?.Windows[0];
            if (window == null)
            {
                return;
            }

            if (IsWindowVisible)
            {
                window.Hide();
            }
            else
            {
                window.Show();
            }
            IsWindowVisible = !IsWindowVisible;
        }

        [RelayCommand]
        public void ExitApplication()
        {
            Application.Current?.Quit();
        }
    }
}
