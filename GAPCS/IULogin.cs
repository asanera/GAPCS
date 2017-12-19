
using AccesoDatos.ACLN;
using AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazUsuario
{
    public partial class IULogin : Form
    {
        public IULogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Voluntario voluntario = VoluntarioAD.Login(tbEmail.Text, tbPass.Text);

            if (voluntario == null)
            {
                MessageBox.Show("Error en E-Mail o Contraseña", "Error en autentificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else
            {
                if(voluntario.TipoAcceso == 3)
                {
                    MessageBox.Show("Usted esta de baja y no puede acceder", "Prohibido el acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                IUInicio formInicio = new IUInicio(voluntario);
                formInicio.Activate();
                formInicio.Show();
                this.Hide();


            }

        }
        private void lbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();
        }
    }
    
}
