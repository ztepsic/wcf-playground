using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace HelloIndigo {
	public class HelloIndigoService : IHelloIndigoService {
		#region IHelloIndigoService Members

		public string HelloIndigo() {
			return "Hello Indigo";
		}

		#endregion
	}


}
