using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazUsuario;
using AccesoDatos.Entidades;
using AccesoDatos.ACLN;

namespace InterfazUsuario
{
    public partial class IUInicio : Form
    {
        public Voluntario voluntario;
        public IUInicio()
        {
            InitializeComponent();
        }
        public IUInicio(Voluntario voluntario)
        {
            this.voluntario = voluntario;
            InitializeComponent();
            if (voluntario.TipoAcceso == 1)
                lbInfoVol.Text = "Editar y ver todos \nlos voluntarios";
            else
                lbInfoVol.Text = "Ver todos \nlos voluntarios";

        }

        private void IUInicio_Load(object sender, EventArgs e)
        {
            lbBienvenida.Text += voluntario.Nombre;
            //Inserto el cargo del voluntario
            lbCargo.Text += CargoAD.ObtenerCargo(voluntario.CalgoActual);

        }

        private void lbMiminizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();

        }

        private void pnVoluntario_Click(object sender, EventArgs e)
        {

            IUVoluntarios formVoluntarios = new IUVoluntarios(voluntario);
            formVoluntarios.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            IULogin formLoging = new IULogin();
            formLoging.Show();
            formLoging.Activate();
            this.Close();
            this.Dispose();
        }
    }
}
