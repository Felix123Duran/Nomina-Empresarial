using System;
using System.Collections.Generic;
using System.Linq;
using Capa_Entidaddes;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DatosTipos_ingreso
    {
        NominaEntities db = new NominaEntities();
        public void Crear(Tipos_Ingresos Tipo_Ingresos)
        {
            db.Tipos_Ingresos.Add(Tipo_Ingresos);
            db.SaveChanges();
        }

        public List<Tipos_Ingresos> Leer()
        {
            return db.Tipos_Ingresos.ToList();
        }

        public void editar(Tipos_Ingresos user)
        {
            var resultado = db.Tipos_Ingresos
            .Where(m => m.ID_Ingresos == user.ID_Ingresos).FirstOrDefault();

            if (resultado != null)
            {
                resultado.ID_Ingresos = user.ID_Ingresos;
                resultado.Nombre = user.Nombre;
                resultado.Salario_estandar = user.Salario_estandar;
                resultado.Estado = user.Estado;

                db.Entry(resultado).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Tipos_Ingresos GetTipo_Ingreso(int id)
        {
            var usuario = db.Tipos_Ingresos
                .Where(m => m.ID_Ingresos == id)
                .FirstOrDefault();


            return usuario;
        }
        public Tipos_Ingresos eliminar(Tipos_Ingresos Tipo_Ingreso)
        {
            var resultado = db.Tipos_Ingresos
            .Where(m => m.ID_Ingresos == Tipo_Ingreso.ID_Ingresos).FirstOrDefault();

            if (resultado != null)
            {
                db.Tipos_Ingresos.Remove(resultado);
                db.SaveChanges();

            }
            return resultado;
        }
    }
}
