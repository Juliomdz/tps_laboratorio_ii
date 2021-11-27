
namespace PaisesG20
{
    partial class FrmInformes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformes));
            this.lblInformes = new System.Windows.Forms.Label();
            this.lblExportar = new System.Windows.Forms.Label();
            this.btnInformeDesarrollo = new System.Windows.Forms.Button();
            this.btnInformeMilitar = new System.Windows.Forms.Button();
            this.btnContinenteDominante = new System.Windows.Forms.Button();
            this.btnInformeDensidad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInformes
            // 
            this.lblInformes.AutoSize = true;
            this.lblInformes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInformes.Font = new System.Drawing.Font("Segoe UI", 8.765218F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblInformes.Location = new System.Drawing.Point(12, 581);
            this.lblInformes.Name = "lblInformes";
            this.lblInformes.Size = new System.Drawing.Size(305, 20);
            this.lblInformes.TabIndex = 21;
            this.lblInformes.Text = "Seleccione el informe que desee visualizar:";
            // 
            // lblExportar
            // 
            this.lblExportar.AutoSize = true;
            this.lblExportar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblExportar.Font = new System.Drawing.Font("Segoe UI", 8.765218F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblExportar.Location = new System.Drawing.Point(789, 581);
            this.lblExportar.Name = "lblExportar";
            this.lblExportar.Size = new System.Drawing.Size(343, 20);
            this.lblExportar.TabIndex = 22;
            this.lblExportar.Text = "Exportar ultimo informe como archivo de texto:";
            // 
            // btnInformeDesarrollo
            // 
            this.btnInformeDesarrollo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnInformeDesarrollo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInformeDesarrollo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInformeDesarrollo.Location = new System.Drawing.Point(12, 620);
            this.btnInformeDesarrollo.Name = "btnInformeDesarrollo";
            this.btnInformeDesarrollo.Size = new System.Drawing.Size(132, 95);
            this.btnInformeDesarrollo.TabIndex = 23;
            this.btnInformeDesarrollo.Text = "Informe de Desarrollo Humano";
            this.btnInformeDesarrollo.UseVisualStyleBackColor = false;
            this.btnInformeDesarrollo.Click += new System.EventHandler(this.btnInformeDesarrollo_Click);
            // 
            // btnInformeMilitar
            // 
            this.btnInformeMilitar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnInformeMilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInformeMilitar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInformeMilitar.Location = new System.Drawing.Point(185, 620);
            this.btnInformeMilitar.Name = "btnInformeMilitar";
            this.btnInformeMilitar.Size = new System.Drawing.Size(132, 95);
            this.btnInformeMilitar.TabIndex = 24;
            this.btnInformeMilitar.Text = "Informe Militar";
            this.btnInformeMilitar.UseVisualStyleBackColor = false;
            this.btnInformeMilitar.Click += new System.EventHandler(this.btnInformeMilitar_Click);
            // 
            // btnContinenteDominante
            // 
            this.btnContinenteDominante.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnContinenteDominante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinenteDominante.Font = new System.Drawing.Font("Segoe UI Semibold", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContinenteDominante.Location = new System.Drawing.Point(530, 620);
            this.btnContinenteDominante.Name = "btnContinenteDominante";
            this.btnContinenteDominante.Size = new System.Drawing.Size(132, 95);
            this.btnContinenteDominante.TabIndex = 26;
            this.btnContinenteDominante.Text = "Informe de participacion Continental";
            this.btnContinenteDominante.UseVisualStyleBackColor = false;
            this.btnContinenteDominante.Click += new System.EventHandler(this.btnContinenteDominante_Click);
            // 
            // btnInformeDensidad
            // 
            this.btnInformeDensidad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnInformeDensidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInformeDensidad.Font = new System.Drawing.Font("Segoe UI Semibold", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInformeDensidad.Location = new System.Drawing.Point(357, 620);
            this.btnInformeDensidad.Name = "btnInformeDensidad";
            this.btnInformeDensidad.Size = new System.Drawing.Size(132, 95);
            this.btnInformeDensidad.TabIndex = 25;
            this.btnInformeDensidad.Text = "Informe de Densidad de Poblacion";
            this.btnInformeDensidad.UseVisualStyleBackColor = false;
            this.btnInformeDensidad.Click += new System.EventHandler(this.btnInformeDensidad_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(903, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 95);
            this.button1.TabIndex = 27;
            this.button1.Text = "Guardar Ultimo       Informe      (XML)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PaisesG20.Properties.Resources._2018_G20_logo_1140x6841;
            this.ClientSize = new System.Drawing.Size(1144, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnContinenteDominante);
            this.Controls.Add(this.btnInformeDensidad);
            this.Controls.Add(this.btnInformeMilitar);
            this.Controls.Add(this.btnInformeDesarrollo);
            this.Controls.Add(this.lblExportar);
            this.Controls.Add(this.lblInformes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInformes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformes;
        private System.Windows.Forms.Label lblExportar;
        private System.Windows.Forms.Button btnInformeDesarrollo;
        private System.Windows.Forms.Button btnInformeMilitar;
        private System.Windows.Forms.Button btnContinenteDominante;
        private System.Windows.Forms.Button btnInformeDensidad;
        private System.Windows.Forms.Button button1;
    }
}