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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceTicket" in both code and config file together.
    [ServiceContract]
    public interface IServiceTicket
    {         
        //No es necesario heredar de IUnitOfWork porque la clase que lo implemente heredará de ServiceBase.
        //Y ServiceBase implement IDisposible
        [OperationContract]
        [WebInvoke(UriTemplate = "Ticket/",
                    Method = "POST")]
        Ticket Add(Ticket ticket);


        [WebInvoke(UriTemplate = "Ticket/{idTicket}/Detail/",
                    Method = "POST")]
        Ticket AddDetail(int idTicket, Details detail );


        [OperationContract]
        Ticket Get(int id);

        [OperationContract]
        [WebInvoke(UriTemplate = "Ticket/{idTicket}/DeleteDetal/{idDetail}",
                    Method = "DELETE")]
        Ticket Delete(int idTicket, int idDetail);

        //[OperationContract]
        //IEnumerable<Ticket> GetAll();
    }
}
