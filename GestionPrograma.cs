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
    public partial class GestionPrograma : Form
    {
        public GestionPrograma()
        {
            InitializeComponent();
        }

        //VentanaPrincipalDef vtnPrincipalDef = new VentanaPrincipalDef();

        private void btnRegPrograma_Click(object sender, EventArgs e)
        {
            try
            {
                Programa pro = new Programa();
                int codigo, codFac, creditos, resultado;
                String nombre;

                codigo = int.Parse(txtCodPrograma.Text);
                codFac = int.Parse(txtCodFacPrograma.Text);
                nombre = txtNomPrograma.Text;
                creditos = int.Parse(txtCreditosProgram.Text);
                resultado = pro.registrarPrograma(codigo, codFac, nombre, creditos);

                if (resultado > 0)
                {
                    MessageBox.Show("Programa Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodPrograma.Text = "";
                    txtCodFacPrograma.Text = "";
                    txtNomPrograma.Text = "";
                    txtCreditosProgram.Text = "";
                }
            }
            catch(OracleException ex)
            {
                if (ex.Number == 1)
                {
                    MessageBox.Show("Ya hay un programa registrado con ese código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 913)
                {
                    MessageBox.Show("Hubo un desbordamiento por demasiados valores, Intente de Nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodPrograma.Text = "";
                    txtCodFacPrograma.Text = "";
                    txtNomPrograma.Text = "";
                    txtCreditosProgram.Text = "";
                }
            }
        }

        private void btnVolverProgram_Click(object sender, EventArgs e)
        {
            this.Close();
           // vtnPrincipalDef.Show();
        }
    }
}
