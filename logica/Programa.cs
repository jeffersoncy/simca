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
    class Programa
    {
        Datos misDatos = new Datos();

        public int registrarPrograma(int cod, int codFacultad, String nombre, int creditos)
        {
            String consulta;
            consulta = "insert into programa values(" + cod + ", " + codFacultad +", '" + nombre + "', " + creditos +")";
            return misDatos.ejecutarDML(consulta);
        }
        
        public int actualizarPrograma(int cod, int codFacultad, String nombre, int creditos)
        {
            String consulta;
            consulta = "update programa set programa_nombre = '" + nombre +"', programaTotalCreditos = " + creditos + " where programa_codigo = "+ cod;
            return misDatos.ejecutarDML(consulta);
        }

        public int eliminarPrograma(int codigo)
        {
            String consulta = "delete from programa where programa_codigo = "+ codigo;
            return misDatos.ejecutarDML(consulta);
        }
    }
}
