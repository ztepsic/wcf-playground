using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Client.localhost;

namespace Client {
	class Program {

		static void Main(string[] args) {
			
			// with Servjce References
			//localhost.HelloIndigoServiceClient proxy = new Client.localhost.HelloIndigoServiceClient();
			using (HelloIndigoServiceClient proxy = new HelloIndigoServiceClient()) {
				string s = proxy.HelloIndigo();
				Console.WriteLine(s);
			}

			Console.WriteLine("Press <ENTER> to terminate Client.");
			Console.ReadLine();
		}
	}
}
