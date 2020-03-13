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
    class Salon
    {
        Datos misDatos = new Datos();

        public int registrarSalon(int codigo, String nombre, String ubicacion, int capacidad)
        {
            String consulta;
            consulta = "insert into Salon values(" + codigo +", '" + nombre + "', '" + ubicacion + "', " + capacidad + ")" ;
            return misDatos.ejecutarDML(consulta);
        }
        
        public int actualizarSalon(int codigo, String nombre, String ubicacion, int capacidad)
        {
            String consulta;
            consulta = "update salon set salon_nom = '" + nombre + "', salon_ubicacion = '" + ubicacion + "', salon_capacidad = " + capacidad + " where salon_cod = " + codigo;
            return misDatos.ejecutarDML(consulta);
        }

        public int eliminarSalon(int codigo)
        {
            String consulta = "delete from salon where salon_cod = "+ codigo;
            return misDatos.ejecutarDML(consulta);
        }
        
    }
}
