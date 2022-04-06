using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capa_Entidaddes;
using Capa_Datos;
using System.Threading.Tasks;

namespace Capa_Negocio
{
   public class NominaNegocio
    {
        DatosNomina data = new DatosNomina();
        public void NominasCrear(Nomina nomina)
        {
            data.Crear(nomina);
        }
        public List<Nomina> leer()
        {
            return data.Leer();
        }

        public void Editar(Nomina nomina)
        {
            data.editar(nomina);
        }

        public Nomina GetNomina(int id)
        {
            return data.GetNomina(id);
        }
        public void Eliminar(Nomina nomina)
        {
            data.eliminar(nomina);
        }
    }
}
