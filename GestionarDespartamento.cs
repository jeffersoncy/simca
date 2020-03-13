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
    public partial class GestionarDespartamento : Form
    {

        private String codigo = "";
        public GestionarDespartamento(String codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
        }

        Validacion validar = new Validacion();
       

        private void Registrar_Click(object sender, EventArgs e)
        {
            try
            {

                departamento obj = new departamento();

            int codigoDepartamento, codigoFacultad, resultado;
            String nombreDepartamento, departamentoAnioFundacion;

            codigoDepartamento = int.Parse(txtCodigoDepartamento.Text);
            codigoFacultad = int.Parse(txtCodigoFacultad.Text);
            nombreDepartamento = txtNombreDepartamento.Text;
            departamentoAnioFundacion = dateAnioFundacionDepartamento.Text;


                resultado = obj.registrarDepartamento(codigoDepartamento, codigoFacultad, nombreDepartamento, "12/04/1994");

               

                if (resultado > 0)
                {
                    MessageBox.Show("Departamento Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigoDepartamento.Text = "";
                    txtCodigoFacultad.Text = "";
                    
                    txtNombreDepartamento.Text = "";
              
                }

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Verifique sus Datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OracleException ex)
            {
                if (ex.Number == 1)
                {
                    MessageBox.Show("Ya existe un departamento con ese codigo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 913)
                {
                    MessageBox.Show("Hubo un desbordamiento por demasiados valores, Intente de Nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigoDepartamento.Text = "";
                    txtCodigoFacultad.Text = "";
                             
                 }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            verFacultades objAdmin = new verFacultades();
            this.Hide();
            objAdmin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verDepartamentos obj = new verDepartamentos();
            obj.Show();

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            departamento obj = new departamento();

            DataSet dataSet = new DataSet();  //<- para obtener datos
            dataSet = obj.mostrarInfoDepartamentos();

          dgvVer.DataSource = dataSet.Tables[0];

        }

        private void btnRegVolver_Click(object sender, EventArgs e)
        {
            inicioAdmin vtnPrincipalDef = new inicioAdmin(this.codigo);
            this.Close();
            vtnPrincipalDef.Show();
        }
    }
}
