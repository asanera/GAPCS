
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
    public partial class IUVoluntarios : Form
    {
        private Voluntario voluntario;
        public IUVoluntarios()
        {
            InitializeComponent();
        }

        public IUVoluntarios(Voluntario voluntario)
        {
            this.voluntario = voluntario;
            InitializeComponent();
        }

        private void IUVoluntarios_Load(object sender, EventArgs e)
        {

            //Nombre y apellidos
            lbBienvenida.Text = voluntario.Nombre + " " + voluntario.Apellidos;
            lbCargo.Text = CargoAD.ObtenerCargo(voluntario.CalgoActual);
            //Cargo los componentes del administrador
            if(voluntario.TipoAcceso == 2)
            {
                pnCabezal.Visible = false;
                pnCuerpo.Visible = false;
                lbEdicion.Visible = false;
                btnAñadirUsuario.Visible = false;
            }
            //Configuro el dataset
            dgvVoluntarios.DataSource = VoluntarioAD.ObtenerVoluntario();
            dgvVoluntarios.Columns["idSeccion"].Visible = false;
            dgvVoluntarios.Columns["idCargo"].Visible = false;
            dgvVoluntarios.Columns["idTipo"].Visible = false;
            dgvVoluntarios.Columns["idVoluntarios"].Visible = false;

            //Ordeno las columnas
            dgvVoluntarios.Columns["cargos"].DisplayIndex = 13;
            dgvVoluntarios.Columns["Seccion"].DisplayIndex = 14;
            dgvVoluntarios.Columns["Acceso"].DisplayIndex = dgvVoluntarios.Columns.Count - 3;

            //Si es voluntario no puede ver editar ni eliminar
            if (voluntario.TipoAcceso == 2)
            {
                dgvVoluntarios.Columns[0].Visible = false;
                dgvVoluntarios.Columns[1].Visible = false;
            }
        }
        private void lbMiminizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void tbBusIndicativo_TextChanged(object sender, EventArgs e)
        {
            int indicativo;
            if(tbBusIndicativo.Text == "")
            {
               dgvVoluntarios.DataSource = VoluntarioAD.BuscarVoluntarioIndicativo(-1);
               return;
            }
            if(!int.TryParse(tbBusIndicativo.Text, out indicativo))
            {
                MessageBox.Show("Error! Por favor introduzca solo numero. \n\n ¡Erees muuuuy torpe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbBusIndicativo.Text = "";
                return;

            }
            dgvVoluntarios.DataSource = VoluntarioAD.BuscarVoluntarioIndicativo(indicativo);
        }

        private void tbBusNombre_TextChanged(object sender, EventArgs e)
        {
            string nombre = "";
            if (tbBusNombre.Text == "")
            {
                dgvVoluntarios.DataSource = VoluntarioAD.BuscarVoluntarioNombre(nombre);
                tbBusNombre.Text = "";
                return;
            }
            nombre = tbBusNombre.Text;
            dgvVoluntarios.DataSource = VoluntarioAD.BuscarVoluntarioNombre(nombre);
        }
    }
}
