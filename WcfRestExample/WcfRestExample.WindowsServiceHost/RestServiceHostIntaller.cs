using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace WcfRestExample.WindowsServiceHost {
	[RunInstaller(true)]
	public class RestServiceHostIntaller : Installer {

		public RestServiceHostIntaller() {
			ServiceProcessInstaller processInstaller = new ServiceProcessInstaller();
			ServiceInstaller serviceInstaller = new ServiceInstaller();

			processInstaller.Account = ServiceAccount.NetworkService;
			serviceInstaller.DisplayName = "RestService Host";
			serviceInstaller.Description = "WCF REST service host for RestServiceExample.Services";
			serviceInstaller.ServiceName = "RestServiceHost";
			serviceInstaller.StartType = ServiceStartMode.Automatic;

			Installers.Add(processInstaller);
			Installers.Add(serviceInstaller);

		}

	}
}
