using System;

namespace Pushover.Services
{

	/// <summary>
	/// Defines a contract all service helpers must implement. Helps with communicating with services.
	/// </summary>
	public interface IServiceHelper
	{

		/// <summary>
		/// Sends the specified message to Pushover
		/// </summary>
		/// <param name="message">The message to send.</param>
		/// <returns>
		/// Returns the server's response in string format.
		/// </returns>
		String SendMessage(String message);
		
	}

}
