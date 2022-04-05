using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidaddes;

namespace Capa_Datos
{
    public class DatosEmpleados
    {
        NominaEntities db = new NominaEntities();
        public void Crear(Empleado empleados)
        {
            db.Empleado.Add(empleados);
            db.SaveChanges();
        }

        public List<Empleado> Leer()
        {
            return db.Empleado.ToList();
        }

        public void editar(Empleado user)
        {
            var resultado = db.Empleado
            .Where(m => m.ID_Empleado == user.ID_Empleado).FirstOrDefault();

            if (resultado != null)
            {
                resultado.ID_Empleado = user.ID_Empleado;
                resultado.Cedula = user.Cedula;
                resultado.Empleado_Nombre = user.Empleado_Nombre;
                resultado.Id_Depart6amento = user.Id_Depart6amento;
                resultado.Id_Puesto = user.Id_Puesto;
                resultado.Salario = user.Salario;
                resultado.ID_Igreso = user.ID_Igreso;

                db.Entry(resultado).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Empleado GetEmpleado(int id)
        {
            var usuario = db.Empleado
                .Where(m => m.ID_Empleado == id)
                .FirstOrDefault();

            return usuario;
        }
        public Empleado eliminar(Empleado empleado)
        {
            var resultado = db.Empleado
            .Where(m => m.ID_Empleado == empleado.ID_Empleado).FirstOrDefault();

            if (resultado != null)
            {
                db.Empleado.Remove(resultado);
                db.SaveChanges();

            }
            return resultado;
        }
    }
}
