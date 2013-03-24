using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloIndigo {
	public class HelloIndigoService : IHelloIndigoService {
		#region IHelloIndigoService Members

		public string HelloIndigo() {
			return "Hello Indigo";
		}

		#endregion
	}
}
