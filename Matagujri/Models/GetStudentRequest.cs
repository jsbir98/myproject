using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Matagujri.Models
{
    [Serializable()]
    [DataContract]
    public class GetStudentRequest
    {
        [DataMember]
        public object draw { get; set; }
        [DataMember]
        public int start { get; set; }
        [DataMember]
        public int length { get; set; }
        [DataMember]
        public string sortColumn { get; set; }
        [DataMember]
        public string sortColumnDir { get; set; }
        [DataMember]
        public string searchValue { get; set; }
    }
}