using Computadora.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Negocio
{
    class NClsComputadora
    {
 
        public String apagar(ClsComputadora pc)
        {
            return "Se está apagando la computadora con " + pc.MemoriaRam;
        }

        public String actualizar(ClsComputadora pc)
        {
            return "Su comptadora tiene una actualización basada en en el sistema " + pc.Sistemaoperativo;
        }

        public String jugar(ClsComputadora pc)
        {
            return "Usted está jugando a una resolución de " + pc.Resolucion;
        }

        public String EncenderComputadora(ClsComputadora pc)
        {
            return "La computadora con memoria ram de " + pc.MemoriaRam + " micro procesadora de " + pc.Procesador; 
        }
    }
}
