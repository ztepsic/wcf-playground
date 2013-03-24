using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Host {

	public class HelloIndigoService : IHelloIndigoService {
		#region IHelloIndigoService Members

		public string HelloIndigo() {
			return "Hello Indigo";
		}

		#endregion
	}
}
