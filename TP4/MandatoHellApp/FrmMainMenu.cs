using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PaisesG20
{
    //Aqui declare los Delegados
    public delegate void TruncarYGuardarTabla();
    public delegate void AgregarUnPaisALaDB(int poblacion, bool potencia, double superficie,
        EContinente continente, EIdioma idioma, EIndiceDesarrolloHumano idh, string nombre);
    public partial class FrmMainMenu : Form
    {
        private static bool flagPaisesInvitados = false;
        private CancellationTokenSource cancelTokenSource;

        private static List<Pais> listaPaises;
        public static List<Pais> ListaPaises { get => listaPaises; set => listaPaises = value; }

        private static DataBaseControls db;
        public DataBaseControls Db { get => db; set => db = value; }

        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
        cancelTokenSource = new CancellationTokenSource();
        CancellationToken cancelToken = cancelTokenSource.Token;
        Task.Run(LoadFromDB, cancelToken);
            //LoadFromJson(); TP3
        }
        /// <summary>
        /// Carga la lista de paises desde un archivo Json con la funcion estatica de Pais.LoadFromJson,
        ///la actualiza en el DataGridView y da un mensaje indicando si fue satisfactorio o hubo un error.
        /// </summary>
        /// <returns></returns>
        private void LoadFromJson()
        {
            string mensaje;
            listaPaises = Pais.LoadFromJson(out mensaje);
            Task.Run(() => MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information));
            DataGridViewLoad();
        }
        /// <summary>
        /// Inicializa la base de datos y Carga la lista de paises desde ella. Luego vuelca los datos en DataGridView.
        /// </summary>
        private void LoadFromDB()
        {
            db = DataBaseControls.InicializarBaseDeDatos();
            ListaPaises = db.LeerListaDeDB();
            DataGridViewLoad();
            Thread.Sleep(10000); //Para darle algun uso al Cancellation Token
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
        /// Sobrecarga del metodo anterior que recibe como parametro una lista filtrada para ser mostrada en lugar de la original.
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
            if (flagPaisesInvitados == false)
            {
                string mensaje;
                Pais.AgregarPaisesALista(ListaPaises, "G20Invitados.json", out mensaje);
                Task.Run(() => MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information));
                db.LimpiarBaseDeDatos();
                db.GuardarListaEnDB(listaPaises);
                DataGridRefresh();
                flagPaisesInvitados = true;
            }
            else
            {
                Task.Run(() => MessageBox.Show("ERROR. Los paises invitados ya se han agregado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error));
            }
        }
        /// <summary>
        /// Restaura la Lista Estatica de este formulario a la lista de paises original usando la funcion de hardcodeo.
        /// </summary>
        private void RestaurarLista()
        {
            cancelTokenSource.Cancel(); //en caso de que aun siga cargando la base de datos
            listaPaises = Pais.HardcodeoPaises();
            string mensaje = Pais.SaveToJson(ListaPaises);
            DataGridRefresh();
            db.LimpiarBaseDeDatos();
            db.GuardarListaEnDB(listaPaises);
            flagPaisesInvitados = false;
            Task.Run(() => MessageBox.Show(mensaje,"", MessageBoxButtons.OK, MessageBoxIcon.Information));
        }

        /// <summary>
        /// Metodo para el botón que cambia la visibilidad de si mismo a oculto y muestra todos los demas controles y botones del menu principal.
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
            btnInformes.Visible = true;
        }
        #region botones
        private void lblHardcodeoManual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RestaurarLista();
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
        private void btnInformes_Click(object sender, EventArgs e)
        {
            FrmInformes menuInformes = new FrmInformes();
            menuInformes.ShowDialog();
            DataGridRefresh();
        }
        #endregion
        #region metodos de filtrado
        /// <summary>
        /// Llama a la funcion FiltroPorPredicate y realiza un messageBox indicando si se realizo o no el filtrado.
        /// </summary>
        /// <param name="listaPaises">La lista de paises a filtrar.</param>
        /// <param name="criteria">Predicate con el criterio de filtrado.</param>
        /// <param name="path">el path y etiqueta de criterio que se va a utilizar para el  filtrado.</param>
        /// <returns>Retorna la lista filtrada.</returns>
        private List<Pais> FiltroGenerico(List<Pais> listaPaises, Predicate<Pais> criteria, string path)
        {
            string mensaje;
            List<Pais> listaAuxiliar = Pais.FiltroPorPredicate(listaPaises, criteria, path, out mensaje);
            Task.Run(() => MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information));
            DataGridRefresh(listaAuxiliar);
            return listaAuxiliar;
        }
        /// <summary>
        /// Filtra la lista de paises y muestra en el DGV solo los que tienen como idioma el español, ademas de generar un Json
        /// </summary>
        private void FiltroSpanish()
        {
            Predicate<Pais> criteria = (p) => p.Idioma == EIdioma.Spanish;
            FiltroGenerico(listaPaises, criteria, "Spanish");
        }
        /// <summary>
        /// Filtra la lista de paises y muestra en el DGV solo los que tienen como idioma el ingles, ademas de generar un Json
        /// </summary>
        private void FiltroEnglish()
        {
            Predicate<Pais> criteria = (p) => p.Idioma == EIdioma.English;
            FiltroGenerico(listaPaises, criteria, "English");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los del continente Asiatico
        /// </summary>
        private void FiltroAsia()
        {
            Predicate<Pais> criteria = (p) => p.Continente == EContinente.Asia;
            FiltroGenerico(listaPaises, criteria, "Asia");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los del continente Americano
        /// </summary>
        private void FiltroAmerica()
        {
            Predicate<Pais> criteria = (p) => p.Continente == EContinente.America;
            FiltroGenerico(listaPaises, criteria, "America");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los del continente Africano
        /// </summary>
        private void FiltroAfrica()
        {
            Predicate<Pais> criteria = (p) => p.Continente == EContinente.Africa;
            FiltroGenerico(listaPaises, criteria, "Africa");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los del continente Europeo
        /// </summary>
        private void FiltroEuropa()
        {
            Predicate<Pais> criteria = (p) => p.Continente == EContinente.Europa;
            FiltroGenerico(listaPaises, criteria, "Europa");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los del continente Oceanico
        /// </summary>
        private void FiltroOceania()
        {
            Predicate<Pais> criteria = (p) => p.Continente == EContinente.Oceania;
            FiltroGenerico(listaPaises, criteria, "Oceania");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los de menos de 50 millones de habitantes
        /// </summary>
        private void FiltroMenosCincuentaMillones()
        {
            Predicate<Pais> criteria = (p) => p.Poblacion < 50000000;
            FiltroGenerico(listaPaises, criteria, "Menos De 50 Millones");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los de entre 50 y 100 millones de habitantes
        /// </summary>
        private void FiltroCincuentaACienMillones()
        {
            Predicate<Pais> criteria = (p) => p.Poblacion >= 50000000 && p.Poblacion < 100000000;
            FiltroGenerico(listaPaises, criteria, "Entre 50 y 100 Millones");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los de entre 100 y 500 millones de habitantes
        /// </summary>
        private void FiltroCienAQuinientosMillones()
        {
            Predicate<Pais> criteria = (p) => p.Poblacion >= 100000000 && p.Poblacion < 500000000;
            FiltroGenerico(listaPaises, criteria, "Entre 100 y 500 Millones");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los de mas de 500 millones de habitantes
        /// </summary>
        private void FiltroMasDeQuinientosMillones()
        {
            Predicate<Pais> criteria = (p) => p.Poblacion >= 500000000;
            FiltroGenerico(listaPaises, criteria, "Mas de 500 Millones");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los que son potencia militar
        /// </summary>
        private void FiltroEsPotencia()
        {
            Predicate<Pais> criteria = (p) => p.Potencia is true;
            FiltroGenerico(listaPaises, criteria, "Es Potencia Militar");
        }
        /// <summary>
        /// Filtra la lista de paises para generar un Json y mostrar en el DGV solo los que NO son potencia militar
        /// </summary>
        private void FiltroNoEsPotencia()
        {
            Predicate<Pais> criteria = (p) => p.Potencia is false;
            FiltroGenerico(listaPaises, criteria, "NO Es Potencia Militar");
        }

        #endregion
        #region metodos Para llamar con Delegados
        /// <summary>
        /// Metodo estatico que agrega un pais a la tabla de la base de datos por parametros, con la instancia local de la database,
        /// para utilizar con delegados.
        /// </summary>
        /// <param name="poblacion"></param>
        /// <param name="potencia"></param>
        /// <param name="superficie"></param>
        /// <param name="continente"></param>
        /// <param name="idioma"></param>
        /// <param name="idh"></param>
        /// <param name="nombre"></param>
        public static void SumarPais(int poblacion, bool potencia, double superficie, EContinente continente, EIdioma idioma, EIndiceDesarrolloHumano idh, string nombre)
        {
            db.AgregarUnPaisALaDB(poblacion, potencia, superficie, continente, idioma, idh, nombre);
        }
        /// <summary>
        /// Metodo estatico que trunca la tabla de la base de datos por parametros y la genera nuevamente a partir de la lista,
        /// con la instancia local de la database, para utilizar con delegados.
        /// </summary>
        public static void LimpiarYGuardarTabla()
        {
            db.LimpiarBaseDeDatos();
            db.GuardarListaEnDB(listaPaises);
        }
        #endregion
    }

}
