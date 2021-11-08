using System;
using System.Collections.Generic;
using System.Linq;

namespace Entidades
{
    /// <summary>
    /// Clase Pais que contiene los datos de los paises del G20.
    /// </summary>
    public class Pais
    {
        private int id;
        private string nombre;
        private static int lastId =1;
        private int poblacion;
        private bool potencia;
        private double superficie;
        private EContinente continente;
        private EIdioma idioma;
        private EIndiceDesarrolloHumano idh;


        public Pais()
        {
            id = LastId;
        }

        public Pais(int poblacion, bool potencia, double superficie, EContinente continente, EIdioma idioma, EIndiceDesarrolloHumano idh, string nombre):this()
        {
            Poblacion = poblacion;
            Potencia = potencia;
            Superficie = superficie;
            Continente = continente;
            Idioma = idioma;
            Idh = idh;
            Nombre = nombre;
        }

        private int LastId
        {
            get {
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

        public int Poblacion { 
            get { 
                return poblacion; 
            }
            set {
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
        public int Id { get => id;}
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
        #region hardcodeo manual
        /// <summary>
        /// Metodo que hardcodea la lista original de paises en una instancia de la lista creada y la devuelve por retorno memoria.
        /// </summary>
        /// <returns>retorna la lista con los datos originales hardcodeados</returns>
        public static List<Pais> HardcodeoPaises()
        {
            List<Pais> paises = new List<Pais>();
            lastId = 1;
            paises.Add(new Pais(43600000, false,2780400,EContinente.America, EIdioma.Spanish,EIndiceDesarrolloHumano.Medio, "Argentina"));
            paises.Add(new Pais(24281000, false, 7692024, EContinente.Oceania, EIdioma.English, EIndiceDesarrolloHumano.MuyAlto, "Australia"));
            paises.Add(new Pais(206101000, false, 8515767, EContinente.America, EIdioma.Portuguese, EIndiceDesarrolloHumano.Medio, "Brasil"));
            paises.Add(new Pais(36229000, true, 9984670, EContinente.America, EIdioma.English, EIndiceDesarrolloHumano.MuyAlto, "Canada"));
            paises.Add(new Pais(1382710000, true, 9572900, EContinente.Asia, EIdioma.Chinese, EIndiceDesarrolloHumano.Medio, "China"));
            paises.Add(new Pais(323298000, true, 9526468, EContinente.America, EIdioma.English, EIndiceDesarrolloHumano.MuyAlto, "Estados Unidos"));
            paises.Add(new Pais(64205000, false, 640679, EContinente.Europa, EIdioma.French, EIndiceDesarrolloHumano.Alto, "Francia"));
            paises.Add(new Pais(82732000, true, 357114, EContinente.Europa, EIdioma.German, EIndiceDesarrolloHumano.MuyAlto, "Alemania"));
            paises.Add(new Pais(1309346000, false, 3287263, EContinente.Asia, EIdioma.Hindi, EIndiceDesarrolloHumano.Bajo, "India"));
            paises.Add(new Pais(258705000, false, 1904569, EContinente.Asia, EIdioma.Indonesian, EIndiceDesarrolloHumano.Bajo, "Indonesia"));
            paises.Add(new Pais(60666000, false, 301336, EContinente.Europa, EIdioma.Italian, EIndiceDesarrolloHumano.Alto, "Italia"));
            paises.Add(new Pais(126901000, false, 377930, EContinente.Asia, EIdioma.Japanese, EIndiceDesarrolloHumano.MuyAlto, "Japon"));
            paises.Add(new Pais(122273000, false, 1964375, EContinente.America, EIdioma.Spanish, EIndiceDesarrolloHumano.Medio, "Mexico"));
            paises.Add(new Pais(143440000, true, 17098242, EContinente.Asia, EIdioma.Russian, EIndiceDesarrolloHumano.Alto, "Rusia"));
            paises.Add(new Pais(31743000, false, 2149690, EContinente.Asia, EIdioma.Arabic, EIndiceDesarrolloHumano.Alto, "Arabia Saudita"));
            paises.Add(new Pais(55909000, false, 1221037, EContinente.Africa, EIdioma.English, EIndiceDesarrolloHumano.Bajo, "Sudafrica"));
            paises.Add(new Pais(51246000, false, 100210, EContinente.Asia, EIdioma.Korean, EIndiceDesarrolloHumano.MuyAlto, "Corea Del Sur"));
            paises.Add(new Pais(79815000, false, 783562, EContinente.Europa, EIdioma.Turkish, EIndiceDesarrolloHumano.Medio, "Turquia"));
            paises.Add(new Pais(65572000, true, 242495, EContinente.Europa, EIdioma.English, EIndiceDesarrolloHumano.MuyAlto, "Reino Unido"));

            return paises;
        }
        
        #endregion
    }
}
