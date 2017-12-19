using AccesoDatos.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using AccesoDatos.Entidades;

namespace AccesoDatos.ACLN
{
    public class VoluntarioAD
    {
        // Construimos los adaptadores y tablas que necesitamos
        static public voluntariosTableAdapter voluntariosAdapter = new voluntariosTableAdapter();
        static public DataSet1.voluntariosDataTable voluntariosTabla = new DataSet1.voluntariosDataTable();
        static public DataView dv;

        public static DataView ObtenerVoluntario()
        {
            //Obtengo todos los voluntarios 
            voluntariosTabla = voluntariosAdapter.GetDataSinFK(); ;
            //Asocio al dataVier la tabla
            dv = new DataView(voluntariosTabla);
            return dv ;

        }

        static public Voluntario Login(string email, string pass)
        {
            voluntariosTabla = voluntariosAdapter.GetDataByEmailPass(email, pass);
            if (voluntariosTabla.Rows.Count == 0)
                return null;
            else
            {
                DataRow filaVoluntario = voluntariosTabla.Rows[0];
                DataSet1.voluntariosRow reVoluntario = (DataSet1.voluntariosRow)filaVoluntario;
                int indicativo = (int)reVoluntario.Indicativo;
                string nombre = reVoluntario.Nombre;
                int telefono = reVoluntario.Telefono;
                string direccion = reVoluntario.Direccion;
                string dni = reVoluntario.Dni;
                int seccion = reVoluntario.idSeccion;
                DateTime fechaNacimiento = reVoluntario.FechaNacimiento;
                DateTime fechaAlta = reVoluntario.FechaAlta;
                int calgoActual = reVoluntario.IdCargo;
                sbyte seguro = reVoluntario.Asegurado;
                bool asegurado = seguro == 1;
                int tipoAcceso = reVoluntario.idTipo;
                string apellidos = reVoluntario.Apellidos;

                return new Voluntario(indicativo, nombre,apellidos, email, pass, telefono, direccion, dni, seccion, fechaNacimiento,
                    fechaAlta, calgoActual, asegurado, tipoAcceso);
            }

        }

        public static DataView  BuscarVoluntarioIndicativo(int indicativo)
        {
            if (indicativo == -1)
            {
                dv.RowFilter = "";
                return dv;
            }
            dv.RowFilter = "Convert(indicativo,'System.String') Like '%" + indicativo + "%'";
            return dv;
           
        }

        public static object BuscarVoluntarioNombre(string nombre)
        {
            if (nombre == "")
            {
                dv.RowFilter = "";
                return dv;
            }
            dv.RowFilter = "Nombre Like '" + nombre + "%'";
            return dv;
        }
    }
}
