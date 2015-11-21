using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace MvvmCrossUWP.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private MvxCommand _secondCommand;
        public ICommand SecondCommand => (_secondCommand = _secondCommand ?? new MvxCommand(() => ShowViewModel<SecondViewModel>()));

        private MvxCommand _thirdCommand;
        public ICommand ThirdCommand => (_thirdCommand = _thirdCommand ?? new MvxCommand(() => ShowViewModel<ThirdViewModel>()));

        public FirstViewModel()
		{
		}
	}
}