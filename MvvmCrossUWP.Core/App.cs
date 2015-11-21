using Cirrious.CrossCore;

namespace MvvmCrossUWP.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
			// Launch App
			RegisterAppStart<ViewModels.FirstViewModel>();
        }
    }
}