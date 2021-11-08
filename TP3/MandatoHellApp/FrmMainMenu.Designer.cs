
namespace PaisesG20
{
    partial class FrmMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.btnAddPais = new System.Windows.Forms.Button();
            this.lblHardcodeoManual = new System.Windows.Forms.LinkLabel();
            this.dgvPaises = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnFiltroEspañol = new System.Windows.Forms.Button();
            this.btnFiltroIngles = new System.Windows.Forms.Button();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblContinente = new System.Windows.Forms.Label();
            this.btnAsia = new System.Windows.Forms.Button();
            this.btnAfrica = new System.Windows.Forms.Button();
            this.btnAmerica = new System.Windows.Forms.Button();
            this.btnEuropa = new System.Windows.Forms.Button();
            this.btnOceania = new System.Windows.Forms.Button();
            this.lblPoblacion = new System.Windows.Forms.Label();
            this.btnMenosCincuenta = new System.Windows.Forms.Button();
            this.btnCincuentaACien = new System.Windows.Forms.Button();
            this.btnCienAQuinientos = new System.Windows.Forms.Button();
            this.btnMasDeQuinientos = new System.Windows.Forms.Button();
            this.btnEsPotencia = new System.Windows.Forms.Button();
            this.btnNoEsPotencia = new System.Windows.Forms.Button();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.btnPaisesInvitados = new System.Windows.Forms.Button();
            this.btnRestoreList = new System.Windows.Forms.Button();
            this.lblOtrosControles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaises)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPais
            // 
            this.btnAddPais.Location = new System.Drawing.Point(895, 641);
            this.btnAddPais.Name = "btnAddPais";
            this.btnAddPais.Size = new System.Drawing.Size(219, 28);
            this.btnAddPais.TabIndex = 0;
            this.btnAddPais.Text = "Agregar Nuevo Pais a la Lista";
            this.btnAddPais.UseVisualStyleBackColor = true;
            this.btnAddPais.Visible = false;
            this.btnAddPais.Click += new System.EventHandler(this.btnAddPais_Click);
            // 
            // lblHardcodeoManual
            // 
            this.lblHardcodeoManual.AutoSize = true;
            this.lblHardcodeoManual.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHardcodeoManual.DisabledLinkColor = System.Drawing.Color.White;
            this.lblHardcodeoManual.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHardcodeoManual.LinkColor = System.Drawing.Color.Navy;
            this.lblHardcodeoManual.Location = new System.Drawing.Point(649, 706);
            this.lblHardcodeoManual.Name = "lblHardcodeoManual";
            this.lblHardcodeoManual.Size = new System.Drawing.Size(478, 17);
            this.lblHardcodeoManual.TabIndex = 1;
            this.lblHardcodeoManual.TabStop = true;
            this.lblHardcodeoManual.Text = "¿Se rompieron los archivos? Click aquí para re-hardcodear los paises originales.";
            this.lblHardcodeoManual.Visible = false;
            this.lblHardcodeoManual.VisitedLinkColor = System.Drawing.Color.Red;
            this.lblHardcodeoManual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHardcodeoManual_LinkClicked);
            // 
            // dgvPaises
            // 
            this.dgvPaises.AllowUserToAddRows = false;
            this.dgvPaises.AllowUserToDeleteRows = false;
            this.dgvPaises.AllowUserToOrderColumns = true;
            this.dgvPaises.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvPaises.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPaises.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaises.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaises.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPaises.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvPaises.Location = new System.Drawing.Point(25, 12);
            this.dgvPaises.Name = "dgvPaises";
            this.dgvPaises.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaises.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPaises.RowHeadersWidth = 49;
            this.dgvPaises.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPaises.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPaises.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgvPaises.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPaises.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkBlue;
            this.dgvPaises.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPaises.RowTemplate.Height = 28;
            this.dgvPaises.Size = new System.Drawing.Size(1089, 561);
            this.dgvPaises.TabIndex = 2;
            this.dgvPaises.Visible = false;
            this.dgvPaises.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaises_CellContentClick);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(532, 579);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(109, 58);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar listas y controles";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnFiltroEspañol
            // 
            this.btnFiltroEspañol.Location = new System.Drawing.Point(25, 644);
            this.btnFiltroEspañol.Name = "btnFiltroEspañol";
            this.btnFiltroEspañol.Size = new System.Drawing.Size(90, 28);
            this.btnFiltroEspañol.TabIndex = 4;
            this.btnFiltroEspañol.Text = "Español";
            this.btnFiltroEspañol.UseVisualStyleBackColor = true;
            this.btnFiltroEspañol.Visible = false;
            this.btnFiltroEspañol.Click += new System.EventHandler(this.btnFiltroEspañol_Click);
            // 
            // btnFiltroIngles
            // 
            this.btnFiltroIngles.Location = new System.Drawing.Point(25, 678);
            this.btnFiltroIngles.Name = "btnFiltroIngles";
            this.btnFiltroIngles.Size = new System.Drawing.Size(90, 28);
            this.btnFiltroIngles.TabIndex = 5;
            this.btnFiltroIngles.Text = "Inglés";
            this.btnFiltroIngles.UseVisualStyleBackColor = true;
            this.btnFiltroIngles.Visible = false;
            this.btnFiltroIngles.Click += new System.EventHandler(this.btnFiltroIngles_Click);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFiltrar.Font = new System.Drawing.Font("Segoe UI", 8.765218F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblFiltrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFiltrar.Location = new System.Drawing.Point(25, 579);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(363, 20);
            this.lblFiltrar.TabIndex = 6;
            this.lblFiltrar.Text = "Criterios para filtrar la lista y generar un archivo:";
            this.lblFiltrar.Visible = false;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdioma.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdioma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIdioma.Location = new System.Drawing.Point(25, 610);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(89, 20);
            this.lblIdioma.TabIndex = 7;
            this.lblIdioma.Text = "Por idioma:";
            this.lblIdioma.Visible = false;
            // 
            // lblContinente
            // 
            this.lblContinente.AutoSize = true;
            this.lblContinente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContinente.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContinente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContinente.Location = new System.Drawing.Point(156, 610);
            this.lblContinente.Name = "lblContinente";
            this.lblContinente.Size = new System.Drawing.Size(118, 20);
            this.lblContinente.TabIndex = 8;
            this.lblContinente.Text = "Por Continente:";
            this.lblContinente.Visible = false;
            // 
            // btnAsia
            // 
            this.btnAsia.Location = new System.Drawing.Point(156, 641);
            this.btnAsia.Name = "btnAsia";
            this.btnAsia.Size = new System.Drawing.Size(90, 28);
            this.btnAsia.TabIndex = 9;
            this.btnAsia.Text = "Asia";
            this.btnAsia.UseVisualStyleBackColor = true;
            this.btnAsia.Visible = false;
            this.btnAsia.Click += new System.EventHandler(this.btnAsia_Click);
            // 
            // btnAfrica
            // 
            this.btnAfrica.Location = new System.Drawing.Point(252, 642);
            this.btnAfrica.Name = "btnAfrica";
            this.btnAfrica.Size = new System.Drawing.Size(90, 28);
            this.btnAfrica.TabIndex = 10;
            this.btnAfrica.Text = "Africa";
            this.btnAfrica.UseVisualStyleBackColor = true;
            this.btnAfrica.Visible = false;
            this.btnAfrica.Click += new System.EventHandler(this.btnAfrica_Click);
            // 
            // btnAmerica
            // 
            this.btnAmerica.Location = new System.Drawing.Point(156, 677);
            this.btnAmerica.Name = "btnAmerica";
            this.btnAmerica.Size = new System.Drawing.Size(90, 28);
            this.btnAmerica.TabIndex = 11;
            this.btnAmerica.Text = "America";
            this.btnAmerica.UseVisualStyleBackColor = true;
            this.btnAmerica.Visible = false;
            this.btnAmerica.Click += new System.EventHandler(this.btnAmerica_Click);
            // 
            // btnEuropa
            // 
            this.btnEuropa.Location = new System.Drawing.Point(252, 678);
            this.btnEuropa.Name = "btnEuropa";
            this.btnEuropa.Size = new System.Drawing.Size(90, 28);
            this.btnEuropa.TabIndex = 12;
            this.btnEuropa.Text = "Europa";
            this.btnEuropa.UseVisualStyleBackColor = true;
            this.btnEuropa.Visible = false;
            this.btnEuropa.Click += new System.EventHandler(this.btnEuropa_Click);
            // 
            // btnOceania
            // 
            this.btnOceania.Location = new System.Drawing.Point(348, 641);
            this.btnOceania.Name = "btnOceania";
            this.btnOceania.Size = new System.Drawing.Size(90, 28);
            this.btnOceania.TabIndex = 13;
            this.btnOceania.Text = "Oceania";
            this.btnOceania.UseVisualStyleBackColor = true;
            this.btnOceania.Visible = false;
            this.btnOceania.Click += new System.EventHandler(this.btnOceania_Click);
            // 
            // lblPoblacion
            // 
            this.lblPoblacion.AutoSize = true;
            this.lblPoblacion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPoblacion.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPoblacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPoblacion.Location = new System.Drawing.Point(480, 610);
            this.lblPoblacion.Name = "lblPoblacion";
            this.lblPoblacion.Size = new System.Drawing.Size(109, 20);
            this.lblPoblacion.TabIndex = 14;
            this.lblPoblacion.Text = "Por Poblacion:";
            this.lblPoblacion.Visible = false;
            // 
            // btnMenosCincuenta
            // 
            this.btnMenosCincuenta.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenosCincuenta.Location = new System.Drawing.Point(480, 642);
            this.btnMenosCincuenta.Name = "btnMenosCincuenta";
            this.btnMenosCincuenta.Size = new System.Drawing.Size(90, 28);
            this.btnMenosCincuenta.TabIndex = 15;
            this.btnMenosCincuenta.Text = "<50Millon";
            this.btnMenosCincuenta.UseVisualStyleBackColor = true;
            this.btnMenosCincuenta.Visible = false;
            this.btnMenosCincuenta.Click += new System.EventHandler(this.btnMenosCincuenta_Click);
            // 
            // btnCincuentaACien
            // 
            this.btnCincuentaACien.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCincuentaACien.Location = new System.Drawing.Point(480, 675);
            this.btnCincuentaACien.Name = "btnCincuentaACien";
            this.btnCincuentaACien.Size = new System.Drawing.Size(90, 28);
            this.btnCincuentaACien.TabIndex = 16;
            this.btnCincuentaACien.Text = "<100Millon";
            this.btnCincuentaACien.UseVisualStyleBackColor = true;
            this.btnCincuentaACien.Visible = false;
            this.btnCincuentaACien.Click += new System.EventHandler(this.btnCincuentaACien_Click);
            // 
            // btnCienAQuinientos
            // 
            this.btnCienAQuinientos.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCienAQuinientos.Location = new System.Drawing.Point(576, 642);
            this.btnCienAQuinientos.Name = "btnCienAQuinientos";
            this.btnCienAQuinientos.Size = new System.Drawing.Size(90, 28);
            this.btnCienAQuinientos.TabIndex = 17;
            this.btnCienAQuinientos.Text = "<500Millon";
            this.btnCienAQuinientos.UseVisualStyleBackColor = true;
            this.btnCienAQuinientos.Visible = false;
            this.btnCienAQuinientos.Click += new System.EventHandler(this.btnCienAQuinientos_Click);
            // 
            // btnMasDeQuinientos
            // 
            this.btnMasDeQuinientos.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMasDeQuinientos.Location = new System.Drawing.Point(576, 675);
            this.btnMasDeQuinientos.Name = "btnMasDeQuinientos";
            this.btnMasDeQuinientos.Size = new System.Drawing.Size(90, 28);
            this.btnMasDeQuinientos.TabIndex = 18;
            this.btnMasDeQuinientos.Text = "+500Millon";
            this.btnMasDeQuinientos.UseVisualStyleBackColor = true;
            this.btnMasDeQuinientos.Visible = false;
            this.btnMasDeQuinientos.Click += new System.EventHandler(this.btnMasDeQuinientos_Click);
            // 
            // btnEsPotencia
            // 
            this.btnEsPotencia.Location = new System.Drawing.Point(707, 641);
            this.btnEsPotencia.Name = "btnEsPotencia";
            this.btnEsPotencia.Size = new System.Drawing.Size(116, 28);
            this.btnEsPotencia.TabIndex = 19;
            this.btnEsPotencia.Text = "Es Potencia";
            this.btnEsPotencia.UseVisualStyleBackColor = true;
            this.btnEsPotencia.Visible = false;
            this.btnEsPotencia.Click += new System.EventHandler(this.btnEsPotencia_Click);
            // 
            // btnNoEsPotencia
            // 
            this.btnNoEsPotencia.Location = new System.Drawing.Point(707, 675);
            this.btnNoEsPotencia.Name = "btnNoEsPotencia";
            this.btnNoEsPotencia.Size = new System.Drawing.Size(116, 28);
            this.btnNoEsPotencia.TabIndex = 20;
            this.btnNoEsPotencia.Text = "No Es Potencia";
            this.btnNoEsPotencia.UseVisualStyleBackColor = true;
            this.btnNoEsPotencia.Visible = false;
            this.btnNoEsPotencia.Click += new System.EventHandler(this.btnNoEsPotencia_Click);
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPotencia.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPotencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPotencia.Location = new System.Drawing.Point(707, 610);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(146, 20);
            this.lblPotencia.TabIndex = 21;
            this.lblPotencia.Text = "Por Poderío Militar:";
            this.lblPotencia.Visible = false;
            // 
            // btnPaisesInvitados
            // 
            this.btnPaisesInvitados.Location = new System.Drawing.Point(895, 675);
            this.btnPaisesInvitados.Name = "btnPaisesInvitados";
            this.btnPaisesInvitados.Size = new System.Drawing.Size(219, 28);
            this.btnPaisesInvitados.TabIndex = 22;
            this.btnPaisesInvitados.Text = "Agregar Paises Invitados";
            this.btnPaisesInvitados.UseVisualStyleBackColor = true;
            this.btnPaisesInvitados.Visible = false;
            this.btnPaisesInvitados.Click += new System.EventHandler(this.btnPaisesInvitados_Click);
            // 
            // btnRestoreList
            // 
            this.btnRestoreList.Location = new System.Drawing.Point(895, 610);
            this.btnRestoreList.Name = "btnRestoreList";
            this.btnRestoreList.Size = new System.Drawing.Size(219, 27);
            this.btnRestoreList.TabIndex = 23;
            this.btnRestoreList.Text = "Mostrar Lista sin filtros";
            this.btnRestoreList.UseVisualStyleBackColor = true;
            this.btnRestoreList.Visible = false;
            this.btnRestoreList.Click += new System.EventHandler(this.btnRestoreList_Click);
            // 
            // lblOtrosControles
            // 
            this.lblOtrosControles.AutoSize = true;
            this.lblOtrosControles.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOtrosControles.Font = new System.Drawing.Font("Segoe UI", 8.765218F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblOtrosControles.Location = new System.Drawing.Point(895, 580);
            this.lblOtrosControles.Name = "lblOtrosControles";
            this.lblOtrosControles.Size = new System.Drawing.Size(123, 20);
            this.lblOtrosControles.TabIndex = 24;
            this.lblOtrosControles.Text = "Otros Controles:";
            this.lblOtrosControles.Visible = false;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PaisesG20.Properties.Resources._2018_G20_logo_1140x6841;
            this.ClientSize = new System.Drawing.Size(1139, 730);
            this.Controls.Add(this.lblOtrosControles);
            this.Controls.Add(this.btnRestoreList);
            this.Controls.Add(this.btnPaisesInvitados);
            this.Controls.Add(this.lblPotencia);
            this.Controls.Add(this.btnNoEsPotencia);
            this.Controls.Add(this.btnEsPotencia);
            this.Controls.Add(this.btnMasDeQuinientos);
            this.Controls.Add(this.btnCienAQuinientos);
            this.Controls.Add(this.btnCincuentaACien);
            this.Controls.Add(this.btnMenosCincuenta);
            this.Controls.Add(this.lblPoblacion);
            this.Controls.Add(this.btnOceania);
            this.Controls.Add(this.btnEuropa);
            this.Controls.Add(this.btnAmerica);
            this.Controls.Add(this.btnAfrica);
            this.Controls.Add(this.btnAsia);
            this.Controls.Add(this.lblContinente);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.btnFiltroIngles);
            this.Controls.Add(this.btnFiltroEspañol);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvPaises);
            this.Controls.Add(this.lblHardcodeoManual);
            this.Controls.Add(this.btnAddPais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMainMenu";
            this.Text = "G20 Main Menu";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPais;
        private System.Windows.Forms.LinkLabel lblHardcodeoManual;
        private System.Windows.Forms.DataGridView dgvPaises;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnFiltroEspañol;
        private System.Windows.Forms.Button btnFiltroIngles;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblContinente;
        private System.Windows.Forms.Button btnAsia;
        private System.Windows.Forms.Button btnAfrica;
        private System.Windows.Forms.Button btnAmerica;
        private System.Windows.Forms.Button btnEuropa;
        private System.Windows.Forms.Button btnOceania;
        private System.Windows.Forms.Label lblPoblacion;
        private System.Windows.Forms.Button btnMenosCincuenta;
        private System.Windows.Forms.Button btnCincuentaACien;
        private System.Windows.Forms.Button btnCienAQuinientos;
        private System.Windows.Forms.Button btnMasDeQuinientos;
        private System.Windows.Forms.Button btnEsPotencia;
        private System.Windows.Forms.Button btnNoEsPotencia;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.Button btnPaisesInvitados;
        private System.Windows.Forms.Button btnRestoreList;
        private System.Windows.Forms.Label lblOtrosControles;
    }
}

