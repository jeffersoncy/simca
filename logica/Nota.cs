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
    class Nota
    {
        Datos misDatos = new Datos();

        public int ingresarNota()
        {
            string consulta;

            consulta = "insert into nota values(14,4,4,3)";
            // ejecutar insert update delete DML
            return misDatos.ejecutarDML(consulta);
        }
    }
}
