using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    [Serializable()]
     public class pedido : ISerializable
     {
            public String nombre { get; set; }
            public String entrada { get; set; }
            public String platoFuerte { get; set; }
            public String bebida { get; set; }
            public String postre { get; set; }

            public pedido(String nombre, String entrada, String platoFuerte, String bebida, String postre)
            {
                this.nombre = nombre;
                this.entrada = entrada;
                this.platoFuerte = platoFuerte;
                this.bebida = bebida;
                this.postre = postre;
            }

            public pedido()
            {

            }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

}
