using System;
using Capa_Entidaddes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
   public class DataDepartamento
    {
        public List<Departamento> Leer()
        {
            return db.Departamento.ToList();
        }
        NominaEntities db = new NominaEntities();
        public void Crear(Departamento departamento)
        {
            db.Departamento.Add(departamento);
            db.SaveChanges();
        }
        public void editar(Departamento user)
        {
            var resultado = db.Departamento
            .Where(m => m.ID_Departamento == user.ID_Departamento).FirstOrDefault();

            if (resultado != null)
            {
                resultado.ID_Departamento = user.ID_Departamento;
                resultado.Nombre_Departamento = user.Nombre_Departamento;
                resultado.Ubicacion_fisica = user.Ubicacion_fisica;
                resultado.Resposable_Area = user.Resposable_Area;

                db.Entry(resultado).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Departamento GetDepartamento(int id)
        {
            var usuario = db.Departamento
                .Where(m => m.ID_Departamento == id)
                .FirstOrDefault();

            return usuario;
        }
        public Departamento eliminar(Departamento Departamento)
        {
            var resultado = db.Departamento
            .Where(m => m.ID_Departamento == Departamento.ID_Departamento).FirstOrDefault();

            if (resultado != null)
            {
                db.Departamento.Remove(resultado);
                db.SaveChanges();

            }
            return resultado;
        }
    }
}
