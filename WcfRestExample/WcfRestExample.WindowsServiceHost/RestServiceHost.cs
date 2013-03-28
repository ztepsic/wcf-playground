using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel.Web;
using System.ServiceProcess;
using System.Text;
using System.ServiceModel;
using WcfRestExample.Services;

namespace WcfRestExample.WindowsServiceHost {
	public partial class RestServiceHost : ServiceBase {

		// Add reference for System.ServiceModel.Web for WebServiceHost
		private ServiceHost serviceHost;

		public RestServiceHost() {
			InitializeComponent();
		}

		
		protected override void OnStart(string[] args) {
			try {
				serviceHost = new WebServiceHost(typeof (RestService));
				serviceHost.Open();
			} catch (Exception ex) {
				EventLog.WriteEntry(ex.Message, EventLogEntryType.Error);
			}

			
			serviceHost.Faulted += new EventHandler(serviceHost_Faulted);

			// the base addresses and ports that the ServiceHost i s listening on onece opened
			string baseAddresses = "";
			foreach (Uri baseAddress in serviceHost.BaseAddresses) {
				baseAddresses += " " + baseAddress;
			}

			string s = String.Format("{0} listening at {1}", ServiceName, baseAddresses);
			EventLog.WriteEntry(s, EventLogEntryType.Information);
		}

		void serviceHost_Faulted(object sender, EventArgs e) {
			string s = String.Format("{0} has faulted, notify administrators of this problem", ServiceName);
			EventLog.WriteEntry(s, EventLogEntryType.Error);
		}

		protected override void OnStop() {
			// clean ServiceHost instance and free TCP port
			if (serviceHost != null) {
				serviceHost.Close();
				string s = String.Format("{0} stopped", this.ServiceName);
				EventLog.WriteEntry(s, EventLogEntryType.Information);
				serviceHost = null;
			}
		}
	}
}
