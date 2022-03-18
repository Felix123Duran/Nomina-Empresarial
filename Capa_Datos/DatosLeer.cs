using System;
using Capa_Entidaddes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DatosLeer
    {
        //clase parea leer los datos 
        NominaEntities db = new NominaEntities();

        public List<Empleado> LeerEmpleados()
        {
            return db.Empleado.ToList();
        }

        public List<Departamento> LeerDepartamentos()
        {
            return db.Departamento.ToList();
        }

        public List<Puesto> LeerPuesto()
        {
            return db.Puesto.ToList();
        }

        public List<Tipos_Ingresos> LeerTipos_Ingresos()
        {
            return db.Tipos_Ingresos.ToList();
        }

        public List<Detalles_nomina> LeerDetalles_nomina()
        {
            return db.Detalles_nomina.ToList();
        }

        public List<Nomina> LeerNomina()
        {
            return db.Nomina.ToList();
        }

        public List<Transaccion> LeerTransaccion
            ()
        {
            return db.Transaccion.ToList();
        }
    }
}
