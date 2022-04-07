using System;
using System.Collections.Generic;
using System.Linq;
using Capa_Entidaddes;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DatosDetallesNomina
    {
        NominaEntities db = new NominaEntities();
        public void Crear(Detalles_nomina detalles_nominas)
        {
            db.Detalles_nomina.Add(detalles_nominas);
            db.SaveChanges();
        }

        public List<Detalles_nomina> Leer()
        {
            return db.Detalles_nomina.ToList();
        }

        public void editar(Detalles_nomina user)
        {
            var resultado = db.Detalles_nomina
            .Where(m => m.ID_Detalle_Nomina == user.ID_Detalle_Nomina).FirstOrDefault();

            if (resultado != null)
            {
                resultado.ID_Detalle_Nomina = user.ID_Detalle_Nomina;
                resultado.id_Nomina = user.id_Nomina;
                resultado.ID_Empleado = user.ID_Empleado;
                resultado.ID_Trancaccion = user.ID_Trancaccion;

                db.Entry(resultado).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Detalles_nomina GetDetalles_nomina(int id)
        {
            var usuario = db.Detalles_nomina
                .Where(m => m.ID_Detalle_Nomina == id)
                .FirstOrDefault();

            return usuario;
        }
        public Detalles_nomina eliminar(Detalles_nomina Detalles_nomina)
        {
            var resultado = db.Detalles_nomina
            .Where(m => m.ID_Detalle_Nomina == Detalles_nomina.ID_Detalle_Nomina).FirstOrDefault();

            if (resultado != null)
            {
                db.Detalles_nomina.Remove(resultado);
                db.SaveChanges();

            }
            return resultado;
        }
    }
}
