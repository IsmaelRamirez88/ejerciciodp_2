using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ejerciciodp_2.clases
{    
    public class modelo_datos
    {
        private string query = string.Empty;
        private conexionBD ConexionBD;
        public modelo_datos()
        {
            ConexionBD = new conexionBD("127.0.0.1", "root", "");
        }

        public bool IsConected()
        {
            bool ok = false;
            try
            {
                if (ConexionBD != null && ConexionBD.Conexion != null)
                {
                    switch (ConexionBD.Conexion.State)
                    {
                        case ConnectionState.Closed:
                        case ConnectionState.Broken:
                        case ConnectionState.Connecting:
                            ok = false;
                            break;
                        case ConnectionState.Open:
                        case ConnectionState.Fetching:
                        case ConnectionState.Executing:
                            ok = true;
                            break;
                    }
                }
                else
                {
                    ok = false;
                }
            }
            catch (Exception)
            {
                ok = false;
            }
            return ok;
        }
        public bool Insertar(int Ban, string Nombre
            , string ApellidoP, string ApellidoM, string Calle, string Numero, string Colonia)
        {
            bool Respuesta = true;
            try
            {
                int BAN = Ban;
                string ID_I = GenerarFolio();
                string NOMBRE_I = (!string.IsNullOrEmpty(Nombre) ? MySqlHelper.EscapeString(Nombre) : string.Empty);
                string APELLIDOP_I = (!string.IsNullOrEmpty(ApellidoP) ? MySqlHelper.EscapeString(ApellidoP) : string.Empty);
                string APELLIDOM_I = (!string.IsNullOrEmpty(ApellidoM) ? MySqlHelper.EscapeString(ApellidoM) : string.Empty);
                string CALLE_I = (!string.IsNullOrEmpty(Calle) ? MySqlHelper.EscapeString(Calle) : string.Empty);
                string NUMERO_I = (!string.IsNullOrEmpty(Numero) ? MySqlHelper.EscapeString(Numero) : string.Empty);
                string COLONIA_I = (!string.IsNullOrEmpty(Colonia) ? MySqlHelper.EscapeString(Colonia) : string.Empty);

                query = $"CALL practica_dp.GUARDAR_DISTRIBUIDOR({Ban}, '{ID_I}', '{NOMBRE_I}'" +
                    $", '{APELLIDOP_I}', '{APELLIDOM_I}', '{CALLE_I}', '{NUMERO_I}', '{COLONIA_I}');";
                Respuesta = ConexionBD.ConsultaSqlExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                Respuesta = false;
            }
            return Respuesta;
        }

        public DataTable Consultar(int Ban, string Id_i)
        {
            int BAN = Ban;
            string ID_I = (!string.IsNullOrEmpty(Id_i) ? MySqlHelper.EscapeString(Id_i) : string.Empty);
            
            query = $"CALL practica_dp.GUARDAR_DISTRIBUIDOR({Ban}, '{ID_I}', '', '', '', '', '', '');";
            return ConexionBD.ConsultaSqlSelectDataTable(query);
        }

        public string GenerarFolio()
        {
            string Id = string.Empty;
            query = "SELECT CONCAT('DIS',(discount + 1))  " +
                    "FROM( " +
                    "SELECT COUNT(*) discount FROM practica_dp.distributors) td; ";
            Id = ConexionBD.ConsultaSqlGenericaString(query);
            return Id;
        }

        public void DataGridViewDobleBuffer(ref DataGridView dgv)
        {
            if (!SystemInformation.TerminalServerSession)
            {
                Type dgvType = dgv.GetType();
                PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
                pi.SetValue(dgv, true, null);
            }
        }

    }
}
