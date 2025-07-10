using CommunityToolkit.Maui.Alerts;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void WebView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            // Show a toast when navigation starts
            Toast.Make(e.Url, CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
        }

        private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            // No action needed here for now
        }
    }
}
