using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    /// <summary>
    /// Clase que utiliza tipos genericos y la interfaz IArchivos y nos permite escribir y leer en Json y XML.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Serializador<T> : IArchivos<T> where T : class
    {

        private IArchivos<T>.ETipoArchivo tipo;

        public Serializador(IArchivos<T>.ETipoArchivo tipo)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Recibe un dato de tipo generico y lo serializa para escribirlo en el tipo de archivo recibido en el path.
        /// </summary>
        /// <param name="dato">dato generico recibido</param>
        /// <param name="path">nombre del archivo a escribir y su extension</param>
        public void Escribir(T dato, string path)
        {
            try
            {
                if (this.tipo == IArchivos<T>.ETipoArchivo.XML)
                {
                    if (Path.GetExtension(path) == ".xml")
                    {
                        using (XmlTextWriter xmlTextWriter = new XmlTextWriter(path, Encoding.UTF8))
                        {
                            xmlTextWriter.Formatting = Formatting.Indented;
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            xmlSerializer.Serialize(xmlTextWriter, dato);
                        }
                    }
                    else
                    {
                        throw new InvalidExtensionException("La extension ingresada no es compatible con XML");
                    }
                }
                else
                {
                    if (Path.GetExtension(path) == ".json")
                    {
                        ArchivoTexto archivoTexto = new ArchivoTexto();
                        archivoTexto.Escribir(JsonSerializer.Serialize(dato, typeof(T)), path);
                    }
                    else
                    {
                        throw new InvalidExtensionException("La extension ingresada no es compatible con JSON");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Lee de un archivo recibido como parametro y devuelve el objeto generico como retorno.
        /// </summary>
        /// <param name="path">nombre del archivo y su extension</param>
        /// <returns></returns>
        public T Leer(string path)
        {

            try
            {
                if (this.tipo == IArchivos<T>.ETipoArchivo.XML)
                {
                    if (Path.GetExtension(path) == ".xml")
                    {
                        using (XmlTextReader xmlTextReader = new XmlTextReader(path))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            return (T)xmlSerializer.Deserialize(xmlTextReader);
                        }
                    }
                    else
                    {
                        throw new InvalidExtensionException("La extension ingresada no es compatible con XML");
                    }
                }
                else
                {
                    if (Path.GetExtension(path) == ".json")
                    {
                        ArchivoTexto archivoTexto = new ArchivoTexto();
                        string texto = archivoTexto.Leer(path);
                        return JsonSerializer.Deserialize<T>(texto);
                    }
                    else
                    {
                        throw new InvalidExtensionException("La extension ingresada no es compatible con JSON");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}