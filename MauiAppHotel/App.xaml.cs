using Microsoft.Extensions.DependencyInjection;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {

            var w = new Window(new AppShell());
            w.Height = 1040;
            w.Width = 450;
            return w;
        }
    }
}