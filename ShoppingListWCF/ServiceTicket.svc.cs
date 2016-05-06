using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Domain;

namespace ShoppingListWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceTicket" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceTicket.svc or ServiceTicket.svc.cs at the Solution Explorer and start debugging.
    public class ServiceTicket : ServiceBase, IServiceTicket
    {
        readonly IRepositoryTickets _repository;

        public ServiceTicket(IRepositoryTickets repository) 
            : base(repository)
        {
            if (null == repository)
            {
                throw new ArgumentNullException("repository Tickets");
            }
            _repository = repository;
        }

        public Ticket Add(Ticket ticket)
        {
            if (null == ticket)
            {
                throw new ArgumentNullException("ticket is null");
            }
            var ticketNew = _repository.Ticket.Add(ticket);
            SaveChanges();
            return ticketNew;
        }


        //public Ticket Delete(int id)
        //{
        //    if (null == id)
        //    {
        //        throw new ArgumentNullException("ticket is null");
        //    }
        //    var ticketOld = Get(id);
        //    _repository.Ticket.Remove(ticketOld);
        //    SaveChanges();
        //    return ticketOld;
        //}

        public Ticket Get(int id)
        {
            var ticketId = _repository.Ticket.Where(c => c.Id == id).FirstOrDefault();
            return ticketId;
        }

        //public IEnumerable<Ticket> GetAll()
        //{
        //    return _repository.Ticket.ToList();
        //}


        public Ticket AddDetail(int idTicket, Details detail)
        {
            //1 - Obtentener el ticket
            var ticketDetail = Get(idTicket);
            //2- Obtener producto
            ticketDetail.Detail.Add(detail);
            //3 - Hacer calcula para TotalPrice
            //detail.TotalPrice = CalculateTotalPrice(detail);
            //4 - Añadir detalle a ticker, y SaveCHanges
            ticketDetail.Detail.Add(detail);
            _repository.SaveChanges();
            //5- Devolver ticket
            return ticketDetail;
        }

        public Ticket Delete(int idTicket, int idDetail)
        {
            throw new NotImplementedException();
        }
    }
}
