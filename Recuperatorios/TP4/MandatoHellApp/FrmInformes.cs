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
    public partial class FrmInformes : Form
    {
        string informe;
        public FrmInformes()
        {
            InitializeComponent();
        }
        #region botones
        private void btnInformeDesarrollo_Click(object sender, EventArgs e)
        {
            informe = Pais.InformeDesarrollo(FrmMainMenu.ListaPaises);
            MessageBoxInformes(informe);
        }

        private void btnInformeMilitar_Click(object sender, EventArgs e)
        {
            informe = Pais.InformeMilitar(FrmMainMenu.ListaPaises);
            MessageBoxInformes(informe);
        }

        private void btnInformeDensidad_Click(object sender, EventArgs e)
        {
            informe = Pais.InformeDensidad(FrmMainMenu.ListaPaises);
            MessageBoxInformes(informe);
        }

        private void btnContinenteDominante_Click(object sender, EventArgs e)
        {
            informe = Pais.InformeContinentes(FrmMainMenu.ListaPaises);
            MessageBoxInformes(informe);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarInforme();
        }
        #endregion
        /// <summary>
        /// Messagebox presonalizada que muestra el informe recibido por parametro en pantalla.
        /// </summary>
        /// <param name="informe">string con el informe a mostrar</param>
        private void MessageBoxInformes(string informe)
        {
            MessageBox.Show(informe, "Informe creado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        /// <summary>
        /// Guarda el ultimo informe visualizado como un archivo XML.
        /// </summary>
        private void GuardarInforme()
        {
            if (informe is not null)
            {
                Pais.GuardarInformeXML(this.informe);
                MessageBox.Show("El informe se creo correctamente.", "Informe creado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR. Primero debe elegir el informe que desea guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
