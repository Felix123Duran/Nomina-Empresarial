using System;
using System.Collections.Generic;
using System.Linq;
using Capa_Entidaddes;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
   public class DatosTransaccion
    {

        NominaEntities db = new NominaEntities();
        public void Crear(Transaccion transaccions)
        {
            db.Transaccion.Add(transaccions);
            db.SaveChanges();
        }

        public List<Transaccion> Leer()
        {
            return db.Transaccion.ToList();
        }

        public void editar(Transaccion user)
        {
            var resultado = db.Transaccion
            .Where(m => m.ID_Transaccion == user.ID_Transaccion).FirstOrDefault();

            if (resultado != null)
            {
                resultado.ID_Transaccion = user.ID_Transaccion;
                resultado.Descripcion = user.Descripcion;
                resultado.ID_Tipo_Transaccion = user.ID_Tipo_Transaccion;
                resultado.Estatus = user.Estatus;

                db.Entry(resultado).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Transaccion GetTransaccion(int id)
        {
            var usuario = db.Transaccion
                .Where(m => m.ID_Transaccion == id)
                .FirstOrDefault();

            return usuario;
        }
        public Transaccion eliminar(Transaccion transaccions)
        {
            var resultado = db.Transaccion
            .Where(m => m.ID_Transaccion == transaccions.ID_Transaccion).FirstOrDefault();

            if (resultado != null)
            {
                db.Transaccion.Remove(resultado);
                db.SaveChanges();

            }
            return resultado;
        }
    }
}
