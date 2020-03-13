using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appBanco.logica;
using System.Windows.Forms;

namespace appBanco
{
    public partial class verDepartamentos : Form
    {
        public verDepartamentos()
        {
            InitializeComponent();
        }
        departamento obj = new departamento();
        private void btnConsultarDepartamentos_Click(object sender, EventArgs e)
        {
            
            DataSet dataSet = new DataSet();  //<- para obtener datos
            dataSet = obj.mostrarDepartamentos();

            dgvDepartamentos.DataSource = dataSet.Tables[0];
      
        }
    }
}
