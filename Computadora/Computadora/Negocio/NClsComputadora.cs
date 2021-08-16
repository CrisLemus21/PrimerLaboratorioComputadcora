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
        ClsComputadora pc = new ClsComputadora();

        public string apagar()
        {
            return "Se está apagando la computadora con " + pc.MemoriaRam;
        }

        public string actualizar()
        {
            return "Su comptadora tiene una actualización basada en en el sistema " + pc.Sistemaoperativo;
        }

        public string jugar()
        {
            return "Usted está jugando a una resolución de " + pc.Resolucion;
        }

        public string EncenderComputadora()
        {
            return "La computadora con memoria ram de " + pc.MemoriaRam + "micro procesadora de " + pc.Procesador; 
        }
    }
}
