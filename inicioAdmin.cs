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
using System.Data;
using appBanco.accesoDatos;
using FormulariosDeRegistro;

namespace appBanco
{
    public partial class inicioAdmin : Form
    {
        Datos misDatos = new Datos();
        private String codigo;
        public inicioAdmin(String codigo)
        {

            InitializeComponent();
            this.codigo = codigo;
            login loginAdmin = new login();
            lblNombres.Text = loginAdmin.MostrarDatosAdmin(codigo).Tables["ResultadoDatos"].Rows[0]["PERSONA_NOMBRE"].ToString();
            lblUsuario.Text = loginAdmin.MostrarDatosAdmin(codigo).Tables["ResultadoDatos"].Rows[0]["PERSONA_USUARIO"].ToString();
            lblidentificacion.Text = codigo;

        }

        private void btnGesDepDBA_Click(object sender, EventArgs e)
        {
           
            GestionarDespartamento obj = new GestionarDespartamento(this.codigo);
            this.Hide();
            obj.Show();
        }

        private void btnGesDocDBA_Click(object sender, EventArgs e)
        {
            frmGesDocente obj = new frmGesDocente(codigo);
            this.Hide();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionPersona obj = new GestionPersona(this.codigo);
            this.Hide();
            obj.Show();
        }

        private void btnGesEstDBA_Click(object sender, EventArgs e)
        {
            frmGestionEstudiante obj = new frmGestionEstudiante(this.codigo);
            this.Hide();
            obj.Show();

        }

        private void btnGesFacDBA_Click(object sender, EventArgs e)
        {
            GestionFacultad obj = new GestionFacultad(this.codigo);
            this.Hide();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }
    }
}
