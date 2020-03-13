using System;
using appBanco;
using System.Windows.Forms;

namespace FormulariosDeRegistro
{
    public partial class inicioProfesor : Form
    {
        public inicioProfesor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }
    }
}
