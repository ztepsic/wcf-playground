using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Text;

namespace WcfRestExample.Services {
	public class MessageHeaderBehavior : IEndpointBehavior {
		#region IEndpointBehavior Members

		public void AddBindingParameters(ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) {
			
		}

		public void ApplyClientBehavior(ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime) {
			
		}

		public void ApplyDispatchBehavior(ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher) {
			endpointDispatcher.DispatchRuntime.MessageInspectors.Add(new HeaderMessageInspector());
		}

		public void Validate(ServiceEndpoint endpoint) {
			
		}

		#endregion
	}
}