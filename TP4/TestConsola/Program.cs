using System;
using System.Collections.Generic;
using Entidades;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje;
            string informe;
            DataBaseControls.InicializarBaseDeDatos();
            Console.WriteLine(" Se inicializa la base de datos. ");
            DataBaseControls db = new DataBaseControls();
            Console.WriteLine(" se instancia la clase que da acceso a los controles de la base de datos. ");
            List<Pais> ListaPaises = db.LeerListaDeDB();
            Console.WriteLine("Se lee la lista de paises de la DB.  ");
            db.AgregarUnPaisALaDB(43600000, false, 2780400, EContinente.Africa, EIdioma.Spanish, EIndiceDesarrolloHumano.Medio, "Angola");
            Console.WriteLine(" Se agrega un país hardcodeado. ");
            db.LimpiarBaseDeDatos();
            Console.WriteLine("Se trunca la DB.  ");
            ListaPaises =Pais.HardcodeoPaises();
            Console.WriteLine(" Se vuelve a cargar la lista en memoria por la funcion de harcodeo. ");
            db.GuardarListaEnDB(ListaPaises);
            Console.WriteLine("Se guarda la lista nueva en la DB");
            Pais.AgregarPaisesALista(ListaPaises, "G20Invitados.json", out mensaje);
            Console.WriteLine(mensaje);
            Pais.SaveToJson(ListaPaises);
            Console.WriteLine("Se guarda como Json la lista de paises.");
            informe =Pais.InformeDesarrollo(ListaPaises);
            Console.WriteLine("Se genera un informe de Indice de Desarrollo en los paises del G20.");
            Pais.GuardarInformeXML(informe);
            Console.WriteLine("Se guarda en informe com XML.");
            Console.WriteLine("TEST FINALIZADO.");


            Console.ReadLine();
        }
    }
}
