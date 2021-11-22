using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{

    public class DataBaseControls
    {
		private SqlConnection conexion;
		private SqlCommand command;
		private SqlDataReader reader;

		public DataBaseControls()
		{
			conexion = new SqlConnection(@"Data Source = .\SQLEXPRESS;Database = TP4MendezJulioDB;Trusted_Connection = True;");
			command = new SqlCommand();

			Command.CommandType = CommandType.Text;
			Command.Connection = Connection;
		}
		public DataBaseControls(string connectionString):this()
		{
            conexion.ConnectionString = connectionString;
        }

		public SqlConnection Connection { get => conexion; set => conexion = value; }
		public SqlCommand Command { get => command; set => command = value; }
		public SqlDataReader Reader { get => reader; set => reader = value; }
        /// <summary>
        /// Lee la Tabla en la base de datos y retorna una lista de objetos clase Pais con todos los objetos validos en la tabla.
        /// </summary>
        /// <returns>Lista de paises en la tabla de la base de datos.</returns>
        public List<Pais> LeerListaDeDB()
        {
            try
            {
                List<Pais> listaAux = new List<Pais>();
                Command.CommandText = "select * from dbo.PAISES";

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                reader = Command.ExecuteReader();
                while (reader.Read() == true)
                {
                    Pais auxPais = new Pais();

                    auxPais.Nombre = reader["NOMBRE"].ToString();
                    auxPais.Poblacion = (int)reader["POBLACION"];
                    auxPais.Potencia = reader.GetBoolean("POTENCIA");
                    auxPais.Superficie = (int)reader["SUPERFICIE"];
                    auxPais.Continente = (EContinente)reader["CONTINENTE"];
                    auxPais.Idioma = (EIdioma)reader["IDIOMA"];
                    auxPais.Idh = (EIndiceDesarrolloHumano)reader["IDH"];
                    listaAux.Add(auxPais);
                }
                return listaAux;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Guarda el estado de la lista actual en la base de datos.
        /// </summary>
        /// <param name="listaPaises">Lista actual a guardar.</param>
        public void GuardarListaEnDB(List<Pais> listaPaises)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                int cantPaises = listaPaises.Count;
                for (int i = 0; i < cantPaises; i++)
                {
                    Command.CommandText = "insert into PAISES values  ( @NOMBRE, @POBLACION, @POTENCIA, @SUPERFICIE, @CONTINENTE, @IDIOMA, @IDH)";
                    Command.Parameters.Clear();
                    Command.Parameters.AddWithValue(@"NOMBRE", listaPaises[i].Nombre);
                    Command.Parameters.AddWithValue(@"POBLACION", listaPaises[i].Poblacion);
                    Command.Parameters.AddWithValue(@"POTENCIA", listaPaises[i].Potencia);
                    Command.Parameters.AddWithValue(@"SUPERFICIE", listaPaises[i].Superficie);
                    Command.Parameters.AddWithValue(@"CONTINENTE", listaPaises[i].Continente);
                    Command.Parameters.AddWithValue(@"IDIOMA", listaPaises[i].Idioma);
                    Command.Parameters.AddWithValue(@"IDH", listaPaises[i].Idh);
                    Command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        /// <summary>
        /// Agrega un pais a la Tabla a partir de los valores recibidos como parametro.
        /// </summary>
        /// <param name="poblacion"></param>
        /// <param name="potencia"></param>
        /// <param name="superficie"></param>
        /// <param name="continente"></param>
        /// <param name="idioma"></param>
        /// <param name="idh"></param>
        /// <param name="nombre"></param>
        public void AgregarUnPaisALaDB(int poblacion, bool potencia, double superficie, EContinente continente, EIdioma idioma, EIndiceDesarrolloHumano idh, string nombre)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                Command.CommandText = $"insert into PAISES values  ( @NOMBRE, @POBLACION, @POTENCIA, @SUPERFICIE, @CONTINENTE, @IDIOMA, @IDH)";
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue(@"NOMBRE", nombre);
                Command.Parameters.AddWithValue(@"POBLACION", poblacion);
                Command.Parameters.AddWithValue(@"POTENCIA", potencia);
                Command.Parameters.AddWithValue(@"SUPERFICIE", superficie);
                Command.Parameters.AddWithValue(@"CONTINENTE", continente);
                Command.Parameters.AddWithValue(@"IDIOMA", idioma);
                Command.Parameters.AddWithValue(@"IDH", idh);
                Command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Llama al constructor de esta clase (conexion a la base de datos) utilizando el connectionString hallado en el archivo ConnectionString.xml
        /// </summary>
        /// <returns></returns>
         public static DataBaseControls InicializarBaseDeDatos()
        {
            Serializador<String> lector = new Serializador<String>(IArchivos<String>.ETipoArchivo.XML);
            string connectionString = lector.Leer("ConnectionString.xml");
            return new DataBaseControls(connectionString);
        }
        /// <summary>
        /// Limpia la tabla PAISES de la base de datos completamente.
        /// </summary>
        public void LimpiarBaseDeDatos()
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                    Command.CommandText = "TRUNCATE TABLE PAISES";
                    Command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
