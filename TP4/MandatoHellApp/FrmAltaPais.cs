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

        private void FrmAltaPais_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void btnAddPais_Click(object sender, EventArgs e)
        {
            AltaPais();
        }
        private void btnJson_Click(object sender, EventArgs e)
        {
            SaveToJson();
        }

        /// <summary>
        /// Da de alta un nuevo pais y lo agrega a la lista del formulario principal.
        /// </summary>
        private void AltaPais()
        {
            if (Pais.ValidarPaisNuevo(txtNombre.Text, txtPoblacion.Text, txtSuperficie.Text, out string mensajeError) is true)
            {
                int idNuevoPais;
                idNuevoPais= Pais.addPaisToList(FrmMainMenu.ListaPaises, txtNombre.Text, txtPoblacion.Text,txtSuperficie.Text,
                                                (EIdioma)cboxIdioma.SelectedItem, (EIndiceDesarrolloHumano)cboxIdh.SelectedItem,
                                                (EContinente)cboxContinente.SelectedItem, chbPotencia.Checked);
                MessageBox.Show($"Se agregó el país {txtNombre.Text} a la lista del G20. ID:{idNuevoPais} ");
            }
            else if (mensajeError is not null)
            {
                MessageBox.Show(mensajeError);
            }
        }
        /// <summary>
        /// Carga los ComboBoxes con datos correspondientes a cada Enumerado.
        /// </summary>
        /// <returns></returns>
        private void LoadComboBoxes()
        {
            this.cboxContinente.DataSource = Enum.GetValues(typeof(EContinente));
            this.cboxIdioma.DataSource = Enum.GetValues(typeof(EIdioma));
            this.cboxIdh.DataSource = Enum.GetValues(typeof(EIndiceDesarrolloHumano));
        }
        private void SaveToJson()
        {
            string mensaje =Pais.SaveToJson(FrmMainMenu.ListaPaises);
            MessageBox.Show(mensaje);

        }
    }
}
