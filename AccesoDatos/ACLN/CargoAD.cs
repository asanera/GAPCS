using AccesoDatos.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.ACLN
{
    public class CargoAD
    {
        //Construimos los adaptadores y tablas que necesitamos
        static private cargosTableAdapter cargosAdapter = new cargosTableAdapter();
        static private DataSet1.cargosDataTable voluntariosTabla = new DataSet1.cargosDataTable();

        static public string ObtenerCargo(int idCargo)
        {
            return cargosAdapter.ObtenerCargoPorId(idCargo).ToString();
        }

    }
}
