using System;
using Capa_Datos;
using Capa_Entidaddes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public  class NegocioLeer
    {
        DatosLeer datos = new DatosLeer();
        public List<Empleado> LeerEmpleados()
        {
           return datos.LeerEmpleados();
        }

        public List<Departamento> LeerDepartamento()
        {
            return datos.LeerDepartamentos();
        }

        public List<Puesto> LeerPuesto()
        {
            return datos.LeerPuesto();
        }

        public List<Tipos_Ingresos> LeerTipos_Ingresos()
        {
            return datos.LeerTipos_Ingresos();
        }

        public List<Detalles_nomina> LeerDetalles_nominia()
        {
            return datos.LeerDetalles_nomina();
        }

        public List<Nomina> LeerNomina()
        {
            return datos.LeerNomina();
        }

        public List<Transaccion> LeerTransaccion()
        {
            return datos.LeerTransaccion();
        }

    }
}
