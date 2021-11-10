using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Interfaz que recibe un parametro generico y tiene como atributo un enumerado para el tipo de archivo. 
    /// Debe tener los metodos Leer y Escribir.
    /// </summary>
    /// <typeparam name="T">tipo de arcivo recibido</typeparam>
    public interface IArchivos<T> where T : class
    {
        public enum ETipoArchivo { JSON, XML};
        T Leer(string path);
        void Escribir(T dato, string path);
    }
}