using System.Globalization;
using Windows.Security.ExchangeActiveSyncProvisioning;
using MvvmCrossUWP.Core.Services.Interfaces;

namespace MvvmCrossUWP.Win.Services
{
	public class WinDevice : IDevice
	{
		static readonly EasClientDeviceInformation deviceInfo = new EasClientDeviceInformation();

		#region Properties

		public string Language
		{
			get
			{
				return CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
			}
		}

		public string Manufacturer
		{
			get
			{
				return deviceInfo.SystemManufacturer;
			}
		}

		public string Model
		{
			get
			{
				return deviceInfo.SystemProductName;
			}
		}

		public string OSName
		{
			get
			{
				return deviceInfo.OperatingSystem;
			}
		}

		public bool IsSimulator
		{
			get
			{
				return (deviceInfo.SystemProductName == "Virtual");
			}
		}

		public string AppVersion
		{
			get
			{
				var id = Windows.ApplicationModel.Package.Current.Id;
				return string.Format("{0}.{1}.{2}",
					id.Version.Major, id.Version.Minor, id.Version.Build);
			}
		}

		public int AppVersionCode
		{
			get
			{
				var id = Windows.ApplicationModel.Package.Current.Id;
				return id.Version.Revision;
			}
		}

		public string SerialNumber
		{
			get
			{
				return deviceInfo.SystemSku;
			}
		}

		public string SystemVersion
		{
			get
			{
				return deviceInfo.SystemFirmwareVersion;
			}
		}

		#endregion
	}
}
