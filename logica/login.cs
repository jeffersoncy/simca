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
    class login
    {
        Datos misDatos = new Datos();

        public DataSet verificarCredenciales(string nickname, string password)
        {
            string consulta;
            consulta = "select persona_nombre, persona_rol, persona_ident from persona where persona_usuario = '"+nickname+"' and persona_contrasena = '"+password+"'";
           // consulta = "select persona_nombre, persona_rol from persona where persona_usuario = 'lcarlos' and persona_contrasena = 444";
            return misDatos.ejecutarSELECT(consulta);
        }


        public DataSet mostrarNombre_Contratacion()
        {
            string consulta;
            consulta = "select bannit NIT,bannombre NOMBRE from Banco";
            return misDatos.ejecutarSELECT(consulta);
        }

        public DataSet MostrarDatosAdmin(String codigo)
        {
            string consulta;
            consulta = "select persona_nombre, persona_usuario from persona where persona_ident = " + codigo;
            return misDatos.ejecutarSELECT(consulta);
        }

    }
}
