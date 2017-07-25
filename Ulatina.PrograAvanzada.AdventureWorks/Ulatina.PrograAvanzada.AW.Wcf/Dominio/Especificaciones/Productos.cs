using System;
using System.Collections.Generic;

namespace Ulatina.PrograAvanzada.AW.Wcf.Especificaciones
{
    internal class Productos
    {
        public Productos()
        {
        }

        public Model.Product EncontrarProductoPorNumero(string elNumero)
        {
            var elRepositorio = new Repositorio.Productos();
            var elProducto = elRepositorio.EncontrarProductoPorNumero(elNumero);
            return elProducto;
        }

        public IList<Model.Product> EncontrarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
            var elRepositorio = new Repositorio.Productos();
            var elProducto = elRepositorio.EncontrarProductoPorRangoDePrecio(elPrecioInferior, elPrecioSuperior);
            return elProducto;
        }

        public IList<Model.Product> EncontrarProductoPorHileraNombre(string laHilera)
        {
            var elRepositorio = new Repositorio.Productos();
            var elProducto = elRepositorio.EncontrarProductoPorHileraNombre(laHilera);
            return elProducto;
        }

        public IList<Model.Product> EncontrarProductosConReview()
        {
            var elRepositorio = new Repositorio.Productos();
            var elProducto = elRepositorio.EncontrarProductosConReview();
            return elProducto;
        }

        public IList<Model.Product> EncontrarProductosPorHileraModelo(string laHilera)
        {
            var elRepositorio = new Repositorio.Productos();
            var elProducto = elRepositorio.EncontrarProductosPorHileraModelo(laHilera);
            return elProducto;
        }

        public IList<Model.Product> EncontrarProductosPorHileraSubcategoria(string laHilera)
        {
            var elRepositorio = new Repositorio.Productos();
            var elProducto = elRepositorio.EncontrarProductosPorHileraSubcategoria(laHilera);
            return elProducto;
        }

        public IList<Model.Product> EncontrarProductosPorColor(string elColor)
        {
            var elRepositorio = new Repositorio.Productos();
            var elProducto = elRepositorio.EncontrarProductosPorColor(elColor);
            return elProducto;
        }
    }
}