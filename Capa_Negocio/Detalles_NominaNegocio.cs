using System;
using System.Collections.Generic;
using System.Linq;
using Capa_Entidaddes;
using System.Text;
using Capa_Datos;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class Detalles_NominaNegocio
    {   
        DatosDetallesNomina data = new DatosDetallesNomina();
        public void Detalles_NominasCrear(Detalles_nomina detalles_Nomina)
        {
            data.Crear(detalles_Nomina);              
        }
        public List<Detalles_nomina> leer()
        {
            return data.Leer();
        }

        public void Editar(Detalles_nomina detalles_Nomina)
        {
            data.editar(detalles_Nomina);
        }

        public Detalles_nomina GetDetalles_Nomina(int id)
        {
            return data.GetDetalles_nomina(id);
        }
        public void Eliminar(Detalles_nomina detalles_Nomina)
        {
            data.eliminar(detalles_Nomina);
        }

    }
}
