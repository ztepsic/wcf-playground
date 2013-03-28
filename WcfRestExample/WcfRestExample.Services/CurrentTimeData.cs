using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfRestExample.Services {
	[DataContract(Name = "current-time")]
	public class CurrentTimeData {
		[DataMember(Name = "now-date-time")]
		public string NowDateTime { get; set; }

		[DataMember(Name = "womorrow-date-time")]
		public string TomorrowDateTime { get; set; }
	}
}
