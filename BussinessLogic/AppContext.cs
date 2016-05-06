using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public partial class AppContext : DbContext, IUnitOfWork, IRepositoryTickets, IRepositoryProduct
    {
        public AppContext() : base("DefaultConnection")
        {
            var cn = this.Database.Connection.ConnectionString;
        }

        public IDbSet<Product> Product { get; set; }
        public IDbSet<Ticket> Ticket { get; set; }

        /* Sobra? */
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}

    }
}
