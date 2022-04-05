using System;
using Capa_Entidaddes;
using Capa_Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class EmpleadosNegocio
    {

        DatosEmpleados data = new DatosEmpleados();
        public void EmpleadosCrear(Empleado empleado)
        {
            data.Crear(empleado);
        }
        public List<Empleado> leer()
        {
            return data.Leer();
        }

        public void Editar(Empleado empleado)
        {
            data.editar(empleado);
        }

        public Empleado GetEmpleado(int id)
        {
            return data.GetEmpleado(id);
        }
        public void Eliminar(Empleado empleado)
        {
            data.eliminar(empleado);
        }
    }
}
