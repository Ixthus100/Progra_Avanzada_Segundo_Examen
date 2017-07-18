using System;
using System.Collections.Generic;
using System.Linq;

namespace Ulatina.PrograAvanzada.AW.Wcf.Repositorio
{
    internal class Productos
    {
        //Referencia del contexto - solo los repositorios deben de tener acceso a los contextos
        static Model.AdventureWorks2014Entities _Contexto = new Model.AdventureWorks2014Entities();

        public Productos()
        {
        }

        public Model.Product EncontrarProductoPorNumero(string elNumero)
        {
            Model.Product elProducto = new Model.Product();
            elProducto =_Contexto.Product.Include("ProductSubcategory, ProductModel, ProductReview, ProductSubcategory.ProductCategory").Where(p => p.ProductNumber.Equals(elNumero)).FirstOrDefault();
            return elProducto;
        }

        public IList<Model.Product> EncontrarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
            var losProductos = _Contexto.Product.Where(p => elPrecioInferior <= p.ListPrice && p.ListPrice <= elPrecioSuperior).ToList();
            return losProductos;
        }
    }
}