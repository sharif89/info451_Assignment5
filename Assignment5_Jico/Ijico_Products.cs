using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignment5_Jico
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Ijico_Products" in both code and config file together.
    [ServiceContract]
    public interface Ijico_Products
    {
        [OperationContract]
        List<Products> ReturnProduct();
    }
}
