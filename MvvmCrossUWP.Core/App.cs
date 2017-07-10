
namespace MvvmCrossUWP.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
			// Launch App
			RegisterAppStart<ViewModels.FirstViewModel>();
        }
    }
}