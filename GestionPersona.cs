using appBanco;
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
    public partial class GestionPersona : Form
    {
        private String codigo = "";
        public GestionPersona(String codigo)
        {
            InitializeComponent();
            this.codigo= codigo;
        }
        Validacion validar = new Validacion();
        
        #region Registrar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona PersonaReg = new Persona();
                //Asignación a las variables de los datos ingresados por el usuario
                double identificacion;
                int resultado;
                string nombre, apellido,nickname,contrasena,correo,rol;
                string fechanacim;
                identificacion = double.Parse(txtIdentificacionPersona.Text);
                nombre = txtNombrePersona.Text;
                apellido = txtApellidoPersona.Text;
                fechanacim = dtpFechaNacPersona.Text;
                nickname = txtUsuarioPersona.Text;
                contrasena = txtPassworldPersona.Text;
                rol = txtRolPersona.Text;
                correo = txtCorreoPersona.Text;
                resultado = PersonaReg.ingresarPersona(identificacion, nombre, apellido, fechanacim,nickname,rol,contrasena,correo);
                //Creación Mensajes de validación
                if (resultado > 0)
                {
                    MessageBox.Show("Persona Registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdentificacionPersona.Text = "";
                    txtNombrePersona.Text = "";
                    txtApellidoPersona.Text = "";
                    
                }
            }
            catch (OracleException ex)
            {
                if (ex.Number==1)
                {
                    MessageBox.Show("Ya hay una Persona registrado con esa identificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 913)
                {
                    MessageBox.Show("Hubo un desbordamiento por demasiados valores, Intente de Nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIdentificacionPersona.Text = "";
                    txtNombrePersona.Text = "";
                    txtApellidoPersona.Text = "";
                }
            }
        }
        #endregion
        #region Eliminar
        //private void btnElimCliente_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        btnElimCliente.Enabled = false;
        //        Persona clienteElim = new Persona();
        //        double clId;
        //        int resultado;
        //        clId = double.Parse(txtElimIdCliente.Text);
        //        resultado = clienteElim.eliminarCliente(clId);

        //        if (resultado > 0)
        //        {
        //            MessageBox.Show("Cliente Eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            txtElimIdCliente.Text = "";
        //        }
        //    }
        //    catch (OracleException ex)
        //    {
        //        if (ex.Number == 2292)
        //        {
        //            MessageBox.Show("No se puede eliminar el Cliente, porque esta asociado a un prestamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            txtElimIdCliente.Text = "";
        //        }
        //        if (ex.Number == 933)
        //        {
        //            MessageBox.Show("Hubo un desbordamiento por demasiados valores, Intente de Nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            txtElimIdCliente.Text = "";
        //        }
        //    }

        //}
        #endregion
        #region Actualizar
        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            try
            {
                Persona PerBusc = new Persona();
                double PerIdent;
                PerIdent = double.Parse(txtBuscarCliente.Text);
                DataSet miDS = new DataSet();

                miDS = PerBusc.consultarXCliente(PerIdent);
                if (miDS.Tables[0].Rows.Count > 0)
                {
                    txtBuscarCliente.Text = "";
                    lbActClient.Text = miDS.Tables[0].Rows[0]["persona_ident"].ToString();
                    txtActClNombre.Text = miDS.Tables[0].Rows[0]["persona_nombre"].ToString();
                    txtActClApell.Text = miDS.Tables[0].Rows[0]["persona_apellido"].ToString();
                    dtpActFechaNac.Value = Convert.ToDateTime(miDS.Tables[0].Rows[0]["persona_FechaNacimiento"].ToString());
                }
                else
                {
                    MessageBox.Show("El Cliente no esta registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (OracleException ex)
            {
                if (ex.Number == 933)
                {
                    MessageBox.Show("Hubo un desbordamiento por demasiados valores, Intente de Nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBuscarCliente.Text = "";
                }
            }
        }
        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                login PersonaAct = new login();
                double perId;
                int resultado;
                string nombre, apellido, fechaNacim;
                perId = double.Parse(lbActClient.Text);
                nombre = txtActClNombre.Text;
                apellido = txtActClApell.Text;
                fechaNacim = dtpActFechaNac.Text;
                //resultado = clienteAct.actualizarCliente(clId, nombre, apellido, fechaNacim);
                //if (resultado > 0)
                //{
                //    MessageBox.Show("Cliente Actualizado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    lbActClient.Text = "";
                //    txtActClNombre.Text = "";
                //    txtActClApell.Text = "";
                //}
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Verifique sus Datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion
        #region ValidacionesRegistrar
        private void puedeRegistrarCliente()
        {
            if (txtIdentificacionPersona.TextLength >0 && txtNombrePersona.TextLength>0 && txtApellidoPersona.TextLength>0)
            {
                btnRegistrar.Enabled = true;
            }else
            {
                btnRegistrar.Enabled = false;
            }
        }
        private void txtIdentificacionCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e);
        }
        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloLetras(e);
        }
        private void txtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloLetras(e);
        }
        private void txtIdentificacionCliente_TextChanged(object sender, EventArgs e)
        {
            puedeRegistrarCliente();
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            puedeRegistrarCliente();
        }

        private void txtApellidoCliente_TextChanged(object sender, EventArgs e)
        {
            puedeRegistrarCliente();
        }
        #endregion

        #region ValidacionesActualizar
        private void puedeActualizarCliente()
        {
            if (txtBuscarCliente.TextLength > 0)
            {
                btnBuscarCliente.Enabled = true;
            }
            else
            {
                btnBuscarCliente.Enabled = false;
            }
            if (txtActClNombre.TextLength > 0 && txtActClApell.TextLength>0)
            {
                btnActualizar.Enabled = true;
            }else
            {
                btnActualizar.Enabled = false;
            }
        }
        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e);
        }
        private void txtActClNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloLetras(e);
        }
        private void txtActClApell_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloLetras(e);
        }
        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            puedeActualizarCliente();
        }

        private void txtActClNombre_TextChanged(object sender, EventArgs e)
        {
            puedeActualizarCliente();
        }

        private void txtActClApell_TextChanged(object sender, EventArgs e)
        {
            puedeActualizarCliente();
        }

        #endregion

        #region ValidacionesEliminar
        private void puedeEliminarCliente()
        {
            if (txtElimIdCliente.TextLength>0)
            {
                btnElimCliente.Enabled = true;
            }
        }
        private void txtElimIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e);
        }
        private void txtElimIdCliente_TextChanged(object sender, EventArgs e)
        {
            puedeEliminarCliente();
        }
        #endregion
        private void BtnActSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            inicioAdmin vtnPrincipalDef = new inicioAdmin(this.codigo);
            this.Close();
            vtnPrincipalDef.Show();
        }
        private void btnSalirE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerId_Click(object sender, EventArgs e)
        {
            //verDatosPersona vtna = new verDatosPersona();
            //vtna.Show();
        }

        private void btnVerIDS_Click(object sender, EventArgs e)
        {

        }

    }
}
