using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MiMetodoDeExtension
    {
        /// <summary>
        /// Transforma el numero Int en un numero interpretado agregandole un sufijo en base a su cantidad.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string CambiarFormato(this int num)
        {
            if (num > 1999999999)
            {
                return (num / 1000000000).ToString("0.#Billon");
            }
            if (num >= 1000000000)
            {
                return (num / 1000000000).ToString("0.##Billon");
            }
            if (num >= 100000000)
            {
                return (num / 1000000).ToString("0.#Millon");
            }
            if (num >= 1000000)
            {
                return (num / 1000000).ToString("0.##Millon");
            }
            if (num >= 100000)
            {
                return (num / 1000).ToString("0.#mil");
            }
            if (num >= 10000)
            {
                return (num / 1000).ToString("0.##mil");
            }
            if (num >= 1000)
            {
                return (num / 1000).ToString("0.#mil");
            }

            return num.ToString("#,0");
        }
    }
}
