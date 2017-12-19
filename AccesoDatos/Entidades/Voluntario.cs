using System;

namespace AccesoDatos.Entidades
{
    public class Voluntario
    {
        private string apellidos;
        private bool asegurado;
        private int calgoActual;
        private string direccion;
        private string dni;
        private string email;
        private DateTime fechaAlta;
        private DateTime fechaNacimiento;
        private int indicativo;
        private string nombre;
        private string pass;
        private int seccion;
        private int telefono;
        private int tipoAcceso;

        public Voluntario(int indicativo, string nombre, string apellidos, string email, string pass, int telefono, string direccion, string dni, int seccion, DateTime fechaNacimiento, DateTime fechaAlta, int calgoActual, bool asegurado, int tipoAcceso)
        {
            this.indicativo = indicativo;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.email = email;
            this.pass = pass;
            this.telefono = telefono;
            this.direccion = direccion;
            this.dni = dni;
            this.seccion = seccion;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaAlta = fechaAlta;
            this.calgoActual = calgoActual;
            this.asegurado = asegurado;
            this.tipoAcceso = tipoAcceso;
        }

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
            }
        }

        public bool Asegurado
        {
            get
            {
                return asegurado;
            }

            set
            {
                asegurado = value;
            }
        }

        public int CalgoActual
        {
            get
            {
                return calgoActual;
            }

            set
            {
                calgoActual = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public DateTime FechaAlta
        {
            get
            {
                return fechaAlta;
            }

            set
            {
                fechaAlta = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }

        public int Indicativo
        {
            get
            {
                return indicativo;
            }

            set
            {
                indicativo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        public int Seccion
        {
            get
            {
                return seccion;
            }

            set
            {
                seccion = value;
            }
        }

        public int Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public int TipoAcceso
        {
            get
            {
                return tipoAcceso;
            }

            set
            {
                tipoAcceso = value;
            }
        }
    }
}