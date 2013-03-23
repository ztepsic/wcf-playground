using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloIndigo {
	
	[ServiceContract(Namespace = "http://www.thatindigogirl.com/samples/2006/06")]
	public interface IHelloIndigoService {
		[OperationContract]
		string HelloIndigo();
	}

}
