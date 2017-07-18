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
    }
}