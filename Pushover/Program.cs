using System;
using NDesk.Options;
using Pushover.Configuration;
using Pushover.Services;

namespace Pushover
{

	/// <summary>
	/// 
	/// </summary>
	class Program
	{

		#region PRIVATE PROPERTIES


		/// <summary>
		/// Gets or sets the configuration.
		/// </summary>
		protected static IConfiguration Configuration { get; set; }

		/// <summary>
		/// Gets or sets the service helper.
		/// </summary>
		protected static IServiceHelper ServiceHelper { get; set; }

		/// <summary>
		/// Gets or sets the options.
		/// </summary>
		protected static OptionSet Options { get; set; }

		/// <summary>
		/// Gets or sets the message to send to Pushover.
		/// </summary>
		protected static String Message { get; set; }


		#endregion PRIVATE PROPERTIES

		#region STATIC METHODS


		/// <summary>
		/// Main entry point into the application.
		/// </summary>
		/// <param name="args">The arguments.</param>
		static void Main(string[] args)
		{
			RegisterDependencies();
			Options.Parse(args);

			if (String.IsNullOrEmpty(Configuration.AppToken))
			{
				Console.WriteLine("AppToken not defined. You must provide the AppToken as the -a parameter.");
				return;
			}
			if (String.IsNullOrEmpty(Configuration.UserKey))
			{
				Console.WriteLine("UserKey not defined. You must provide the UserKey as the -u parameter.");
				return;
			}
			if(String.IsNullOrEmpty(Message))
			{
				Console.Write("Message not defined. You must provide the Message as the -m parameter");
				return;
			}
			Console.WriteLine("Sending message");
			var result = ServiceHelper.SendMessage(Message);

			Console.ReadLine();

		}

		/// <summary>
		/// Registers the dependencies.
		/// </summary>
		static void RegisterDependencies()
		{
			// IF I WEREN'T TRYING TO KEEP THIS APPLICATION SMALL, THIS IS WHERE I'D ADD THE IoC CONTAINER.
			Configuration = new PushoverConfiguration();
			ServiceHelper = new ServiceHelper(Configuration);
			Options = new OptionSet()
				.Add("m|message=", delegate (String m) { Message = m; })
				.Add("a|apptoken=", delegate (String a) { Configuration.AppToken = a; })
				.Add("u|userkey=", delegate (String u) { Configuration.UserKey = u; });
		}


		#endregion STATIC METHODS

	}

}
