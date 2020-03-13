using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
namespace appBanco.accesoDatos
{
    class Datos
    {
        //construyo la cadena de conexión desde localhost copiando los datos 
        //el arroba hace que no omita las cadenas con escape
        string cadenaConexion = @"Data Source=localhost;User ID=simca2;Password=simca2";

        //metodo para ejecutar DML(insert, update, delete)
        public int ejecutarDML(string consulta)
        {
            int filasAfectadas;
            //paso 1: creo una conexion
            OracleConnection miConexion = new OracleConnection(cadenaConexion);
            //paso 2: creo un comando 
            OracleCommand comando = new OracleCommand(consulta, miConexion);
            //paso 3: abrir conexion
            miConexion.Open();
            /*paso 4: ejecuto el comando. Este devuelve el numero de filas 
             * que se afectaron ya sea con el insert, update o delete que viene en
             * la consulta */
            filasAfectadas = comando.ExecuteNonQuery();
            return filasAfectadas;
        }
        //metodo para ejecutar sentencias select
        public DataSet ejecutarSELECT(string consulta)
        {
            //Paso 1: crear un data set vacio
            DataSet ds = new DataSet();
            //Paso 2: creo un adaptador
            OracleDataAdapter miAdaptador = new OracleDataAdapter(consulta, cadenaConexion);
            //Paso 3: lleno el data set a través del adaptador
            miAdaptador.Fill(ds, "ResultadoDatos");
            return ds;
        }
    }
}
