using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Client {
	class Program {
		static void Main(string[] args) {
			EndpointAddress ep = new EndpointAddress("http://localhost:8000/HelloIndigo/HelloIndigoService");

			IHelloIndigoService proxy = ChannelFactory<IHelloIndigoService>.CreateChannel(new BasicHttpBinding(), ep);
			string s = proxy.HelloIndigo();
			Console.WriteLine(s);
			Console.WriteLine("Press <ENTER> to terminate Client.");
			Console.ReadLine();
		}
	}
}
