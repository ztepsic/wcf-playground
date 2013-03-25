using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Text;
using System.ServiceModel;
using WcfRestExample.Services;
using System.ServiceModel.Web;

namespace WcfRestExample.ConsoleAppHost {
	class Program {
		static void Main(string[] args) {
			// Add reference for System.ServiceModel.Web for WebServiceHost

			// Longer version
			/* using (ServiceHost serviceHost = new ServiceHost(typeof (RestService))) {
				serviceHost.AddServiceEndpoint(typeof(IRestService),
										   new WebHttpBinding(),
				"http://localhost:8000/RestService");

				serviceHost.Open();
			 
				Console.WriteLine("Press <ENTER> to terminate the service host");
				Console.ReadLine();
			}*/



			using (WebServiceHost webServiceHost = new WebServiceHost(typeof (RestService))) {
				webServiceHost.Open();

				Console.WriteLine("Press <ENTER> to terminate the service host");
				Console.ReadLine();
			}
			


		}
	}
}
