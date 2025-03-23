using LinqToDB.Data;

namespace Datos
{
    public class Conexion: DataConnection
    {
        public Conexion() : base("miConexionSQL") { 
        }

    }
}
