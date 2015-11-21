namespace MvvmCrossUWP.Core.Services.Interfaces
{
	public interface IDevice
	{
		string Language { get; }

		string Manufacturer { get; }

		string Model { get; }

		string OSName { get; }

		bool IsSimulator { get; }

		string AppVersion { get; }

		int AppVersionCode { get; }

		string SerialNumber { get; }

		string SystemVersion { get; }
	}
}