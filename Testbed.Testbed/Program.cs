namespace Testbed.Testbed
{
	using System;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.Linq;
	using System.Net;
	using System.Net.Sockets;
	using System.Runtime.Caching;
	using System.Security.Cryptography;
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Threading;
	using System.Threading.Tasks;
	using System.Web;
	using System.Xml;
	using System.Xml.Linq;

	using LinqToTree;

	class Program
	{
		#region Main Program Loop

		private static ManualResetEvent _quitEvent = new ManualResetEvent(false);

		[STAThread]
		private static void Main(string[] args)
		{
			Console.CancelKeyPress += (sender, e) =>
			{
				_quitEvent.Set();
				e.Cancel = true;
			};

			try
			{
				#region Setup
				#endregion


				ProgramBody();

				//  One of the following should be commented out. The other should be uncommented.

				//_quitEvent.WaitOne();  //  Wait on UI thread for Ctrl + C

				Console.ReadKey(true);  //  Wait for any character input
			}
			finally
			{
				#region Tear down
				#endregion
			}
		}

		#endregion





		private static void ProgramBody()
		{

		}




	}
}
