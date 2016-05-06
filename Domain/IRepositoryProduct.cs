using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
    public interface IRepositoryProduct : IUnitOfWork
    {
        IDbSet<Product> Product { get; set; }
    }
}
