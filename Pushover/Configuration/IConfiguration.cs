using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pushover.Configuration
{

	/// <summary>
	/// Defines a contract that all configuration classes must implement. Strongly types configuration values.
	/// </summary>
	public interface IConfiguration
	{

		/// <summary>
		/// Gets the Pushover API URL.
		/// </summary>
		String PushoverApiUrl { get; set; }

		/// <summary>
		/// Gets the Pushover application token.
		/// </summary>
		String AppToken { get; set; }

		/// <summary>
		/// Gets the Pushover user key.
		/// </summary>
		String UserKey { get; set; }

	}

}
