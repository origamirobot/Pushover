using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using Pushover.Configuration;

namespace Pushover.Services
{

	/// <summary>
	/// Helps with making service related calls.
	/// </summary>
	public class ServiceHelper : IServiceHelper
	{

		#region PROTECTED PROPERTIES


		/// <summary>
		/// Gets the configuration.
		/// </summary>
		protected IConfiguration Configuration { get; private set; }


		#endregion PROTECTED PROPERTIES

		#region CONSTRUCTORS


		/// <summary>
		/// Initializes a new instance of the <see cref="ServiceHelper"/> class.
		/// </summary>
		/// <param name="configuration">The configuration.</param>
		public ServiceHelper(IConfiguration configuration)
		{
			Configuration = configuration;
		}


		#endregion CONSTRUCTORS

		#region PUBLIC METHODS


		/// <summary>
		/// Sends the specified message to Pushover
		/// </summary>
		/// <param name="message">The message to send.</param>
		/// <returns>
		/// Returns the server's response in string format.
		/// </returns>
		public String SendMessage(String message)
		{
			Console.WriteLine("Sending message: {0}", message);
			var payload = new NameValueCollection() { { "token", Configuration.AppToken }, { "user", Configuration.UserKey }, { "message", message } };
			using (var client = new WebClient())
			{
				var raw = client.UploadValues(Configuration.PushoverApiUrl, payload);
				var response = Encoding.ASCII.GetString(raw);
				return response;
			}
		}


		#endregion PUBLIC METHODS

	}

}
