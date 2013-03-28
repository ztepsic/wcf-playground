using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfRestExample.Services {
	public class RestService : IRestService {
		#region IRestService Members

		public CurrentTimeData GetCurrentTime() {
			CurrentTimeData currentTimeData = new CurrentTimeData {
				NowDateTime = DateTime.Now.ToString(),
				TomorrowDateTime = DateTime.Now.AddDays(1).ToString()
			};
			return currentTimeData;
		}

		#endregion
	}
}
