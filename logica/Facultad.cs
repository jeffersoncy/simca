using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appBanco.accesoDatos;
using System.Windows.Forms;
using System.Data;

namespace appBanco.logica
{
    class Facultad
    {
        Datos misDatos = new Datos();

        public int registrarFacultad(int codigo, string nombreFac, String nombreDecano)
        {
            String consulta;
            consulta = "insert into facultad values("+ codigo + ", '" + nombreFac + "', '" + nombreDecano + "')";
            return misDatos.ejecutarDML(consulta);
        }

        public int modificarFacultad(int codigo, string nombreFac, String nombreDecano)
        {
            String consulta;
            consulta = "Update facultad set facultad_Codigo = " + codigo + ",facultad_nombre = '" + nombreFac + "', facultad_nombredecano = '" + nombreDecano + "' where facultad_codigo =" + codigo;
            return misDatos.ejecutarDML(consulta);
        }

        public int eliminarFacultad(int cod)
        {
            String consulta = "delete from facultad where facultad_codigo ="+ cod;
            return misDatos.ejecutarDML(consulta);
        }
    }
}
