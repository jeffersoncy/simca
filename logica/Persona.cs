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
    class Persona
    {
        Datos misDatos = new Datos();

        public int ingresarPersona(double ident,string nombre, string apell, string fechanac, string usu, string rol, string contra, string correo)
        {
            string consulta;
            consulta = "Insert into Persona Values(" +
            ident + ",'" + nombre + "','" + apell + "','" + fechanac + "','" + usu + "','" + rol + "','" + contra + "','" + correo + "')";
            // ejecutar insert update delete DML
            return misDatos.ejecutarDML(consulta);
        }

        public int verificarCredenciales(string nickname, string password)
        {
            string consulta;
            consulta = "select persona_nombre from persona where persona_usuario = 'uu' and persona_contrasena = 'con'";
            //consulta = "select persona_nombre from persona where persona_usuario = '"+nickname+"' and persona_contrasena = '"+password+"')";

            return misDatos.ejecutarDML(consulta);
        }
        //public int ingresarCliente(double id, string nombre, string apellido, string fecha)
        //{
        //    string consulta;

        //        consulta = "Insert into Cliente(clId,clNombre,clApellido,clFechaNacimiento) Values(" +
        //    id + ",'" + nombre + "','" + apellido + "','" + fecha + "')";
        //        // ejecutar insert update delete DML
        //        return misDatos.ejecutarDML(consulta);
        //}
        //public int actualizarCliente(double id, string nombre, string apellido, string fecha)
        //{
        //    string consulta;
        //    consulta = "Update Cliente set clId = " + id + ",clNombre = '" + nombre + "',clApellido = '" + apellido + "',clFechaNacimiento = '" + fecha + "' where clId =" + id;
        //    //Ejecutar Insert, update, delete DML
        //    return misDatos.ejecutarDML(consulta);
        //}
        public DataSet consultarXCliente(double clIdent)
        {
            string consulta;
            consulta = "select * from Persona where persona_Ident =" + clIdent;
            return misDatos.ejecutarSELECT(consulta);
        }
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
        //public DataSet mostrarClientesDisponibles()
        //{
        //    string consulta;
        //    consulta = "select cliente.clid Identificación, cliente.clnombre nombre, cliente.clapellido from cliente left join prestamo on prestamo.clid = cliente.clid where prestamo.clid is null ";
        //    return misDatos.ejecutarSELECT(consulta);
        //}
    }
}
