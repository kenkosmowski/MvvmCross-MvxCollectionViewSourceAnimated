using iOSApp.ViewModel;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace iOSApp
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<MainViewModel>());
        }
    }
}
