using System;
using System.Collections.Generic;
using System.Linq;

namespace Entidades
{
    public delegate void Notificador();
    /// <summary>
    /// Clase Pais que contiene los datos de los paises del G20.
    /// </summary>
    public class Pais
    {
        private static int lastId = 1;
        private int id;
        private string nombre;
        private int poblacion;
        private bool potencia;
        private double superficie;
        private EContinente continente;
        private EIdioma idioma;
        private EIndiceDesarrolloHumano idh;

        # region constructores
        public Pais()
        {
            id = LastId;
        }

        public Pais(int poblacion, bool potencia, double superficie, EContinente continente, EIdioma idioma, EIndiceDesarrolloHumano idh, string nombre) : this()
        {
            Poblacion = poblacion;
            Potencia = potencia;
            Superficie = superficie;
            Continente = continente;
            Idioma = idioma;
            Idh = idh;
            Nombre = nombre;
        }
        #endregion
        #region propiedades
        private int LastId
        {
            get
            {
                return lastId++;
            }

            #region OldCode
            //private set {
            //    lastId++;
            //   this.id = lastId;
            //}
        }

        /*
        private static int LastId {
            get 
            {
                if (lastId <= 0)
                {
                    //TODO:  lastId= Dar la ultima ID usada
                }
                return lastId;
            }


            set {
                lastId = value;
            } 
        }
        */
        #endregion

        public int Poblacion
        {
            get
            {
                return poblacion;
            }
            set
            {
                if (value is > 0)
                {
                    poblacion = value;
                }
            }
        }

        public bool Potencia { get => potencia; set => potencia = value; }
        public double Superficie
        {
            get
            {
                return superficie;
            }
            set
            {
                if (value is > 0)
                {
                    superficie = value;
                }
            }
        }

        public EContinente Continente { get => continente; set => continente = value; }
        public EIdioma Idioma { get => idioma; set => idioma = value; }
        public EIndiceDesarrolloHumano Idh { get => idh; set => idh = value; }
        public int Id { get => id; }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && !value.Any(char.IsDigit))
                {
                    this.nombre = value;
                }
            }
        }
        #endregion
        #region hardcodeo manual
        /// <summary>
        /// Metodo que hardcodea la lista original de paises en una instancia de la lista creada y la devuelve por retorno memoria.
        /// </summary>
        /// <returns>retorna la lista con los datos originales hardcodeados</returns>
        public static List<Pais> HardcodeoPaises()
        {
            List<Pais> paises = new List<Pais>();
            lastId = 1;
            paises.Add(new Pais(43600000, false, 2780400, EContinente.America, EIdioma.Spanish, EIndiceDesarrolloHumano.Medio, "Argentina"));
            paises.Add(new Pais(24281000, false, 7692024, EContinente.Oceania, EIdioma.English, EIndiceDesarrolloHumano.MuyAlto, "Australia"));
            paises.Add(new Pais(206101000, false, 8515767, EContinente.America, EIdioma.Portuguese, EIndiceDesarrolloHumano.Medio, "Brasil"));
            paises.Add(new Pais(36229000, true, 9984670, EContinente.America, EIdioma.English, EIndiceDesarrolloHumano.MuyAlto, "Canada"));
            paises.Add(new Pais(1382710000, true, 9572900, EContinente.Asia, EIdioma.Chinese, EIndiceDesarrolloHumano.Medio, "China"));
            paises.Add(new Pais(323298000, true, 9526468, EContinente.America, EIdioma.English, EIndiceDesarrolloHumano.MuyAlto, "Estados Unidos"));
            paises.Add(new Pais(64205000, true, 640679, EContinente.Europa, EIdioma.French, EIndiceDesarrolloHumano.Alto, "Francia"));
            paises.Add(new Pais(82732000, true, 357114, EContinente.Europa, EIdioma.German, EIndiceDesarrolloHumano.MuyAlto, "Alemania"));
            paises.Add(new Pais(1309346000, false, 3287263, EContinente.Asia, EIdioma.Hindi, EIndiceDesarrolloHumano.Bajo, "India"));
            paises.Add(new Pais(258705000, false, 1904569, EContinente.Asia, EIdioma.Indonesian, EIndiceDesarrolloHumano.Bajo, "Indonesia"));
            paises.Add(new Pais(60666000, false, 301336, EContinente.Europa, EIdioma.Italian, EIndiceDesarrolloHumano.Alto, "Italia"));
            paises.Add(new Pais(126901000, false, 377930, EContinente.Asia, EIdioma.Japanese, EIndiceDesarrolloHumano.MuyAlto, "Japon"));
            paises.Add(new Pais(122273000, false, 1964375, EContinente.America, EIdioma.Spanish, EIndiceDesarrolloHumano.Medio, "Mexico"));
            paises.Add(new Pais(143440000, true, 17098242, EContinente.Europa, EIdioma.Russian, EIndiceDesarrolloHumano.Alto, "Rusia"));
            paises.Add(new Pais(31743000, false, 2149690, EContinente.Asia, EIdioma.Arabic, EIndiceDesarrolloHumano.Alto, "Arabia Saudita"));
            paises.Add(new Pais(55909000, false, 1221037, EContinente.Africa, EIdioma.English, EIndiceDesarrolloHumano.Bajo, "Sudafrica"));
            paises.Add(new Pais(51246000, false, 100210, EContinente.Asia, EIdioma.Korean, EIndiceDesarrolloHumano.MuyAlto, "Corea Del Sur"));
            paises.Add(new Pais(79815000, false, 783562, EContinente.Asia, EIdioma.Turkish, EIndiceDesarrolloHumano.Medio, "Turquia"));
            paises.Add(new Pais(65572000, true, 242495, EContinente.Europa, EIdioma.English, EIndiceDesarrolloHumano.MuyAlto, "Reino Unido"));
            return paises;
        }

        #endregion
        #region metodos

        /// <summary>
        /// Valida que los parametros recibidos para dar de alta un nuevo pais sean validos.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="poblacion"></param>
        /// <param name="superficie"></param>
        /// <param name="mensajeError"></param>
        /// <returns></returns>
        public static bool ValidarPaisNuevo(string nombre, string poblacion, string superficie, out string mensajeError)
        {
            int auxNumeros;
            if (string.IsNullOrWhiteSpace(nombre) || (nombre).Any(char.IsDigit))
            {
                mensajeError = ("Error, el nombre ingesado es invalido.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(poblacion) || !Int32.TryParse(poblacion, out auxNumeros) && auxNumeros <= 0)
            {
                mensajeError = ("Error, el numero de poblacion ingesado es invalido.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(superficie) || !Int32.TryParse(superficie, out auxNumeros) && auxNumeros <= 0)
            {
                mensajeError = ("Error, la superficie ingesada es invalida.");
                return false;
            }
            mensajeError = null;
            return true;
        }
        /// <summary>
        /// Da de alta un nuevo pais con los parametros recibidos a la lista recibida y devuelve la ID del mismo por retorno.
        /// </summary>
        /// <param name="listaPaises"></param>
        /// <param name="nombre"></param>
        /// <param name="poblacion"></param>
        /// <param name="superficie"></param>
        /// <param name="idioma"></param>
        /// <param name="idh"></param>
        /// <param name="continente"></param>
        /// <param name="potencia"></param>
        /// <returns></returns>
        public static int addPaisToList(List<Pais> listaPaises, string nombre, string poblacion, string superficie, EIdioma idioma, EIndiceDesarrolloHumano idh, EContinente continente, bool potencia)
        {
            Pais nuevoPais = new Pais();
            nuevoPais.Nombre = nombre;
            nuevoPais.Poblacion = Int32.Parse(poblacion);
            nuevoPais.Superficie = Int32.Parse(superficie);
            nuevoPais.Idioma = idioma;
            nuevoPais.Idh = idh;
            nuevoPais.Continente = continente;
            nuevoPais.Potencia = potencia;

            listaPaises.Add(nuevoPais);
            return nuevoPais.id;
        }
        /// <summary>
        /// Carga la lista de paises desde un archivo Json y la actualiza en el DataGridView y la devuelve por retorno.
        /// </summary>
        /// <returns></returns>
        public static List<Pais> LoadFromJson(out string mensaje)
        {
            try
            {
                Serializador<List<Pais>> lista = new Serializador<List<Pais>>(IArchivos<List<Pais>>.ETipoArchivo.JSON);
                List<Pais> paisesG20 = lista.Leer("G20.json");
                mensaje = ("Se Cargó la lista de paises del G20 por medio del archivo Json.");
                return paisesG20;
            }
            catch (Exception ex)
            {
                mensaje = (ex.Message);
                return null;
            }
        }
        /// <summary>
        ///  Recibe una lista de paises por parametros y la guarda en un archivo Json. Retorna un mensaje.
        /// </summary>
        /// <param name="listaPaisesRecibida">La lista de paises recibida.</param>
        /// <returns>Mensaje que indica si se pudo o no realizar el guardado.</returns>
        public static string SaveToJson(List<Pais> listaPaisesRecibida)
        {
            string mensaje;
            try
            {
                Serializador<List<Pais>> lista = new Serializador<List<Pais>>(IArchivos<List<Pais>>.ETipoArchivo.JSON);
                lista.Escribir(listaPaisesRecibida, "G20.json");
                mensaje = ("Json creado correctamente.");
                return mensaje;
            }
            catch (Exception ex)
            {
                mensaje = (ex.Message);
                return mensaje;
            }
        }
        /// <summary>
        /// Recibe una lista de paises y un path de una segunda lista, agregando esta ultima a la primera lista con addRange. Devuelve un mensaje.
        /// </summary>
        /// <param name="ListaRecibida">La lista principal a la cual se debe agregar los paises de la lista secundaria.</param>
        /// <param name="pathListaAAgregar">el Path del archivo que contenga la lista secundaria.</param>
        /// <param name="mensaje">Mensaje a mostrar.</param>
        /// <returns>Devuelve un mensaje que indica si se pudo o no realizar la tarea.</returns>
        public static List<Pais> AgregarPaisesALista(List<Pais> ListaRecibida, string pathListaAAgregar, out string mensaje)
        {
            try
            {
                Serializador<List<Pais>> lista = new Serializador<List<Pais>>(IArchivos<List<Pais>>.ETipoArchivo.JSON);
                List<Pais> listaAuxiliar = lista.Leer(pathListaAAgregar);
                ListaRecibida.AddRange(listaAuxiliar);
                mensaje = ("Paises agregados satisfactoriamente a la lista.");
            }
            catch (Exception ex)
            {
                mensaje = (ex.Message);
            }
            return ListaRecibida;
        }
        /// <summary>
        /// Recibe una lista ya filtrada y un string que se utiliza como path y como identificador del filtro para guardar la lista como Json. Devuelve un mensaje.
        /// </summary>
        /// <param name="listaFiltrada">Lista ya filtrada recibida.</param>
        /// <param name="path">String que se utiliza como path y como identificador del filtro.</param>
        /// <returns>Mensaje que indica si se pudo guardar la lista o no.</returns>
        public static string JsonFiltradoGenerator(List<Pais> listaFiltrada, string path)
        {
            try
            {
                Serializador<List<Pais>> lista = new Serializador<List<Pais>>(IArchivos<List<Pais>>.ETipoArchivo.JSON);
                lista.Escribir(listaFiltrada, $"{path}.json");
                return ($"Json del filtro {path} creado correctamente.");
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }
        }
        /// <summary>
        /// Recibe una lista, y la filtra con el criterio recibido por parametro, guardandola en el path recibido.
        /// Devuelve la lista filtrada y un mensaje que indica si se realizo o no el guardado.
        /// </summary>
        /// <param name="listaPaises">La lista de paises original a filtrar</param>
        /// <param name="criteria">El predicate con el criterio para el filtrado</param>
        /// <param name="path">La etiqueta que identifica el filtro y es el nombre que tendrá el Json que se crea</param>
        /// <param name="mensaje">el mensaje que indica si se realizo o el guardado del archivo</param>
        /// <returns></returns>
        public static List<Pais> FiltroPorPredicate(List<Pais> listaPaises, Predicate<Pais> criteria, string path, out string mensaje)
        {
            List<Pais> listaAux = listaPaises.FindAll(criteria);
            mensaje = Pais.JsonFiltradoGenerator(listaAux, path);
            return listaAux;
        }

        #endregion
        #region Informes
        /// <summary>
        /// Guarda el informe recibido como string en un archivo XML.
        /// </summary>
        /// <param name="informe">Informe recibido como string.</param>
        public static void GuardarInformeXML(string informe)
        {
            Serializador<String> archivo = new Serializador<String>((IArchivos<String>.ETipoArchivo.XML));
            string fecha;
            DateTime now = DateTime.Now;
            fecha = now.Millisecond.ToString();
            archivo.Escribir(informe, $"informe - {fecha}" + ".xml");
        }

        /// <summary>
        /// Genera un informe de Desarrollo Humano a partir de la lista de paises recibida y lo retorna como string.
        /// </summary>
        /// <param name="listaPaises">La lista recibida.</param>
        /// <returns>Informe de desarrollo humano como String.</returns>
        public static string InformeDesarrollo(List<Pais> listaPaises)
        {
            string mensaje;
            int idhAlto = 0;
            int idhMuyAlto = 0;
            int idhMedio = 0;
            int idhBajo = 0;
            int totalPaises = listaPaises.Count;
            int maximo = 0;
            string maximoIdh;
            double maximoPorcentaje = 0;
            double diferenciaSocial = 0;
            int desarrolloSuperior = 0;
            int desarrolloInferior = 0;
            double porcentajeBajo = 0;

            foreach (Pais pais in listaPaises)
            {
                switch (pais.Idh)
                {
                    case EIndiceDesarrolloHumano.Alto:
                        idhAlto++;
                        desarrolloSuperior++;
                        break;
                    case EIndiceDesarrolloHumano.Bajo:
                        idhBajo++;
                        desarrolloInferior++;
                        break;
                    case EIndiceDesarrolloHumano.Medio:
                        idhMedio++;
                        desarrolloInferior++;
                        break;
                    case EIndiceDesarrolloHumano.MuyAlto:
                        idhMuyAlto++;
                        desarrolloSuperior++;
                        break;
                    default:
                        break;
                }
            }
            if (idhMuyAlto >= idhAlto && idhMuyAlto > idhMedio && idhMuyAlto > idhBajo)
            {
                maximo = idhMuyAlto;
                maximoIdh = "Muy Alto";
            }
            else
            {
                if (idhAlto >= idhMedio && idhAlto > idhBajo)
                {
                    maximo = idhAlto;
                    maximoIdh = "Alto";
                }
                else
                {
                    if (idhMedio >= idhBajo)
                    {
                        maximo = idhMedio;
                        maximoIdh = "Medio";
                    }
                    else
                    {
                        maximo = idhBajo;
                        maximoIdh = "Bajo";
                    }
                }
            }
            diferenciaSocial = (double)(desarrolloSuperior * 100 / totalPaises);
            maximoPorcentaje = (double)(maximo * 100 / totalPaises);
            porcentajeBajo = (double)(idhBajo * 100 / totalPaises);
            mensaje = $"INFORME:\n La mayoria de los paises del G20 cuentan con un indice de desarrollo {maximoIdh}.({maximoPorcentaje}%)." +
                $" Hay un {diferenciaSocial}% de paises con un desarrollo superior a la media. El {porcentajeBajo}% de paises tiene un IDH bajo.";

            return mensaje;
        }
        /// <summary>
        /// Genera un informe de potencias militares a partir de la lista de paises recibida y lo retorna como string.
        /// </summary>
        /// <param name="listaPaises">La lista recibida.</param>
        /// <returns>Informe de desarrollo humano como String.</returns>
        public static string InformeMilitar(List<Pais> listaPaises)
        {
            string mensaje;
            int contadorPotencias = 0;
            int contadorAfrica = 0;
            int contadorAmerica = 0;
            int contadorEuropa = 0;
            int contadorAsia = 0;
            int contadorOceania = 0;
            int totalPaises = listaPaises.Count;
            int maximo = 0;
            double maximoPorcentaje = 0;
            string maximoContinente = "";
            double porcentajeDeLosTotales = 0;
            int flagNotEqual = 0;

            foreach (Pais pais in listaPaises)
            {
                if (pais.Potencia == true)
                {
                    contadorPotencias++;
                    switch (pais.Continente)
                    {
                        case EContinente.Africa:
                            contadorAfrica++;
                            break;
                        case EContinente.America:
                            contadorAmerica++;
                            break;
                        case EContinente.Asia:
                            contadorAsia++;
                            break;
                        case EContinente.Europa:
                            contadorEuropa++;
                            break;
                        case EContinente.Oceania:
                            contadorOceania++;
                            break;
                        default:
                            break;
                    }
                }
            }
            if (contadorAfrica > contadorAmerica && contadorAfrica > contadorAsia && contadorAfrica > contadorEuropa && contadorAfrica > contadorOceania)
            {
                maximo = contadorAfrica;
                maximoContinente = "Africa";
                flagNotEqual = 1;
            }
            else
            {
                if (contadorAmerica > contadorAsia && contadorAmerica > contadorEuropa && contadorAmerica > contadorOceania && contadorAmerica > contadorAfrica)
                {
                    maximo = contadorAmerica;
                    maximoContinente = "America";
                    flagNotEqual = 1;
                }
                else
                {
                    if (contadorAsia > contadorEuropa && contadorAsia > contadorOceania && contadorAsia > contadorAmerica)
                    {
                        maximo = contadorAsia;
                        maximoContinente = "Asia";
                        flagNotEqual = 1;
                    }
                    else if (contadorEuropa > contadorOceania && contadorEuropa > contadorAsia)
                    {
                        maximo = contadorEuropa;
                        maximoContinente = "Europa";
                        flagNotEqual = 1;
                    }
                    else
                    {
                        if (contadorOceania > contadorEuropa)
                        {
                            maximo = contadorOceania;
                            maximoContinente = "Oceania";
                            flagNotEqual = 1;
                        }
                    }
                }
            }
            porcentajeDeLosTotales = (double)(contadorPotencias * 100 / totalPaises);
            mensaje = $"INFORME:\nEn el G20 hay actualmente {contadorPotencias} paises considerados potencias militares," +
                $" estos representan el {porcentajeDeLosTotales}% de los totales.";
            if (flagNotEqual == 1)
            {
                maximoPorcentaje = (double)(maximo * 100 / contadorPotencias);
                mensaje = mensaje + $" El continente con mas potencias militares es {maximoContinente} con {maximo} paises considerados potencia," +
                    $" concentrando así el {maximoPorcentaje}% del poderío militar.";
            }
            return mensaje;
        }
        /// <summary>
        /// Genera un informe de densidad de poblacion a partir de la lista de paises recibida y lo retorna como string.
        /// </summary>
        /// <param name="listaPaises">La lista recibida.</param>
        /// <returns>Informe de densidad poblacional como String.</returns>
        public static string InformeDensidad(List<Pais> listaPaises)
        {
            int contadorDensidadAlta = 0;
            int contadorDensidadBaja = 0;
            int densidadMaxima = 0;
            int densidadMinima = 0;
            double porcentajeAltaDensidad;
            string paisDensidadMaxima = "";
            string mensaje;
            string paisDensidadMinima = "";
            string continenteMasDenso = "";
            int totalPaises = listaPaises.Count;
            int contadorAfrica = 0;
            int contadorAmerica = 0;
            int contadorEuropa = 0;
            int contadorAsia = 0;
            int contadorOceania = 0;
            int flagNotEqual = 0;
            foreach (Pais pais in listaPaises)
            {
                if (pais.Poblacion / pais.Superficie > 100)
                {
                    contadorDensidadAlta++;
                    switch (pais.Continente)
                    {
                        case EContinente.Africa:
                            contadorAfrica++;
                            break;
                        case EContinente.America:
                            contadorAmerica++;
                            break;
                        case EContinente.Asia:
                            contadorAsia++;
                            break;
                        case EContinente.Europa:
                            contadorEuropa++;
                            break;
                        case EContinente.Oceania:
                            contadorOceania++;
                            break;
                        default:
                            break;
                    }
                }
                else if (pais.Poblacion / pais.Superficie < 20)
                {
                    contadorDensidadBaja++;
                }
                if (densidadMaxima == 0 || pais.Poblacion / pais.Superficie > densidadMaxima)
                {
                    densidadMaxima = (int)(pais.Poblacion / pais.Superficie);
                    paisDensidadMaxima = pais.Nombre;
                }
                if (densidadMinima == 0 || pais.Poblacion / pais.Superficie < densidadMinima)
                {
                    densidadMinima = (int)(pais.Poblacion / pais.Superficie);
                    paisDensidadMinima = pais.Nombre;
                }
            }
            if (contadorAfrica > contadorAmerica && contadorAfrica > contadorAsia && contadorAfrica > contadorEuropa && contadorAfrica > contadorOceania)
            {
                continenteMasDenso = "Africa";
                flagNotEqual = 1;
            }
            else
            {
                if (contadorAmerica > contadorAsia && contadorAmerica > contadorEuropa && contadorAmerica > contadorOceania && contadorAmerica > contadorAfrica)
                {
                    continenteMasDenso = "America";
                    flagNotEqual = 1;
                }
                else
                {
                    if (contadorAsia > contadorEuropa && contadorAsia > contadorOceania && contadorAsia > contadorAmerica)
                    {
                        continenteMasDenso = "Asia";
                        flagNotEqual = 1;
                    }
                    else if (contadorEuropa > contadorOceania && contadorEuropa > contadorAsia)
                    {
                        continenteMasDenso = "Europa";
                        flagNotEqual = 1;
                    }
                    else
                    {
                        if (contadorOceania > contadorEuropa)
                        {
                            continenteMasDenso = "Oceania";
                            flagNotEqual = 1;
                        }
                    }
                }
            }
            porcentajeAltaDensidad = (double)(contadorDensidadAlta * 100 / totalPaises);

            mensaje = $"INFORME:\n En el G20 hay un {porcentajeAltaDensidad}% de paises con alta densidad de poblacion, es decir que superan los 100 habitantes por kilometro cuadrado." +
                $" El país mas densamente poblado es {paisDensidadMaxima} con {densidadMaxima} hab/km^2 y el menos densamente poblado es {paisDensidadMinima} con {densidadMinima} hab/km^2. ";
            if (flagNotEqual == 1)
            {
                mensaje = mensaje + $" El continente con mayor concentracion de paises altamente poblados es {continenteMasDenso}.";
            }
            return mensaje;
        }
        /// <summary>
        /// Genera un informe de continentes participantes del G20 a partir de la lista de paises recibida y lo retorna como string.
        /// </summary>
        /// <param name="listaPaises">La lista recibida.</param>
        /// <returns>Informe de participacion continental como String.</returns>
        public static string InformeContinentes(List<Pais> listaPaises)
        {
            string mensaje;
            string continenteConMasRepresentantes = "";
            string continenteMenosRepresentado = "";
            double porcentajeDelTotal;
            int contadorAfrica = 0;
            int contadorAmerica = 0;
            int contadorEuropa = 0;
            int contadorAsia = 0;
            int contadorOceania = 0;
            int maximo = 0;
            int minimo = 0;
            int totalPaises = listaPaises.Count;
            foreach (Pais pais in listaPaises)
            {
                switch (pais.Continente)
                {
                    case EContinente.Africa:
                        contadorAfrica++;
                        break;
                    case EContinente.America:
                        contadorAmerica++;
                        break;
                    case EContinente.Asia:
                        contadorAsia++;
                        break;
                    case EContinente.Europa:
                        contadorEuropa++;
                        break;
                    case EContinente.Oceania:
                        contadorOceania++;
                        break;
                    default:
                        break;
                }

            }
            if (contadorAfrica > contadorAmerica && contadorAfrica > contadorAsia && contadorAfrica > contadorEuropa && contadorAfrica > contadorOceania)
            {
                maximo = contadorAfrica;
                continenteConMasRepresentantes = "Africa";
            }
            else
            {
                if (contadorAmerica > contadorAsia && contadorAmerica > contadorEuropa && contadorAmerica > contadorOceania && contadorAmerica > contadorAfrica)
                {
                    maximo = contadorAmerica;
                    continenteConMasRepresentantes = "America";
                }
                else
                {
                    if (contadorAsia > contadorEuropa && contadorAsia > contadorOceania && contadorAsia > contadorAmerica)
                    {
                        maximo = contadorAsia;
                        continenteConMasRepresentantes = "Asia";
                    }
                    else if (contadorEuropa > contadorOceania && contadorEuropa > contadorAsia)
                    {
                        maximo = contadorEuropa;
                        continenteConMasRepresentantes = "Europa";
                    }
                    else
                    {
                        if (contadorOceania > contadorEuropa)
                        {
                            maximo = contadorOceania;
                            continenteConMasRepresentantes = "Oceania";
                        }
                    }
                }
            }
            if (contadorAfrica < contadorAmerica && contadorAfrica < contadorAsia && contadorAfrica < contadorEuropa && contadorAfrica < contadorOceania)
            {
                minimo = contadorAfrica;
                continenteMenosRepresentado = "Africa";
            }
            else
            {
                if (contadorAmerica < contadorAsia && contadorAmerica < contadorEuropa && contadorAmerica < contadorOceania && contadorAmerica < contadorAfrica)
                {
                    minimo = contadorAmerica;
                    continenteMenosRepresentado = "America";
                }
                else
                {
                    if (contadorAsia < contadorEuropa && contadorAsia < contadorOceania && contadorAsia < contadorAmerica)
                    {
                        minimo = contadorAsia;
                        continenteMenosRepresentado = "Asia";
                    }
                    else if (contadorEuropa < contadorOceania && contadorEuropa < contadorAsia)
                    {
                        minimo = contadorEuropa;
                        continenteMenosRepresentado = "Europa";
                    }
                    else
                    {
                        if (contadorOceania < contadorEuropa)
                        {
                            minimo = contadorOceania;
                            continenteMenosRepresentado = "Oceania";
                        }
                    }
                }
            }
            porcentajeDelTotal = (double)((maximo * 100) / totalPaises);
            mensaje = $"INFORME:\n El continente con mas representantes en el G20 es {continenteConMasRepresentantes}, con un {porcentajeDelTotal}% de las bancas totales." +
                $" El continente menos representado es {continenteMenosRepresentado} con {minimo} bancas.";
            return mensaje;
        }

        #endregion
        #region Eventos
        public event Notificador Notificacion;
        #endregion
    }
}
