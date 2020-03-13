using System;

using System.Data;
using System.Windows.Forms;
using appBanco.logica;
using Oracle.DataAccess.Client;
using FormulariosDeRegistro;

namespace appBanco
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        login persona = new login();
        Validacion validar = new Validacion();



        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();  //<- para obtener datos
            try
            {
                int resultado;
                string nickname = "", password = "", rol = "", codigo ="";

                nickname = txt_user_nickname.Text;
                password = txt_user_pass.Text;

                dataSet = persona.verificarCredenciales(nickname,password);


                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    txt_user_nickname.Text = "";
                    txt_user_pass.Text = "";
                    nickname = dataSet.Tables["ResultadoDatos"].Rows[0]["PERSONA_NOMBRE"].ToString();
                    rol = dataSet.Tables["ResultadoDatos"].Rows[0]["PERSONA_ROL"].ToString();
                    codigo = dataSet.Tables["ResultadoDatos"].Rows[0]["PERSONA_IDENT"].ToString();
                    if (rol == "0") //estudiante
                    {

                        InicioEstudiante objEstudiante = new InicioEstudiante();
                        this.Hide();
                        objEstudiante.Show();

                    }


                    else if (rol == "1") //profesor
                    {

                        //InterfasPrincipalProfesor objProfesor = new InterfasPrincipalProfesor();
                        inicioProfesor objProfesor = new inicioProfesor();
        

                        this.Hide();
                        objProfesor.Show();
                    }
                    else if (rol == "2") //administrativo
                    {
                       
                      inicioAdmin objAdmin = new inicioAdmin(codigo);
                        this.Hide();
                        objAdmin.Show();

                    }


                }
                else
                {
                    txt_user_nickname.Text = "";
                    txt_user_pass.Text = "";
                    MessageBox.Show("Error... Verifique sus Datos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Verifique sus Datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txt_user_nickname_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloLetras(e);
        }
    }
}
