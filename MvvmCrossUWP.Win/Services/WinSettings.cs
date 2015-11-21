﻿using Windows.Storage;
using MvvmCrossUWP.Core.Services.Interfaces;

namespace MvvmCrossUWP.Win.Services
{
	public class WinSettings : ISettings
	{
		private static ApplicationDataContainer Settings
		{
			get { return ApplicationData.Current.LocalSettings; }
		}

		private readonly object m_Locker = new object();

		/// <summary>
		/// Gets the current value or the default that you specify.
		/// </summary>
		/// <typeparam name="T">Vaue of t (bool, int, float, long, string)</typeparam>
		/// <param name="key">Key for settings</param>
		/// <param name="defaultValue">default value if not set</param>
		/// <returns>Value or default</returns>
		public T GetValueOrDefault<T>(string key, T defaultValue = default(T))
		{
			T value;
			lock (m_Locker)
			{
				// If the key exists, retrieve the value.
				if (Settings.Values.ContainsKey(key))
				{
					value = (T)Settings.Values[key];
				}
				// Otherwise, use the default value.
				else
				{
					value = defaultValue;
				}
			}

			return value;
		}

		/// <summary>
		/// Adds or updates the value 
		/// </summary>
		/// <param name="key">Key for settting</param>
		/// <param name="value">Value to set</param>
		/// <returns>True of was added or updated and you need to save it.</returns>
		public bool AddOrUpdateValue(string key, object value)
		{
			bool valueChanged = false;
			lock (m_Locker)
			{
				// If the key exists
				if (Settings.Values.ContainsKey(key))
				{

					// If the value has changed
					if (Settings.Values[key] != value)
					{
						// Store key new value
						Settings.Values[key] = value;
						valueChanged = true;
					}
				}
				// Otherwise create the key.
				else
				{
					Settings.CreateContainer(key, ApplicationDataCreateDisposition.Always);
					Settings.Values[key] = value;
					valueChanged = true;
				}
			}

			return valueChanged;
		}

		/// <summary>
		/// Saves any changes out.
		/// </summary>
		public void Save()
		{
			//nothing to do it is automatic
		}
	}
}