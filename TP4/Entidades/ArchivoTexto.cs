using System;
using System.IO;

namespace Entidades
{
    /// <summary>
    /// Clase que maneja archivos de texto plano.
    /// </summary>
    public class ArchivoTexto : IArchivos<string>
    {
        /// <summary>
        /// metodo que escribe el dato recibido como string en el path recibido como parametro.
        /// </summary>
        /// <param name="dato">Dato a escribir</param>
        /// <param name="path">Nombre del archivo de texto</param>
        public void Escribir(string dato, string path)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    streamWriter.WriteLine(dato);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// recibe la direccion de un archivo, lo lee y retorna el string leido.
        /// </summary>
        /// <param name="path">el nombre del archivo a leer.</param>
        /// <returns></returns>
        public string Leer(string path)
        {
            string returnAux = string.Empty;
            try
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    while (!streamReader.EndOfStream)
                    {
                        returnAux += $"{streamReader.ReadLine()}\n";
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return returnAux;
        }
    }
}