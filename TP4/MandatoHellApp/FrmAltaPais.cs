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
        //Aqui asigno metodos a los delegados
        AgregarUnPaisALaDB sumarPaisALaDb = FrmMainMenu.SumarPais;
        TruncarYGuardarTabla limpiarYGuardar = FrmMainMenu.LimpiarYGuardarTabla;
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
            AltaPais(sumarPaisALaDb);
        }
        private void btnJson_Click(object sender, EventArgs e)
        {
            SaveToJson();
        }
        private void btnGuardarDB_Click(object sender, EventArgs e)
        {
            SaveToDB(limpiarYGuardar);
        }

        /// <summary>
        /// Da de alta un nuevo pais y lo agrega a la lista del formulario principal.
        /// </summary>
        private async void AltaPais(AgregarUnPaisALaDB sumarPaisALaDb)
        {
            if (Pais.ValidarPaisNuevo(txtNombre.Text, txtPoblacion.Text, txtSuperficie.Text, out string mensajeError) is true)
            {
                int idNuevoPais;
                idNuevoPais= Pais.addPaisToList(FrmMainMenu.ListaPaises, txtNombre.Text, txtPoblacion.Text,txtSuperficie.Text,
                                                (EIdioma)cboxIdioma.SelectedItem, (EIndiceDesarrolloHumano)cboxIdh.SelectedItem,
                                                (EContinente)cboxContinente.SelectedItem, chbPotencia.Checked);
                _ = Task.Run(() => MessageBox.Show($"Se agregó el país {txtNombre.Text} a la lista del G20. ID:{idNuevoPais} ", "Pais guardado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information));
                //Uso de task con expresion lambda para utilizar el delegado. Se requiere invocar a la instancia de este formulario.
                await Task.Run(() =>
                {
                    if (this.txtNombre.InvokeRequired) // Deberia dar true siempre porque la task está en otra instancia 
                    {
                        this.BeginInvoke((MethodInvoker)delegate ()
                        {
                            sumarPaisALaDb(int.Parse(txtPoblacion.Text), chbPotencia.Checked, int.Parse(txtSuperficie.Text),
                        (EContinente)cboxContinente.SelectedItem, (EIdioma)cboxIdioma.SelectedItem, (EIndiceDesarrolloHumano)cboxIdh.SelectedItem, txtNombre.Text);
                        });
                    }
                });

            }
            else if (mensajeError is not null)
            {
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// <summary>
        /// Guarda la lista actual en un archivo .JSON
        /// </summary>
        private void SaveToJson()
        {
            string mensaje =Pais.SaveToJson(FrmMainMenu.ListaPaises);
            Task.Run(() => MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information));
        }
        /// <summary>
        /// Utiliza a traves del delegado los metodos de instancia de acceso a la base de datos,
        /// trunca la tabla y la guarda nuevamente a partir de la lista.
        /// </summary>
        /// <param name="limpiarYGuardar"></param>
        private void SaveToDB(TruncarYGuardarTabla limpiarYGuardar)
        {
            limpiarYGuardar();
            Task.Run(() => MessageBox.Show("Lista Guardada Correctamente en la base de datos.", "Lista Guardada correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information));
        }
    }
}
