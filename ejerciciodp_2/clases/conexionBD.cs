using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ejerciciodp_2.clases
{
    public class conexionBD
    {
        public MySqlConnection Conexion;
        public string _Usuario = string.Empty;
        public string _Contraseña = string.Empty;
        private string _Server = string.Empty;
        private string _BaseDatos = string.Empty;
        private string _Puerto = string.Empty;

        public conexionBD(string Server, string Usuario, string Contraseña)
        {
            _Server = Server;
            _Usuario = Usuario;
            _Contraseña = Contraseña;
            ConectarLoginDB();
        }

        public bool ConectarLoginDB()
        {
            bool bConectar = false;
            int ncount = 0;
        retryConectar:
            try
            {

                Conexion = new MySqlConnection();
                //Conexion.InfoMessage += Conexion_InfoMessage;
                Conexion.ConnectionString = string.Format("server={0};uid={1};password={2};database={3};Convert Zero Datetime=True;Connect Timeout=3600;", _Server, _Usuario, _Contraseña, _BaseDatos);
                Conexion.Open();

                bConectar = true;
            }
            catch (Exception ex)
            {
                ex.ToString();
                if (ncount < 3)
                {
                    ncount++;
                    goto retryConectar;
                }
            }
            return bConectar;
        }
        public bool DesconectarDB()
        {
            try
            {
                if (Conexion != null)
                {
                    if (Conexion.State != ConnectionState.Closed)
                    {
                        Conexion.Close();
                        Conexion = null;
                    }
                }
            }
            catch (Exception)
            {
                Conexion = null;
            }
            return true;
        }

        public DataTable ConsultaSqlSelectDataTable(string strSQL)
        {
            int nPeticionesFallidas = 0;
            DataTable dataTable = new DataTable();
        Reconectar:
            try
            {
                if (strSQL.Length > 0)
                {
                    using (MySqlCommand cmd = new MySqlCommand(strSQL, Conexion))
                    {
                        MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
                        cmd.CommandTimeout = 0;
                        mySqlDataAdapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                if (nPeticionesFallidas < 3)
                {
                    DesconectarDB();
                    ConectarLoginDB();
                    goto Reconectar;
                }
            }
            return dataTable;
        }
        public bool ConsultaSqlExecuteNonQuery(string strSQL)
        {
            bool respuesta = true;
            int rowsAffected = 0;
            int nPeticionesFallidas = 0;
            DataTable dataTable = new DataTable();
        Reconectar:
            try
            {
                if (strSQL.Length > 0)
                {
                    using (MySqlCommand cmd = new MySqlCommand(strSQL, Conexion))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.Text;
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                    rowsAffected = 1;
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                rowsAffected = 0;
                if (nPeticionesFallidas < 3)
                {
                    nPeticionesFallidas++;
                    DesconectarDB();
                    ConectarLoginDB();
                    goto Reconectar;
                }
            }
            return respuesta;
        }
        public string ConsultaSqlGenericaString(string strSQL)
        {
            string Response = string.Empty;
            int nPeticionesFallidas = 0;
        Reconectar:
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(strSQL, Conexion))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Response = reader.GetString(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {                
                if (nPeticionesFallidas < 3)
                {
                    nPeticionesFallidas++;
                    DesconectarDB();
                    ConectarLoginDB();
                    goto Reconectar;
                }
            }
            return Response;
        }

    }
}
