using BusinesLogic;
using BusinesLogic.Interface;
using DomainLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepositoryLayer;
using System;
using System.Collections;
using System.Net.Http;

namespace APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCatalogController : ControllerBase
    {
        private readonly ILogger<ProductCatalogController> _logger;
        ProductDbContext _Context;
        IProductCatalog _Catalog;


        public ProductCatalogController(ProductDbContext Context, ILogger<ProductCatalogController> logger)
        {
            _logger = logger;
            _Context = Context;
            _Catalog = new ProductCatalog(_Context);
        }
        [HttpGet]
        public IEnumerable GetAll()
        {

            try
            {
                var products = _Catalog.GetAll();

                return products;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error message");
                return ex.ToString();


            }
        }

        [HttpGet("{id}")]
        public Product GetById(int id)
        {

            try
            {
                Product product = new Product();
                product = _Catalog.GetById(id);

                return product;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error In Get By Id method", ex);
            }

            return null;
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] Product product)
        {
            try
            {
                _Catalog.Add(product);
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK);

            }
            catch (Exception ex)
            {
                _logger.LogError("Error In Post", ex);
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
            }

        }
        [HttpPut]
        public HttpResponseMessage Put([FromBody] Product product)
        {
            try
            {
                _Catalog.Update(product);
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK);

            }
            catch (Exception ex)
            {
                _logger.LogError("Error In Put", ex);
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
            }

        }
        [HttpDelete]
        public HttpResponseMessage Delete(int Id)
        {
            try
            {
                Product product = new Product();
                product = _Catalog.GetById(Id);

                _Catalog.Delete(product);
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                _logger.LogError("Error In Put", ex);
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
            }

        }
    }
}
