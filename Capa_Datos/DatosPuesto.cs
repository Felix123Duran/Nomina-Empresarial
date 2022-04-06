using System;
using System.Collections.Generic;
using System.Linq;
using Capa_Entidaddes;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DatosPuesto
    {
        NominaEntities db = new NominaEntities();
        public void Crear(Puesto puestos)
        {
            db.Puesto.Add(puestos);
            db.SaveChanges();
        }

        public List<Puesto> Leer()
        {
            return db.Puesto.ToList();
        }

        public void editar(Puesto user)
        {
            var resultado = db.Puesto
            .Where(m => m.ID_Puesto == user.ID_Puesto).FirstOrDefault();

            if (resultado != null)
            {
                resultado.ID_Puesto = user.ID_Puesto;
                resultado.Nombre = user.Nombre;
                resultado.Rango = user.Rango;
                resultado.Saldo_Minimo = user.Saldo_Minimo;
                resultado.Saldo_Maximo = user.Saldo_Maximo;

                db.Entry(resultado).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Puesto Getpuesto(int id)
        {
            var usuario = db.Puesto
                .Where(m => m.ID_Puesto == id)
                .FirstOrDefault();

            return usuario;
        }
        public Puesto eliminar(Puesto puesto)
        {
            var resultado = db.Puesto
            .Where(m => m.ID_Puesto == puesto.ID_Puesto).FirstOrDefault();

            if (resultado != null)
            {
                db.Puesto.Remove(resultado);
                db.SaveChanges();

            }
            return resultado;
        }
    }
}
