﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Ulatina.PrograAvanzada.AW.Wcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        Model.Product EncontrarProductoPorNumero(string elNumero);

        [OperationContract]
        IList <Model.Product> EncontrarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior);

        [OperationContract]
        IList<Model.Product> EncontrarProductosPorHileraNombre(string laHilera);

        [OperationContract]
        IList<Model.Product> EncontrarProductosPorColor(string elColor);

        [OperationContract]
        IList<Model.Product> EncontrarProductosPorHileraSubcategoria(string laHilera);

        [OperationContract]
        IList<Model.Product> EncontrarProductosPorHileraModelo(string laHilera);

        [OperationContract]
        IList<Model.Product> EncontrarProductosConReview();

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
