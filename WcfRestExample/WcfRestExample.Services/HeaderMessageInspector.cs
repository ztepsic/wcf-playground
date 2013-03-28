using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace WcfRestExample.Services {
	public class HeaderMessageInspector : IDispatchMessageInspector {

		#region IDispatchMessageInspector Members

		public object AfterReceiveRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel, System.ServiceModel.InstanceContext instanceContext) {
			if (!request.IsFault) {
				var hashType = WebOperationContext.Current.IncomingRequest.UriTemplateMatch.QueryParameters["hash"];
				if (!(new[] {"MD5", "SHA1"}).Contains(hashType.ToUpper())) {
					throw new WebFaultException<string>("Wrong hash type.", HttpStatusCode.NotFound); 
				}

			}

			return null;
		}

		public void BeforeSendReply(ref System.ServiceModel.Channels.Message reply, object correlationState) {

			if (!reply.IsEmpty && !reply.IsFault) {
				var buffer = reply.CreateBufferedCopy(short.MaxValue);
				var copy = buffer.CreateMessage();
				reply = buffer.CreateMessage();

				string xmlMessage = copy.GetReaderAtBodyContents().ReadOuterXml();
				var hashType = WebOperationContext.Current.IncomingRequest.UriTemplateMatch.QueryParameters["hash"];
				
				if (hashType != null) {
					byte[] hash = null;
					if (hashType.Equals("MD5", StringComparison.OrdinalIgnoreCase)) {
						MD5 md5 = MD5.Create();
						hash = md5.ComputeHash(Encoding.UTF8.GetBytes(xmlMessage));
					} else if (hashType.Equals("SHA1", StringComparison.OrdinalIgnoreCase)) {
						SHA1 sha1 = SHA1.Create();
						hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(xmlMessage));
					} 

					if (hash != null) {
						WebOperationContext.Current.OutgoingResponse.Headers.Add("Hash", Convert.ToBase64String(hash));	
					}
					
				}

			}


		}


		#endregion
	}
}
