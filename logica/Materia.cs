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
    class Materia
    {
        Datos misDatos = new Datos();

        public int registrarMateria(int cod, int corequisito, int matSemestre, int matCreditos, String nombre, int cupos)
        {
            String consulta;  // Se debe manejar con un radioButton donde 0 no tiene correquisito;
            if (corequisito == 0)
            {
                consulta = "insert into materia values("+ cod +", '"+ null +"', "+ matSemestre +", "+ matCreditos +", '"+ nombre +"', "+ cupos +")";
                return misDatos.ejecutarDML(consulta);
            }
            else
            {
                consulta = "insert into materia values("+ cod +", "+ corequisito + ", "+ matSemestre +", "+ matCreditos +", '"+ nombre + "', "+ cupos +")";
                 return misDatos.ejecutarDML(consulta);
            }
        }

        public int modificarMateria(int cod, int corequisito, int matSemestre, int matCreditos, String nombre, int cupos)
        {
            String consulta;
            consulta = "Update materia set mat_cod = " + cod + ", mat_mat_cod = " + corequisito + ", mat_semestre = " + matSemestre +
                                           ", mat_creditos = " + matCreditos + ", mat_nombre = '" + nombre + "', mat_numcupos = " + cupos + " where mat_cod = " + cod; 
            return misDatos.ejecutarDML(consulta);
        }

        public int eliminarMateria(int codigo)
        {
            String consulta = "delete from materia where mat_cod = "+ codigo;
            return misDatos.ejecutarDML(consulta);
        } 

    }
}
