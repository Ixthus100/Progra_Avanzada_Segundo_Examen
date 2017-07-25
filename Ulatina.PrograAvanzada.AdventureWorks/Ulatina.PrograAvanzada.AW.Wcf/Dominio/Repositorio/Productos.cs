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
            elProducto =_Contexto.Product.Include("ProductSubcategory").Include("ProductModel").Include("ProductReview").Include("ProductSubcategory.ProductCategory").Where(p => p.ProductNumber.Equals(elNumero)).FirstOrDefault();
            return elProducto;
        }

        public IList<Model.Product> EncontrarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
            var losProductos = _Contexto.Product.Where(p => elPrecioInferior <= p.ListPrice && p.ListPrice <= elPrecioSuperior).ToList();
            return losProductos;
        }

        // 1
        public IList<Model.Product> EncontrarProductoPorHileraNombre(string laHilera)
        {
            var losProductos = _Contexto.Product.Where(p => p.Name.Contains(laHilera)).ToList();
            return losProductos;
        }

        // 2

        // 3
        public IList<Model.Product> EncontrarProductosPorColor(string elColor)
        {
            var losProductos = _Contexto.Product.Where(p => p.Color.Equals(elColor)).ToList();
            return losProductos;
        }

        // 4
        public IList<Model.Product> EncontrarProductosPorHileraSubcategoria(string laHilera)
        {
            /*var losProductos = _Contexto.Product.Join(_Contexto.ProductSubcategory, product => product.ProductSubcategoryID, subcategory => subcategory.ProductSubcategoryID, (product, subcategory) => product).Where(products => products.ProductSubcategory.Name.Contains(laHilera)).ToList(); */
            var losProductos = _Contexto.Product.Include("ProductSubcategory").Include("ProductModel").Include("ProductReview").Include("ProductSubcategory.ProductCategory").Where(p => p.ProductSubcategory.Name.Contains(laHilera)).ToList();
            return losProductos;
        }

        // 5

        // 6
        public IList<Model.Product> EncontrarProductosPorHileraModelo(string laHilera)
        {
            /*var losProductos = _Contexto.Product.Join(_Contexto.ProductModel, product => product.ProductModelID, model => model.ProductModelID, (product, model) => product).Where(products => products.ProductModel.Name.Contains(laHilera)).ToList();
            return losProductos;*/
            var losProductos = _Contexto.Product.Include("ProductSubcategory").Include("ProductModel").Include("ProductReview").Include("ProductSubcategory.ProductCategory").Where(p => p.ProductModel.Name.Contains(laHilera)).ToList();
            return losProductos;
        }

        // 7
        public IList<Model.Product> EncontrarProductosConReview()
        {
            var losProductos = _Contexto.Product.Include("ProductSubcategory").Include("ProductModel").Include("ProductReview").Include("ProductSubcategory.ProductCategory").Where(p => p.ProductReview != null).ToList();
            return losProductos;
        }
    }
}