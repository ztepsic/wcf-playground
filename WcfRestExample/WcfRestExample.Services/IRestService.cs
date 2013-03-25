using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.ServiceModel;

namespace WcfRestExample.Services {
	/// <summary>
	/// Rest WCF
	/// http://msdn.microsoft.com/en-us/magazine/dd315413.aspx
	/// </summary>
	[ServiceContract(Namespace = "http://www.ztepsic.com/wcf/2013/03")]
	public interface IRestService {

		/*
		 * To use WebInvoke you must add System.ServiceModel.Web reference (You must set Target Framework to .net 4 (not client profile))
		 */

		[OperationContract]
		//[WebGet(UriTemplate = "get-current-time")] // HTTP-GET
		[WebInvoke(Method = "GET", UriTemplate = "get-current-time", ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Bare)] // Any HTTP method, default POST
		[Description("Returns merchant info data")]
		string GetCurrentTime();

	}
}
