using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using HelloIndigo;

namespace Host {
	class Program {

		static void Main(string[] args) {
			using (ServiceHost host = new ServiceHost(typeof(HelloIndigoService))) {

				host.Open();

				Console.WriteLine("Press <ENTER> to terminate the service host");
				Console.ReadLine();

			}
		} 
	}
}
