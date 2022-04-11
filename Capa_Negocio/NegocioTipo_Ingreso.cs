using System;
using System.Collections.Generic;
using System.Linq;
using Capa_Entidaddes;
using Capa_Datos; 
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class NegocioTipo_Ingreso
    {

        DatosTipos_ingreso data = new DatosTipos_ingreso();
        public void EmpleadosCrear(Tipos_Ingresos Tipos_Ingresos)
        {
            data.Crear(Tipos_Ingresos);
        }
        public List<Tipos_Ingresos> leer()
        {
            return data.Leer();
        }

        public void Editar(Tipos_Ingresos Tipos_Ingresos)
        {
            data.editar(Tipos_Ingresos);
        }

        public Tipos_Ingresos GetTipos_Ingresos(int id)
        {
            return data.GetTipo_Ingreso(id);
        }
        public void Eliminar(Tipos_Ingresos Tipos_Ingresos)
        {
            data.eliminar(Tipos_Ingresos);
        }
    }
}
