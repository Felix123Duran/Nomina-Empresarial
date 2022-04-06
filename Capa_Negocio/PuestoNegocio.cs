using System;
using System.Collections.Generic;
using System.Linq;
using Capa_Entidaddes;
using Capa_Datos;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class PuestoNegocio
    {
        DatosPuesto data = new DatosPuesto();
        public void puestoCrear(Puesto puesto)
        {
            data.Crear(puesto);
        }
        public List<Puesto> leer()
        {
            return data.Leer();
        }

        public void Editar(Puesto puesto)
        {
            data.editar(puesto);
        }

        public Puesto Getpuesto(int id)
        {
            return data.Getpuesto(id);
        }
        public void Eliminar(Puesto puesto)
        {
            data.eliminar(puesto);
        }
    }
}
