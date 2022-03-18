using System;
using Capa_Entidaddes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DatosCrear
    {
        NominaEntities db = new NominaEntities();
        public void Empleados (Empleado empleados)
        {
            db.Empleado.Add(empleados);
            db.SaveChanges();
        }
        public void Departamentos(Departamento departamento)
        {
            db.Departamento.Add(departamento);
            db.SaveChanges();
        }
        public void Puesto(Puesto puesto)
        {
            db.Puesto.Add(puesto);
            db.SaveChanges();
        }
        public void TipoIngreso(Tipos_Ingresos TipoIngreso)
        {
            db.Tipos_Ingresos.Add(TipoIngreso);
            db.SaveChanges();
        }
        public void Transacciones(Transaccion transacciones)
        {
            db.Transaccion.Add(transacciones);
            db.SaveChanges();
        }
        public void Nomina(Nomina nomina)
        {
            db.Nomina.Add(nomina);
            db.SaveChanges();
        }
        public void Detalles_Nomina(Detalles_nomina detalles_Nomina)
        {
            db.Detalles_nomina.Add(detalles_Nomina);
            db.SaveChanges();
        }

    }
}
