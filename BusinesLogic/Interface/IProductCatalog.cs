using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic.Interface
{
    public interface IProductCatalog
    {
        IEnumerable<Product> GetAll();
        void Add(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        Product GetById(int Id);
        void Save();
    }
}
