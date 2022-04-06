using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capa_Datos;
using Capa_Entidaddes;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class TransaccionNegocio
    {

        DatosTransaccion data = new DatosTransaccion();
        public void TransaccionsCrear(Transaccion transaccion)
        {
            data.Crear(transaccion);
        }
        public List<Transaccion> leer()
        {
            return data.Leer();
        }

        public void Editar(Transaccion transaccion)
        {
            data.editar(transaccion);
        }

        public Transaccion GetTransaccion(int id)
        {
            return data.GetTransaccion(id);
        }
        public void Eliminar(Transaccion transaccion)
        {
            data.eliminar(transaccion);
        }
    }
}
