using Windows.UI.Xaml.Controls;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Uwp.Platform;
using MvvmCross.Uwp.Views;
using MvvmCrossUWP.Core.Services.Interfaces;
using MvvmCrossUWP.Win.Services;

namespace MvvmCrossUWP.Win
{
    class Setup : MvxWindowsSetup
	{
		#region Constructor

		public Setup(Frame rootFrame) : base(rootFrame)
		{
		}

		#endregion

		#region Methods [protected]

		protected override IMvxApplication CreateApp()
		{
			return new MvvmCrossUWP.Core.App();
		}

		protected override void InitializeFirstChance()
		{
			Mvx.ConstructAndRegisterSingleton<ISettings, WinSettings>();
			Mvx.ConstructAndRegisterSingleton<IDevice, WinDevice>();
		}

		protected override void InitializePlatformServices()
		{
			base.InitializePlatformServices();
		}

        protected override IMvxWindowsViewPresenter CreateViewPresenter(IMvxWindowsFrame rootFrame)
        {
            return new MvxWindowsMultiRegionViewPresenter(rootFrame);
        }

        #endregion
	}
}