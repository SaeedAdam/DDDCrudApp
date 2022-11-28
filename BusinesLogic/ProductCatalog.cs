using BusinesLogic.Interface;
using DomainLayer;
using RepositoryLayer;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic
{
    public class ProductCatalog :IProductCatalog
    {
        ProductDbContext _Context;
        IGenericRepositoryOperation<Product> _Repo;
        public ProductCatalog(ProductDbContext Context )
        {

            _Context=Context;
            _Repo=new GenericRepositoryOperation<Product>(_Context);
        }

        public void Add(Product entity)
        {
            _Repo.Add(entity);
            _Repo.Save();
            
        }

        public void Delete(Product entity)
        {
            _Repo.Delete(entity);
            _Repo.Save();
        }

        public IEnumerable<Product> GetAll()
        {
            return _Repo.GetAll();
        }
        public Product GetById(int Id)
        {
           return  _Repo.GetById(Id);
        }

        public void Save()
        {
            _Repo.Save();
        }

        public void Update(Product entity)
        {
           _Repo.Update(entity);
            _Repo.Save();
        }
    }
}
