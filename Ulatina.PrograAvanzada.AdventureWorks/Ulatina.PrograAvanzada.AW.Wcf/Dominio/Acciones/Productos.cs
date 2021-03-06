﻿using System;
using System.Collections.Generic;

namespace Ulatina.PrograAvanzada.AW.Wcf.Acciones
{
    public class Productos
    {
        public Productos()
        {
        }
        public IList<Model.Product> ListarTodos() //PENDIENTE
        {
            throw new NotImplementedException();
        }

        public IList<Model.Product> EncontrarProductosPorRangoDeFecha(DateTime? fechaInicial, DateTime? fechaFinal)
        {
            throw new NotImplementedException(); //PENDIENTE
        }
        
        public Model.Product EncontrarProductoPorNumero(string elNumero)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var elProducto = laEspecificacion.EncontrarProductoPorNumero(elNumero);
            return elProducto;
        }

        public IList<Model.Product> EncontrarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var elProducto = laEspecificacion.EncontrarProductoPorRangoDePrecio(elPrecioInferior, elPrecioSuperior);
            return elProducto;
        }

        public IList<Model.Product> EncontrarProductosConReview()
        {
            var laEspecificacion = new Especificaciones.Productos();
            var elProducto = laEspecificacion.EncontrarProductosConReview();
            return elProducto;
        }
        
        public IList<Model.Product> EncontrarProductosPorHileraModelo(string laHilera)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var elProducto = laEspecificacion.EncontrarProductosPorHileraModelo(laHilera);
            return elProducto;
        }

        public IList<Model.Product> EncontrarProductosPorHileraSubcategoria(string laHilera)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var elProducto = laEspecificacion.EncontrarProductosPorHileraSubcategoria(laHilera);
            return elProducto;
        }

        public IList<Model.Product> EncontrarProductosPorColor(string elColor)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var elProducto = laEspecificacion.EncontrarProductosPorColor(elColor);
            return elProducto;
        }

        public IList<Model.Product> EncontrarProductoPorHileraNombre(string laHilera)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var elProducto = laEspecificacion.EncontrarProductoPorHileraNombre(laHilera);
            return elProducto;
        }
    }
}