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

namespace PaisesG20
{
    public partial class FrmAltaPais : Form
    {
        public FrmAltaPais()
        {
            InitializeComponent();
        }
        //public FrmAltaPais(List<Pais> listaRecibida):this()
        //{

        //}
        

        private void btnAddPais_Click(object sender, EventArgs e)
        {
            AltaPais();
        }

        private void FrmAltaPais_Load(object sender, EventArgs e)
        {
            this.cboxContinente.DataSource = Enum.GetValues(typeof(EContinente));
            this.cboxIdioma.DataSource = Enum.GetValues(typeof(EIdioma));
            this.cboxIdh.DataSource = Enum.GetValues(typeof(EIndiceDesarrolloHumano));
        }
        /// <summary>
        /// Da de alta un nuevo pais y lo agrega a la lista del formulario principal.
        /// </summary>
        private void AltaPais()
        {
            if (ValidarPaisNuevo() is true)
            {
                Pais nuevoPais = new Pais();
                nuevoPais.Nombre = txtNombre.Text;
                nuevoPais.Poblacion = Int32.Parse(txtPoblacion.Text);
                nuevoPais.Superficie = Int32.Parse(txtSuperficie.Text);
                nuevoPais.Idioma = (EIdioma)cboxIdioma.SelectedItem;
                nuevoPais.Idh = (EIndiceDesarrolloHumano)cboxIdh.SelectedItem;
                nuevoPais.Continente = (EContinente)cboxContinente.SelectedItem;
                nuevoPais.Potencia = chbPotencia.Checked;

                FrmMainMenu.ListaPaises.Add(nuevoPais);
                MessageBox.Show($"Se agregó el país {nuevoPais.Nombre} a la lista del G20. ID:{nuevoPais.Id} ");
            }
            //else 
            //{
            //    MessageBox.Show($"La lista no se modificó.");
            //}
        }
        /// <summary>
        /// Valida que todos los imputs ingresados por el usuario sean datos validos para cada uno de los atributos de un Pais.
        /// </summary>
        /// <returns></returns>
        private bool ValidarPaisNuevo()
        {
            int auxNumeros;
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || (txtNombre.Text).Any(char.IsDigit))
            {
                MessageBox.Show($"Error, el nombre ingesado es invalido.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPoblacion.Text) || !Int32.TryParse(txtPoblacion.Text, out auxNumeros) && auxNumeros <= 0)
            {
                MessageBox.Show($"Error, el numero de poblacion ingesado es invalido.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSuperficie.Text) || !Int32.TryParse(txtSuperficie.Text, out auxNumeros) && auxNumeros <= 0)
            {
                MessageBox.Show($"Error, la superficie ingesada es invalida.");
                return false;
            }
            return true;
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            FrmMainMenu.SaveToJson();
        }
    }
}
