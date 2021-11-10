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
    public partial class FrmMainMenu : Form
    {
        private static List<Pais> listaPaises;
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        public static List<Pais> ListaPaises { get => listaPaises; set => listaPaises = value; }



        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            listaPaises = LoadFromJson();
            DataGridViewLoad();
        }
        /// <summary>
        /// Carga la lista de paises desde un archivo Json y la actualiza en el DataGridView y la devuelve por retorno.
        /// </summary>
        /// <returns></returns>
        private List<Pais> LoadFromJson()
        {
            try
            {
                Serializador<List<Pais>> lista = new Serializador<List<Pais>>(IArchivos<List<Pais>>.ETipoArchivo.JSON);
                List<Pais> paisesG20 = lista.Leer("G20.json");
                MessageBox.Show("Se Cargó la lista de paises del G20 por medio del archivo Json.");
                DataGridRefresh();
                return paisesG20;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// Guarda la lista estatica de paises que se encuentra en memoria en un archivo Json.
        /// </summary>
        internal static void SaveToJson()
        {
            List<Pais> paisesG20 = listaPaises;

            try
            {
                Serializador<List<Pais>> lista = new Serializador<List<Pais>>(IArchivos<List<Pais>>.ETipoArchivo.JSON);
                lista.Escribir(paisesG20, "G20.json");
                MessageBox.Show("Json creado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Linkea el DataGridView con la lista estatica de paises, por medio del DataSource.
        /// </summary>
        private void DataGridViewLoad()
        {
            dgvPaises.DataSource = listaPaises;
        }

        /// <summary>
        /// Recarga el dataGridView con los nuevos cambios por medio del BindingSource.
        /// </summary>
        internal void DataGridRefresh()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = listaPaises;
            dgvPaises.DataSource = bs;
            bs.ResetBindings(false);
        }
        /// <summary>
        /// Sobrecarga del metodo anterior que recibe como parametro una lista filtrada para ser mostrada.
        /// </summary>
        /// <param name="listaFiltrada">Lista filtrada recibida para ser mostrada</param>
        private void DataGridRefresh(List<Pais> listaFiltrada)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = listaFiltrada;
            dgvPaises.DataSource = bs;
            bs.ResetBindings(false);
        }
        /// <summary>
        /// Agrega a la lista estatica actual los paises que figuran como invitados al G20, que se encuentra en un archivo Json independiente.
        /// </summary>
        private void AgregarPaisesInvitados()
        {
            try
            {
                Serializador<List<Pais>> lista = new Serializador<List<Pais>>(IArchivos<List<Pais>>.ETipoArchivo.JSON);
                List<Pais> invitados = lista.Leer("G20Invitados.json");
                listaPaises.AddRange(invitados);
                DataGridRefresh();
                MessageBox.Show("Paises invitados agregados satisfactoriamente.");
                //return paisesG20;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Boton que cambia la visibilidad de si mismo a oculto y muestra todos los demas controles y botones del menu principal.
        /// </summary>
        private void SwitchVisibilidad()
        {
            dgvPaises.Visible = true;
            btnAddPais.Visible = true;
            btnMostrar.Visible = false;
            btnAfrica.Visible = true;
            btnAmerica.Visible = true;
            btnAsia.Visible = true;
            btnCienAQuinientos.Visible = true;
            btnCincuentaACien.Visible = true;
            btnEsPotencia.Visible = true;
            btnEuropa.Visible = true;
            btnFiltroEspañol.Visible = true;
            btnFiltroIngles.Visible = true;
            btnMasDeQuinientos.Visible = true;
            btnMenosCincuenta.Visible = true;
            btnNoEsPotencia.Visible = true;
            btnOceania.Visible = true;
            btnPaisesInvitados.Visible = true;
            btnRestoreList.Visible = true;
            lblContinente.Visible = true;
            lblHardcodeoManual.Visible = true;
            lblFiltrar.Visible = true;
            lblIdioma.Visible = true;
            lblPoblacion.Visible = true;
            lblPotencia.Visible = true;
            lblOtrosControles.Visible = true;
        }
        #region botones
        private void lblHardcodeoManual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listaPaises = Pais.HardcodeoPaises();
            SaveToJson();
            DataGridRefresh();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            SwitchVisibilidad();
        }
        private void btnAddPais_Click(object sender, EventArgs e)
        {
            FrmAltaPais menuEmpleado = new FrmAltaPais();
            menuEmpleado.ShowDialog();
            DataGridRefresh();
        }
        private void btnPaisesInvitados_Click(object sender, EventArgs e)
        {
            AgregarPaisesInvitados();
            DataGridRefresh();
        }
        private void btnFiltroEspañol_Click(object sender, EventArgs e)
        {
            FiltroSpanish();
        }

        private void btnRestoreList_Click(object sender, EventArgs e)
        {
            DataGridRefresh();
        }

        private void btnFiltroIngles_Click(object sender, EventArgs e)
        {
            FiltroEnglish();
        }

        private void btnAsia_Click(object sender, EventArgs e)
        {
            FiltroAsia();
        }

        private void btnAmerica_Click(object sender, EventArgs e)
        {
            FiltroAmerica();
        }

        private void btnEuropa_Click(object sender, EventArgs e)
        {
            FiltroEuropa();
        }

        private void btnAfrica_Click(object sender, EventArgs e)
        {
            FiltroAfrica();
        }

        private void btnOceania_Click(object sender, EventArgs e)
        {
            FiltroOceania();
        }

        private void btnMenosCincuenta_Click(object sender, EventArgs e)
        {
            FiltroMenosCincuentaMillones();
        }

        private void btnCincuentaACien_Click(object sender, EventArgs e)
        {
            FiltroCincuentaACienMillones();
        }

        private void btnCienAQuinientos_Click(object sender, EventArgs e)
        {
            FiltroCienAQuinientosMillones();
        }

        private void btnMasDeQuinientos_Click(object sender, EventArgs e)
        {
            FiltroMasDeQuinientosMillones();
        }

        private void btnEsPotencia_Click(object sender, EventArgs e)
        {
            FiltroEsPotencia();
        }

        private void btnNoEsPotencia_Click(object sender, EventArgs e)
        {
            FiltroNoEsPotencia();
        }
        private void dgvPaises_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        #region metodos de filtrado
        /// <summary>
        /// Metodo que recibe una lista filtrada y un string que se utiliza como clave para
        /// nombrar e identificar el tipo de filtro realizado al guardarlo en un archivo Json 
        /// </summary>
        /// <param name="listaFiltrada"></param>
        /// <param name="path"></param>
        private void JsonFiltradoGenerator(List<Pais> listaFiltrada, string path)
        {
            try
            {
                Serializador<List<Pais>> lista = new Serializador<List<Pais>>(IArchivos<List<Pais>>.ETipoArchivo.JSON);
                lista.Escribir(listaFiltrada, $"{path}.json");
                MessageBox.Show($"Json del filtro {path} creado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Filtra la lista de paises y muestra en el DGV solo los que tienen como idioma el español, ademas de generar un Json
        /// </summary>
        private void FiltroSpanish()
        {
            List<Pais> listaSpanish = listaPaises.FindAll((p) => p.Idioma == EIdioma.Spanish);
            DataGridRefresh(listaSpanish);
            JsonFiltradoGenerator(listaSpanish, "Spanish");
        }
        /// <summary>
        /// Filtra la lista de paises y muestra en el DGV solo los que tienen como idioma el ingles, ademas de generar un Json
        /// </summary>
        private void FiltroEnglish()
        {
            List<Pais> listaEnglish = listaPaises.FindAll((p) => p.Idioma == EIdioma.English);
            DataGridRefresh(listaEnglish);
            JsonFiltradoGenerator(listaEnglish, "English");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los del continente Asiatico
        /// </summary>
        private void FiltroAsia()
        {
            List<Pais> listaAsia = listaPaises.FindAll((p) => p.Continente == EContinente.Asia);
            DataGridRefresh(listaAsia);
            JsonFiltradoGenerator(listaAsia, "Asia");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los del continente Americano
        /// </summary>
        private void FiltroAmerica()
        {
            List<Pais> listaAmerica = listaPaises.FindAll((p) => p.Continente == EContinente.America);
            DataGridRefresh(listaAmerica);
            JsonFiltradoGenerator(listaAmerica, "America");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los del continente Africano
        /// </summary>
        private void FiltroAfrica()
        {
            List<Pais> listaAfrica = listaPaises.FindAll((p) => p.Continente == EContinente.Africa);
            DataGridRefresh(listaAfrica);
            JsonFiltradoGenerator(listaAfrica, "Africa");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los del continente Europeo
        /// </summary>
        private void FiltroEuropa()
        {
            List<Pais> listaEuropa = listaPaises.FindAll((p) => p.Continente == EContinente.Europa);
            DataGridRefresh(listaEuropa);
            JsonFiltradoGenerator(listaEuropa, "Europa");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los del continente Oceanico
        /// </summary>
        private void FiltroOceania()
        {
            List<Pais> listaOceania = listaPaises.FindAll((p) => p.Continente == EContinente.Oceania);
            DataGridRefresh(listaOceania);
            JsonFiltradoGenerator(listaOceania, "Oceania");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los de menos de 50 millones de habitantes
        /// </summary>
        private void FiltroMenosCincuentaMillones()
        {
            List<Pais> listaCincuentaMillones = listaPaises.FindAll((p) => p.Poblacion < 50000000);
            DataGridRefresh(listaCincuentaMillones);
            JsonFiltradoGenerator(listaCincuentaMillones, "Menos De 50 Millones");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los de entre 50 y 100 millones de habitantes
        /// </summary>
        private void FiltroCincuentaACienMillones()
        {
            List<Pais> listaCincuentaACienMillones = listaPaises.FindAll((p) => p.Poblacion >= 50000000 && p.Poblacion  < 100000000);
            DataGridRefresh(listaCincuentaACienMillones);
            JsonFiltradoGenerator(listaCincuentaACienMillones, "Entre 50 y 100 Millones");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los de entre 100 y 500 millones de habitantes
        /// </summary>
        private void FiltroCienAQuinientosMillones()
        {
            List<Pais> listaCienAQuinientosMillones = listaPaises.FindAll((p) => p.Poblacion >= 100000000 && p.Poblacion < 500000000);
            DataGridRefresh(listaCienAQuinientosMillones);
            JsonFiltradoGenerator(listaCienAQuinientosMillones, "Entre 100 y 500 Millones");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los de mas de 500 millones de habitantes
        /// </summary>
        private void FiltroMasDeQuinientosMillones()
        {
            List<Pais> listaMasDeAQuinientosMillones = listaPaises.FindAll((p) => p.Poblacion >= 500000000);
            DataGridRefresh(listaMasDeAQuinientosMillones);
            JsonFiltradoGenerator(listaMasDeAQuinientosMillones, "Mas de 500 Millones");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los que son potencia militar
        /// </summary>
        private void FiltroEsPotencia()
        {
            List<Pais> listaPotenciasMilitares = listaPaises.FindAll((p) => p.Potencia is true);
            DataGridRefresh(listaPotenciasMilitares);
            JsonFiltradoGenerator(listaPotenciasMilitares, "Es Potencia Militar");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los que NO son potencia militar
        /// </summary>
        private void FiltroNoEsPotencia()
        {
            List<Pais> listaNoPotenciasMilitares = listaPaises.FindAll((p) => p.Potencia is false);
            DataGridRefresh(listaNoPotenciasMilitares);
            JsonFiltradoGenerator(listaNoPotenciasMilitares, "NO Es Potencia Militar");
        }

        #endregion
    }

}
