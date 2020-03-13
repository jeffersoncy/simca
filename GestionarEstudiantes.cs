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

namespace FormulariosDeRegistro
{
    public partial class frmGestionEstudiante : Form
    {

        private String codigo = "";
        public frmGestionEstudiante(String codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            inicioAdmin vtnPrincipalDef = new inicioAdmin(this.codigo);
            this.Close();
            vtnPrincipalDef.Show();
        }
    }
}
