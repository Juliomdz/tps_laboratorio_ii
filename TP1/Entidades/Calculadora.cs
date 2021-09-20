using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static class Calculadora
    {
        /// <summary>
        /// Valida recibir un operador matematico valido(default "+").
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>retorna el operador validado</returns>
        private static char ValidarOperador(char operador)
        {
            char operadorValidado = '+';

            switch (operador)
            {

                case '+':
                    {
                        operadorValidado = '+';
                        break;

                    }
                case '-':
                    {
                        operadorValidado = '-';
                        break;
                    }
                case '/':
                    {
                        operadorValidado = '/';
                        break;
                    }
                case '*':
                    {
                        operadorValidado = '*';
                        break;
                    }
                default:
                    {
                        operadorValidado = '+';
                        break;
                    }     
            }

            return operadorValidado;
        }


        /// <summary>
        /// Realiza con los dos operandos la relacion indicada por el Operador
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo Operando</param>
        /// <param name="operador">Define la operacion a realizar</param>
        /// <returns>Devuelve el resultado de la operacion realizada.</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado;

            switch (operador)
            {

                case '+':
                    {
                        resultado = num1 + num2;
                        break;

                    }
                case '-':
                    {
                        resultado = num1 - num2;
                        break;
                    }
                case '/':
                    {
                        resultado = num1 / num2;
                        break;
                    }
                case '*':
                    {
                        resultado = num1 * num2;
                        break;
                    }
                default:
                    {
                        resultado = num1 + num2;
                        break;
                    }
            }

            return resultado;
        }

    }
}
