using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ShoppingListWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceProduct" in both code and config file together.
    [ServiceContract]
    public interface IServiceProduct
    {
        [OperationContract]
        //URL navegador: http://localhost:1966/ServiceProduct.svc/api/GetAll
        // "/api/" --> nombre del webconfig dado al EnableCors
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetAll")]
        IEnumerable<Product> GetAll();
    }
}
