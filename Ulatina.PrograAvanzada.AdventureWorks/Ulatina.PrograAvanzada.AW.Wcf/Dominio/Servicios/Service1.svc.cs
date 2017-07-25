﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Ulatina.PrograAvanzada.AW.Model;

namespace Ulatina.PrograAvanzada.AW.Wcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public IList<Product> EncontrarProductosConReview()
        {
            var laAccion = new Acciones.Productos();
            var elProducto = laAccion.EncontrarProductosConReview();
            return elProducto;
        }

        public IList<Product> EncontrarProductosPorHileraModelo(string laHilera)
        {
            var laAccion = new Acciones.Productos();
            var elProducto = laAccion.EncontrarProductosPorHileraModelo(laHilera);
            return elProducto;
        }

        public IList<Product> EncontrarProductosPorHileraSubcategoria(string laHilera)
        {
            var laAccion = new Acciones.Productos();
            var elProducto = laAccion.EncontrarProductosPorHileraSubcategoria(laHilera);
            return elProducto;
        }

        public IList<Product> EncontrarProductosPorColor(string elColor) //TAREA
        {
            var laAccion = new Acciones.Productos();
            var elProducto = laAccion.EncontrarProductosPorColor(elColor);
            return elProducto;
        }

        public IList<Product> EncontrarProductosPorHileraNombre(string laHilera) //TAREA
        {
            var laAccion = new Acciones.Productos();
            var elProducto = laAccion.EncontrarProductoPorHileraNombre(laHilera);
            return elProducto;
        }

        public Model.Product EncontrarProductoPorNumero(string elNumero)
        {
            var laAccion = new Acciones.Productos();
            var elProducto = laAccion.EncontrarProductoPorNumero(elNumero);
            return elProducto;
        }

        public IList<Model.Product> EncontrarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
            var laAccion = new Acciones.Productos();
            var elProducto = laAccion.EncontrarProductoPorRangoDePrecio(elPrecioInferior, elPrecioSuperior);
            return elProducto;
        }


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
