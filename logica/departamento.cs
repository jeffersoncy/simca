using appBanco.accesoDatos;
using System;
using System.Data;

namespace appBanco.logica


{ 
    class departamento
    {

        Datos misDatos = new Datos();
        public int registrarDepartamento(int departamento_codigo, int facultad_codigo, String departamento_nombre,
            String departamento_aniofundacion)
        {
            string consulta;
            // profesor_codigo
            //consulta = "insert into departamento values (6,4,'departamento','12/02/1990')";
            consulta = "insert into departamento values ("+departamento_codigo+","+facultad_codigo+",'"+departamento_nombre+"','"+departamento_aniofundacion+"')";
            // ejecutar insert update delete DML
            return misDatos.ejecutarDML(consulta);
        }


        public int actualizar_Departamento(int departamento_codigo,  int facultad_codigo, int departamento_nombre, int departamento_aniofundacion)
        {
            string consulta;

            consulta = "update departamento set facultad_codigo = "+facultad_codigo+", departamento_nombre = '"+departamento_nombre+
                "', departamento_aniofundacion = '"+departamento_aniofundacion+"' where departamento_codigo = "+departamento_codigo;
            // ejecutar insert update delete DML
            return misDatos.ejecutarDML(consulta);
        }


        public DataSet mostrarDepartamentos()
        {
            string consulta;
            consulta = "select departamento_codigo as codigo,  departamento_nombre as nombre from departamento";
           return misDatos.ejecutarSELECT(consulta);
        }

        public DataSet mostrarInfoDepartamentos()
        {
            string consulta;
            consulta = "select departamento_codigo as codigo, facultad_codigo, departamento_nombre as nombre, departamento_aniofundacion as año from departamento";
            return misDatos.ejecutarSELECT(consulta);
        }


    }
}
