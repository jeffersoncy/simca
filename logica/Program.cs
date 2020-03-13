using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using appBanco.logica;

namespace appBanco
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Nota nota1= new Nota();
            //nota1.ingresarNota();
            //Persona persona1 = new Persona();
            //persona1.ingresarPersona();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GestionarDespartamento());

            //departamento dep = new departamento();
            //dep.registrarDepartamento(6, 4, "departamento", "12/02/1990");


        }
    }
}
