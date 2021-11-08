
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Excepcion a utilizar cuando es incompatible la extension del archivo con el tipo que se quiere guardar.
    /// </summary>
    public class InvalidExtensionException : Exception
    {
        public InvalidExtensionException(string message) : base(message)
        {
        }

        public InvalidExtensionException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}