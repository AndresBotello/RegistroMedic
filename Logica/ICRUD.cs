using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public interface ICRUD<T>
    {
        string AgregarRegistro(T paciente);
        string ActualizarRegistro(T paciente);
        string EliminarRegistro(T paciente);
      
    }
}
