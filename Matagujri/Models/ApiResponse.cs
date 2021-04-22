using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Web;

namespace Matagujri.Models
{
    [Serializable()]
    [DataContract]
    public class ApiResponse
    {
        public ApiResponse(HttpStatusCode responseCode,string responseMessage,object response)
        {
            ResponseCode = responseCode;
            Response = response;
            ResponseMessage = responseMessage;
        }
        [DataMember]
        public HttpStatusCode ResponseCode { get; set; }

        [DataMember]
        public string ResponseMessage { get; set; }

        [DataMember]
        public object Response { get; set; }
    }
}