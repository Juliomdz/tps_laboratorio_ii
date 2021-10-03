using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        List<Vehiculo> vehiculos;
        int espacioDisponible;
        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }

        #region "Constructores"
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Taller(int espacioDisponible):this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"Tenemos {taller.vehiculos.Count} lugares ocupados de un total de {taller.espacioDisponible} disponibles");
            sb.AppendLine("");
            foreach (Vehiculo vehiculo in taller.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.SUV:
                        if (typeof(Suv) == vehiculo.GetType())
                        {
                            sb.AppendLine(vehiculo.Mostrar());
                        }
                        break;
                    case ETipo.Ciclomotor:
                        if (typeof(Ciclomotor) == vehiculo.GetType())
                        {
                            sb.AppendLine(vehiculo.Mostrar());
                        }
                        break;
                    case ETipo.Sedan:
                        if (typeof(Sedan) == vehiculo.GetType())
                        {
                            sb.AppendLine(vehiculo.Mostrar());
                        }
                        break;
                    default:
                        sb.AppendLine(vehiculo.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculoASumar">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculoASumar)
        {
            foreach (Vehiculo vehiculo in taller.vehiculos)
            {
                if (vehiculo == vehiculoASumar)
                    return taller;
            }
            if (taller.espacioDisponible - taller.vehiculos.Count > 0)
            {
                taller.vehiculos.Add(vehiculoASumar);
            }
            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculoARestar">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculoARestar)
        {
            foreach (Vehiculo vehiculo in taller.vehiculos)
            {
                if (vehiculo == vehiculoARestar)
                {
                    taller.vehiculos.Remove(vehiculoARestar);
                    break;
                }
            }

            return taller;
        }
        #endregion
    }
}
