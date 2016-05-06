using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Domain;

namespace ShoppingListWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceProduct" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceProduct.svc or ServiceProduct.svc.cs at the Solution Explorer and start debugging.
    public class ServiceProduct : IServiceProduct
    {
        readonly IRepositoryProduct _repository;

        public ServiceProduct(IRepositoryProduct repository)
        {
            if (null == repository)
            {
                throw new ArgumentNullException("repository product");
            }
            _repository = repository;
        }

        public IEnumerable<Product> GetAll()
        {
            return _repository.Product.ToList();
        }
    }
}
