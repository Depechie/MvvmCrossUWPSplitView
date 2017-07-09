using Windows.UI.Xaml.Navigation;
using MvvmCross.Uwp.Views;

namespace MvvmCrossUWP.Win.Views
{
	public class BaseView : MvxWindowsPage
	{
		#region Lifecycle

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			base.OnNavigatedTo(e);
		}

		protected override void OnNavigatedFrom(NavigationEventArgs e)
		{
			base.OnNavigatedFrom(e);
		}

		#endregion
	}
}