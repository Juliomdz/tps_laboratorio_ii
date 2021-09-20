using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace TP_1
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Inicializa la calculadora y sus componentes
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Limpia los valores en los operandos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        /// <summary>
        /// Cierra la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Carga el programa al inicio con los valores por defecto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            lstOperaciones.Text = string.Empty;
            lblResultado.Text = "0";
            cmbOperador.SelectedIndex = 0;
        }


        /// <summary>
        /// Pide confirmacion de cierre al usuario antes de cerrar el programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirmacion;
            confirmacion = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {

            }
            else if (confirmacion == DialogResult.No)
            {
                //Cancela el evento de "CLOSING". (EVENT CANCEL).
                e.Cancel = true;
            }
        }


        /// <summary>
        /// Realiza la operacion entre los operandos ingresados en funcion de la operacion elegida.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string numero1String;
            string numero2String;
            string operadorString;
            char operadorChar;
            double resultado;
            bool validacionChar;


            numero1String = txtNumero1.Text;
            numero2String = txtNumero2.Text;
            operadorString = cmbOperador.Text;

  
            Operando num1 = new Operando();
            Operando num2 = new Operando();

            validacionChar = char.TryParse(operadorString, out operadorChar);
            num1.Numero = numero1String;
            num2.Numero = numero2String;

            if (cmbOperador.SelectedIndex == 0 || cmbOperador.Text == " ")
            {
                operadorChar = '+';
                cmbOperador.SelectedIndex = 1;
            }


            int contadorSignoNegativo = 0;
            int contadorSignoComa = 0;
            bool validacion1 = true;

            for (int i = 0; i < numero1String.Length; i++)
            {
                if (numero1String[i] < '0' || numero1String[i] > '9')
                {
                    if (numero1String[i] != ',' && numero1String[i] != '-')
                    {

                        validacion1 = false;
                        break;
                    }
                    else if (numero1String[i] == '-')
                    {
                        contadorSignoNegativo++;
                    }
                    else if (numero1String[i] == ',')
                    {
                        contadorSignoComa++;
                    }
                }
            }


            int contadorSignoNegativo2 = 0;
            int contadorSignoComa2 = 0;
            bool validacion2 = true;

            for (int j = 0; j < numero2String.Length; j++)
            {
                if (numero2String[j] < '0' || numero2String[j] > '9')
                {
                    if (numero2String[j] != ',' && numero2String[j] != '-')
                    {
                        validacion2 = false;
                        break;
                    }
                    else if (numero2String[j] == '-')
                    {
                        contadorSignoNegativo2++;
                    }
                    else if (numero2String[j] == ',')
                    {
                        contadorSignoComa2++;
                    }
                }
            }

            if (contadorSignoComa > 1 || contadorSignoNegativo > 1 )
            {
                validacion1 = false;
            }

            if (contadorSignoNegativo2 > 1 || contadorSignoComa2 > 1)
            {
                validacion2 = false;
            }

                if (string.IsNullOrWhiteSpace(numero1String) == true || validacion1 == false)
            {
                numero1String = "0";
            }

            if (string.IsNullOrWhiteSpace(numero2String) == true || validacion2 == false)
            {
                numero2String = "0";
            }

            if (validacionChar == true && validacion1 == true && validacion2 == true)
            {
                if (numero2String == "0" && operadorChar == '/')
                {
                    resultado = 0;
                    lblResultado.Text = "Error. No se puede dividir por 0.";
                    lstOperaciones.Items.Add("Hubo error en el calculo.");
                }
                else
                {
                    resultado = Operar(numero1String, numero2String, operadorChar.ToString());
                    lblResultado.Text = resultado.ToString();
                    lstOperaciones.Items.Add($"{numero1String} {operadorChar} {numero2String} = {resultado}");

                }

                
                  
            }
            else
            {

                if (validacion1 == false)
                {
                    numero1String = "0";
                }

                if (validacion2 == false)
                {
                    numero2String = "0";
                }

                resultado = Operar(numero1String, numero2String, operadorChar.ToString());

                if (numero2String == "0" && operadorChar == '/')
                {
                    resultado = 0;
                    lblResultado.Text = "Error. No se puede dividir por 0.";
                    lstOperaciones.Items.Add("Hubo error en el calculo.");
                }
                else
                {
                    lstOperaciones.Items.Add($"{numero1String} {operadorChar} {numero2String} = {resultado}");
                }
                   
            }

        }


        /// <summary>
        /// Convierte el resultado a binario en caso de ser posible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string numero1String;
            string numero2String;

            string operadorString;
            char operadorChar;

            double resultado;
            string resultadoString;
            bool validacionChar;
            string validacionNum2;

            numero1String = txtNumero1.Text;
            numero2String = txtNumero2.Text;
            operadorString = cmbOperador.Text;

            if (cmbOperador.SelectedIndex == 0 || cmbOperador.Text == " ")
            {
                cmbOperador.SelectedIndex = 1;
            }

            Operando resultadoConversion = new Operando();

            validacionChar = char.TryParse(operadorString, out operadorChar);

            validacionNum2 = resultadoConversion.BinarioDecimal(numero2String);
            validacionNum2 = resultadoConversion.DecimalBinario(numero2String);

            if (validacionChar == true)
            {
                if (operadorString == "/" && (numero2String == "0" || validacionNum2 == "Valor inválido") == true)
                {
                    lblResultado.Text = "Error. No se puede dividir por 0.";
                    lstOperaciones.Items.Add("Hubo error en el calculo.");
                }
                else
                {
                    resultado = Operar(numero1String, numero2String, operadorString);
                    resultadoString = resultadoConversion.DecimalBinario(resultado);
                    lblResultado.Text = resultadoString;


                    if (resultado == 0)
                    {
                        resultadoString = "0";
                        lstOperaciones.Items.Add($"Decimal: {resultado} = Binario: {resultadoString}");
                        lblResultado.Text = resultadoString;
                    }
                    else
                    {
                        lstOperaciones.Items.Add($"Decimal: {resultado} = Binario: {resultadoString}");
                    }
                }

            }

        }


        /// <summary>
        /// Convierte el resultado binario a decimal en caso de ser posible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string numero1BinString;
            string numero1DecString;
            string numero2BinString;
            string numero2DecString;

            string operadorString;
            char operadorChar;
            bool validacionChar;

            double resultado;
            string resultadoBinario;

            numero1BinString = txtNumero1.Text;
            numero2BinString = txtNumero2.Text;
            operadorString = cmbOperador.Text;

            validacionChar = char.TryParse(operadorString, out operadorChar);

            if (cmbOperador.SelectedIndex == 0 || cmbOperador.Text == " ")
            {
                cmbOperador.SelectedIndex = 1;
                operadorChar = '+';
            }

            if (validacionChar == true)
            {
                Operando resultadoConversion = new Operando();

                numero1DecString = resultadoConversion.BinarioDecimal(numero1BinString);
                numero2DecString = resultadoConversion.BinarioDecimal(numero2BinString);


                    if (numero1DecString == "Valor inválido")
                    {
                        numero1DecString = "0";                    
                    }

                    if (numero2DecString == "Valor inválido")
                    {
                        numero2DecString = "0";
                    }

                    if (numero2DecString == "0" && operadorString == "/")
                    {
                        lblResultado.Text = "Error. No se puede dividir por 0.";
                        lstOperaciones.Items.Add("Hubo error en el calculo.");
                    }
                    else
                    {
                        resultado = Operar(numero1DecString, numero2DecString, operadorString);
                        resultadoBinario = resultadoConversion.DecimalBinario(resultado);

                        lblResultado.Text = resultado.ToString();

                        if (resultado == 0)
                        {
                            lstOperaciones.Items.Add($"Binario: {0} = Decimal: {0}");
                        }
                        else
                        {
                            lstOperaciones.Items.Add($"Binario: {resultadoBinario} = Decimal: {resultado}");
                        }

                    
                }


            }

        }


        /// <summary>
        /// realiza una operacion entre ambos operandos recibidos en funcion del operador recibido
        /// </summary>
        /// <param name="numero1">Primer operando</param>
        /// <param name="numero2">Segundo operando</param>
        /// <param name="operadorString">el tipo de operacion a realizar</param>
        /// <returns></returns>
        private double Operar(string numero1, string numero2, string operadorString)
        {
            char operadorChar;
            char.TryParse(operadorString, out operadorChar);

            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);

            double resultado;

            switch (operadorChar)
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


        /// <summary>
        /// Borra ambos operandos y el resultado. 
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            lblResultado.Text = "0";
            cmbOperador.SelectedIndex = 0;
        }
    }
}
