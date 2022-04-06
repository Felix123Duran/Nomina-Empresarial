using System;
using System.Collections.Generic;
using Capa_Entidaddes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DatosNomina
    {
        NominaEntities db = new NominaEntities();
        public void Crear(Nomina nomina)
        {
            db.Nomina.Add(nomina);
            db.SaveChanges();
        }

        public List<Nomina> Leer()
        {
            return db.Nomina.ToList();
        }

        public void editar(Nomina user)
        {
            var resultado = db.Nomina
            .Where(m => m.ID_nomina == user.ID_nomina).FirstOrDefault();

            if (resultado != null)
            {
                resultado.ID_nomina = user.ID_nomina;
                resultado.ID_Empleado = user.ID_Empleado;
                resultado.Desde = user.Desde;
                resultado.hasta = user.hasta;


                db.Entry(resultado).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Nomina GetNomina(int id)
        {
            var usuario = db.Nomina
                .Where(m => m.ID_nomina == id)
                .FirstOrDefault();

            return usuario;
        }
        public Nomina eliminar(Nomina nomina)
        {
            var resultado = db.Nomina
            .Where(m => m.ID_nomina == nomina.ID_nomina).FirstOrDefault();

            if (resultado != null)
            {
                db.Nomina.Remove(resultado);
                db.SaveChanges();

            }
            return resultado;
        }
    }
}
