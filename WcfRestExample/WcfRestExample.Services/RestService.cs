using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfRestExample.Services {
	public class RestService : IRestService {
		#region IRestService Members

		public string GetCurrentTime() {
			return DateTime.Now.ToString();
		}

		#endregion
	}
}
