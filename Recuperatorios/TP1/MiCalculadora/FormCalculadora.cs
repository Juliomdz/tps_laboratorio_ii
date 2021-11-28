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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
            lblResultado.Text = "Bienvenido a la calculadora!";
        }
        /// <summary>
        /// Valida que todos los campos sean correctos y se ser así inicia una operación, mostrando el resultado en el formulario.
        /// </summary>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            {
                if (!double.TryParse(txtNumero1.Text, out double num1) | !double.TryParse(txtNumero2.Text, out double num2))
                {
                    MessageBox.Show("Operando incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double auxOperar = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);

                    if (auxOperar == double.MinValue)
                    {
                        MessageBox.Show("Operación invalida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (cmbOperador.Text == " ")
                    {
                        MessageBox.Show("Por falta de operador, se ejecutara una suma ", "Advertencia", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        cmbOperador.SelectedIndex = 1;
                    }
                    this.lblResultado.Text = auxOperar.ToString();
                    this.lstOperaciones.Items.Add($"{num1} {cmbOperador.Text} {num2} = {auxOperar}");
                }
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Convierte el ultimo resultado a binario en caso de ser posible.
        /// </summary>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            {
                Operando decABin = new Operando();
                string auxDecABin = decABin.DecimalBinario(lblResultado.Text);
                if (auxDecABin == "Valor inválido")
                    Limpiar();
                else
                    lstOperaciones.Items.Add(auxDecABin);
                this.lblResultado.Text = auxDecABin;
            }
        }
        /// <summary>
        /// Convierte el ultimo resultado binario a decimal en caso de ser posible.
        /// </summary>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando binADec = new Operando();
            string auxBinADec = binADec.BinarioDecimal(lblResultado.Text);
            if (auxBinADec == "Valor inválido")
                Limpiar();
            else
                lstOperaciones.Items.Add(auxBinADec);
            lblResultado.Text = auxBinADec;
        }
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// realiza una operacion entre ambos operandos recibidos en funcion del operador recibido y devuelve el resultado como double.
        /// </summary>
        /// <param name="numero1">Primer operando</param>
        /// <param name="numero2">Segundo operando</param>
        /// <param name="operadorString">el tipo de operacion a realizar</param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            return Calculadora.Operar(new Operando(numero1),new Operando(numero2), Convert.ToChar(operador));
        }
        /// <summary>
        /// Borra ambos operandos, el resultado y setea la operacion sin opcion. 
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = "0";
            cmbOperador.SelectedIndex = 0;
        }
    }
}
