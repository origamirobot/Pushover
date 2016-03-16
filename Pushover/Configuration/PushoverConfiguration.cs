using System;

namespace Pushover.Configuration
{

	/// <summary>
	/// Strongly types configuration values.
	/// </summary>
	public class PushoverConfiguration : IConfiguration
	{

		#region PRIVATE PROPERTIES


		private String _appToken = ""; //TODO: Enter Pushover AppToken here.
		private String _userKey = ""; //TODO: Enter Pushover UserKey here.
		private String _pushoverApiUrl = "https://api.pushover.net/1/messages.json";

		#endregion PRIVATE PROPERTIES


		/// <summary>
		/// Gets the Pushover API URL.
		/// </summary>
		public String PushoverApiUrl
		{
			get { return _pushoverApiUrl; }
			set { _pushoverApiUrl = value; }
		}

		/// <summary>
		/// Gets the Pushover application token.
		/// </summary>
		public String AppToken
		{
			get { return _appToken; }
			set { _appToken = value; }
		}

		/// <summary>
		/// Gets the Pushover user key.
		/// </summary>
		public String UserKey
		{
			get { return _userKey; }
			set { _userKey = value; }
		}

	}

}
