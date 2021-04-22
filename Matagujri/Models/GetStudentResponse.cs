using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Matagujri.Models
{
    [Serializable()]
    [DataContract]
    public class GetStudentResponse
    {
        [DataMember]
        public object draw { get; set; }
        [DataMember]
        public object start { get; set; }
        [DataMember]
        public int recordsFiltered { get; set; }
        [DataMember]
        public int recordsTotal { get; set; }
        [DataMember]
        public List<Student> data { get; set; }
    }
}