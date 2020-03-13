using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appBanco.logica;
using Oracle.DataAccess.Client;

namespace appBanco
{
    public partial class GestionSalon : Form
    {
        public GestionSalon()
        {
            InitializeComponent();
        }

      //  inicioAdmin vtnPrincipalDef = new inicioAdmin();

        private void btnRegSalon_Click(object sender, EventArgs e)
        {
            try
            {
                Salon salon = new Salon();
                int codigo, capacidad, resultado;
                String nombre, ubicacion;

                codigo = int.Parse(txtRegCodSalon.Text);
                nombre = txtRegNomSalon.Text;
                ubicacion = txtRegUbicSalon.Text;
                capacidad = int.Parse(txtRegCapaSalon.Text);

                resultado = salon.registrarSalon(codigo, nombre, ubicacion, capacidad);

                if (resultado > 0)
                {
                    MessageBox.Show("Salón Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRegCodSalon.Text = "";
                    txtRegNomSalon.Text = "";
                    txtRegUbicSalon.Text = "";
                    txtRegCapaSalon.Text = "";
                }
            }
            catch(OracleException ex)
            {
                if (ex.Number == 1)
                {
                    MessageBox.Show("Ya hay un salón registrado con ese código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 913)
                {
                    MessageBox.Show("Hubo un desbordamiento por demasiados valores, Intente de Nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegCodSalon.Text = "";
                    txtRegNomSalon.Text = "";
                    txtRegUbicSalon.Text = "";
                    txtRegCapaSalon.Text = "";
                }
            }
        }

        private void btnRegVolver_Click(object sender, EventArgs e)
        {
            this.Close();
           // vtnPrincipalDef.Show();
        }
    }
}
