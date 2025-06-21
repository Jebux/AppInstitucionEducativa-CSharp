using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInstitucionEducativa
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public decimal Documento {  get; set; }

        public Persona(string nombre, decimal documento) 
        { 
            Nombre = nombre;
            Documento = documento;
        }

        public abstract string MostrarInformacion();
        
    }
}
