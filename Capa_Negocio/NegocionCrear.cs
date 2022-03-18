using System;
using Capa_Entidaddes;
using Capa_Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class NegocionCrear
    {
        DatosCrear data = new DatosCrear();
        public void Empleados(Empleado empleado)
        {
            data.Empleados(empleado);
        }
        public void Departamento(Departamento departamento)
        {
            data.Departamentos(departamento);
        }
        public void Puesto(Puesto puesto)
        {
            data.Puesto(puesto);
        }
        public void TipoIngreso(Tipos_Ingresos TipoIngreso)
        {
            data.TipoIngreso(TipoIngreso);
        }
        public void Transacciones(Transaccion transacciones)
        {
            data.Transacciones(transacciones);
        }
        public void nomina(Nomina nomina)
        {
            data.Nomina(nomina);
        }
        public void Detalles_Nomina(Detalles_nomina detalles_Nomina)
        {
            data.Detalles_Nomina(detalles_Nomina);
        }
    }
}
