using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;

namespace WcfRestExample.Services {
	public class MessageHeaderBehaviorExtension : BehaviorExtensionElement {

		public override Type BehaviorType {
			get { return typeof (MessageHeaderBehavior); }
		}

		protected override object CreateBehavior() {
			return new MessageHeaderBehavior();
		}
	}
}
