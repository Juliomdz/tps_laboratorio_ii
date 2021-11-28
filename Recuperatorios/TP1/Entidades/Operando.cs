using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        public Operando()
        {
            numero = 0;
        }

        public Operando(string strNumero) : this()
        {
            Numero = strNumero;
        }

        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        /// Recibe un string, si es un numero binario valido lo convierte en decimal y lo devuelve como string.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Un string con el numero decimal obtenido o "Valor invalido" en el caso contrario.</returns>
        public string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
            {
                int num = Convert.ToInt32(binario, 2);
                if (num > 0)
                {
                    return num.ToString();
                }
            }
                return "Valor inválido";
        }
        /// <summary>
        /// Recibe un string, si es un numero decimal valido lo convierte en binario y lo devuelve como string.
        /// </summary>
        /// <param name="numero">El numero decimal recibido como string</param> string
        /// <returns>Un string con el numero binario obtenido o "Valor invalido" en el caso contrario.</returns> 
        public string DecimalBinario(string numero)
        {
            int num;
            if (int.TryParse(numero, out num))
            {
                if (num > 0)
                {
                    return Convert.ToString(num, 2);
                }
            }
            return "Valor inválido";
        }
        /// <summary>
        /// Sobrecarga del metodo DecimalBinario que recibe un double, lo convierte a string y lo pasa por parametro al metodo DecimalBinario.
        /// </summary>
        /// <param name="numero">Numero recibido como double</param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }

        /// <summary>
        /// Verifica que el string solo este compuesto por ceros y unos.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>True en caso de comprobar, False en caso contrario.</returns>
        private bool EsBinario(string binario)
        {
            if (binario != null)
            {
                foreach (char digito in binario)
                {
                    if (digito != '0' && digito != '1')
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Ejecuta una resta entre 2 objetos del tipo Operando.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>El resultado de la operación</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Ejecuta una multiplicación entre 2 objetos del tipo Operando.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>El resultado de la operación</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Ejecuta una division entre 2 objetos del tipo Operando.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>El resultado de la operación ó el valor mínimo posible si el segundo parámetro el cero</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }

        /// <summary>
        /// Ejecuta una suma entre 2 objetos del tipo Operando.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>El resultado de la operación</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Verifica que el string pasado por parámetro sea un numero valido.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>El numero verificado o cero en su defecto</returns>
        private double ValidarOperando(string strNumero)
        {
            double.TryParse(strNumero, out double auxNum);
            return auxNum;
        }
    }
}
