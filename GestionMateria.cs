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
    public partial class GestionMateria : Form
    {
        public GestionMateria()
        {
            InitializeComponent();
        }

        //VentanaPrincipalDef vtnPrincipalDef = new VentanaPrincipalDef();
        Validacion validar = new Validacion();

        private void btnRegMateria_Click(object sender, EventArgs e)
        {
            try
            {
                Materia materia = new Materia();

                int codigo, correquisito = 0, semestre, creditos, cupos, resultado;
                String nombre;

                codigo = int.Parse(txtCodMateria.Text);
                //correquisito = int.Parse(txtCorrequisitoMat.Text);
                semestre = int.Parse(txtSemestreMat.Text);
                creditos = int.Parse(txtCreditosMat.Text);
                nombre = txtNombreMat.Text;
                cupos = int.Parse(txtCuposMat.Text);

                if (rbTieneCorrequisito.Checked)
                {
                    correquisito = int.Parse(txtCorrequisitoMat.Text);            
                }
                else if (rbNoTieneCorrequisito.Checked)
                {
                    correquisito = 0;
                }

                resultado = materia.registrarMateria(codigo, correquisito, semestre, creditos, nombre, cupos);

                if (resultado > 0)
                {
                    MessageBox.Show("Materia Registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodMateria.Text = "";
                    txtCorrequisitoMat.Text = "";
                    txtSemestreMat.Text = "";
                    txtCreditosMat.Text = "";
                    txtNombreMat.Text = "";
                    txtCuposMat.Text = "";
                    rbNoTieneCorrequisito.Checked = false;
                    rbTieneCorrequisito.Checked = false;
                }
            }
            catch(OracleException ex)
            {
                if (ex.Number == 1)
                {
                    MessageBox.Show("Ya hay una Materia registrado con ese codigo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 913)
                {
                    MessageBox.Show("Hubo un desbordamiento por demasiados valores, Intente de Nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodMateria.Text = "";
                    txtCorrequisitoMat.Text = "";
                    txtSemestreMat.Text = "";
                    txtCreditosMat.Text = "";
                    txtNombreMat.Text = "";
                    txtCuposMat.Text = "";
                }
            }
        }

        private void btnSalirRegMat_Click(object sender, EventArgs e)
        {
            this.Close();
           // vtnPrincipalDef.Show();
        }

        //private void txtCodMateria_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void txtCodMateria_TextChanged(object sender, EventArgs e)
        //{
        //    validar.soloNumeros(e);
        //}
    }
}
