using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Assignment5_Jico
{

    [DataContract]
    public class Products
    {
        [DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}