using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida que el caracter pasado por parámetro sea uno de los 4 operandos aritmeticos.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>El operador validado o en su defecto '+' por default</returns>
        private static char ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return operador;
            }
            else
            {
                return '+';
            }
        }
        /// <summary>
        /// Realiza la operación de ambos operandos en funcion del operando recibido como tercer parametro.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>El resultado de la operación</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            switch (ValidarOperador(operador))
            {
                case '*':
                    return num1 * num2;
                case '-':
                    return num1 - num2;
                case '/':
                    return num1 / num2;
                default:
                    return num1 + num2;
            }
        }
    }
}
