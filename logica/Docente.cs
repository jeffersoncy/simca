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
    class Docente
    {
        Datos misDatos = new Datos();

        public int ingresarDocente(double identif, double codDocente, int numeroOficina, string area, string especializacion)
        {
            string consulta;
            consulta = "Insert into Profesor Values(" +
            codDocente + "," + identif + "," + numeroOficina + ",'" + area + "','" + especializacion + "')";
            // ejecutar insert update delete DML
            return misDatos.ejecutarDML(consulta);
        }
        public DataSet consultarXPersona(double PerIdent)
        {
            string consulta;
            consulta = "select * from Persona where persona_Ident =" + PerIdent;
            return misDatos.ejecutarSELECT(consulta);
        }
        public DataSet consultarXDocenteActualizar(double DocIdent, double DocCodigo)
        {
            string consulta;
            consulta = "select * from Persona where persona_Ident =" + DocIdent + " and Profesor_Codigo = " + DocCodigo;
            return misDatos.ejecutarSELECT(consulta);
        }
        //public int actualizarCliente(double id, string nombre, string apellido, string fecha)
        //{
        //    string consulta;
        //    consulta = "Update Cliente set clId = " + id + ",clNombre = '" + nombre + "',clApellido = '" + apellido + "',clFechaNacimiento = '" + fecha + "' where clId =" + id;
        //    //Ejecutar Insert, update, delete DML
        //    return misDatos.ejecutarDML(consulta);
        //}
        //public int eliminarCliente(double clId)
        //{
        //    string consulta = "delete from cliente where clId =" + clId;

        //    return misDatos.ejecutarDML(consulta);
        //}
        public DataSet mostrarPersona()
        {
            string consulta;
            consulta = "select persona_ident, persona_nombre, persona_apellido from persona";
            return misDatos.ejecutarSELECT(consulta);
        }
        //public DataSet mostrarDocente()
        //{
        //    string consulta;
        //    consulta = "select persona_ident, persona_nombre, persona_apellido from persona";
        //    return misDatos.ejecutarSELECT(consulta);
        //}
    }
}
