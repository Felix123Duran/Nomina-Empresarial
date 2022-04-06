using System;
using Capa_Entidaddes;
using Capa_Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class DepartamentoNegocio
    {
        DataDepartamento data = new DataDepartamento();
        public void DepartamentoCrear(Departamento departamento)
        {
            data.Crear(departamento);
        }
        public List<Departamento> leer()
        {
            return data.Leer();
        }
        public void Editar(Departamento departamento)
        {
            data.editar(departamento);
        }
        public Departamento GetDepartamento(int id)
        {
            return data.GetDepartamento(id);
        }
        public void Eliminar(Departamento departamento)
        {
            data.eliminar(departamento);
        }
    }
}
