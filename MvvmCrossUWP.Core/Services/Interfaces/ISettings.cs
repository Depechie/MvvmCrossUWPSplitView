using System;

namespace MvvmCrossUWP.Core.Services.Interfaces
{
	public interface ISettings
	{
		/// <summary>
		/// Gets the current value or the default that you specify.
		/// </summary>
		/// <typeparam name="T">Vaue of t (bool, int, float, long, string)</typeparam>
		/// <param name="key">Key for settings</param>
		/// <param name="defaultValue">default value if not set</param>
		/// <returns>Value or default</returns>
		T GetValueOrDefault<T>(string key, T defaultValue = default(T));

		/// <summary>
		/// Adds or updates the value 
		/// </summary>
		/// <param name="key">Key for settting</param>
		/// <param name="value">Value to set</param>
		/// <returns>True of was added or updated and you need to save it.</returns>
		bool AddOrUpdateValue(string key, Object value);

		/// <summary>
		/// Saves any changes out.
		/// </summary>
		void Save();
	}
}