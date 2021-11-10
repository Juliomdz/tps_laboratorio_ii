
namespace PaisesG20
{
    partial class FrmAltaPais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaPais));
            this.cboxContinente = new System.Windows.Forms.ComboBox();
            this.cboxIdioma = new System.Windows.Forms.ComboBox();
            this.cboxIdh = new System.Windows.Forms.ComboBox();
            this.lblContinente = new System.Windows.Forms.Label();
            this.lblPoblacion = new System.Windows.Forms.Label();
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.btnAddPais = new System.Windows.Forms.Button();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblIdh = new System.Windows.Forms.Label();
            this.lblSuperficie = new System.Windows.Forms.Label();
            this.txtSuperficie = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.chbPotencia = new System.Windows.Forms.CheckBox();
            this.btnJson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxContinente
            // 
            this.cboxContinente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxContinente.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboxContinente.FormattingEnabled = true;
            this.cboxContinente.Location = new System.Drawing.Point(484, 352);
            this.cboxContinente.Name = "cboxContinente";
            this.cboxContinente.Size = new System.Drawing.Size(145, 27);
            this.cboxContinente.TabIndex = 0;
            // 
            // cboxIdioma
            // 
            this.cboxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxIdioma.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboxIdioma.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboxIdioma.FormattingEnabled = true;
            this.cboxIdioma.Location = new System.Drawing.Point(37, 352);
            this.cboxIdioma.Name = "cboxIdioma";
            this.cboxIdioma.Size = new System.Drawing.Size(145, 27);
            this.cboxIdioma.TabIndex = 1;
            // 
            // cboxIdh
            // 
            this.cboxIdh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxIdh.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboxIdh.FormattingEnabled = true;
            this.cboxIdh.Location = new System.Drawing.Point(263, 352);
            this.cboxIdh.Name = "cboxIdh";
            this.cboxIdh.Size = new System.Drawing.Size(145, 27);
            this.cboxIdh.TabIndex = 2;
            // 
            // lblContinente
            // 
            this.lblContinente.AutoSize = true;
            this.lblContinente.BackColor = System.Drawing.SystemColors.Window;
            this.lblContinente.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContinente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblContinente.Location = new System.Drawing.Point(484, 313);
            this.lblContinente.Name = "lblContinente";
            this.lblContinente.Size = new System.Drawing.Size(77, 20);
            this.lblContinente.TabIndex = 3;
            this.lblContinente.Text = "Contiente";
            // 
            // lblPoblacion
            // 
            this.lblPoblacion.AutoSize = true;
            this.lblPoblacion.BackColor = System.Drawing.SystemColors.Window;
            this.lblPoblacion.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPoblacion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblPoblacion.Location = new System.Drawing.Point(263, 238);
            this.lblPoblacion.Name = "lblPoblacion";
            this.lblPoblacion.Size = new System.Drawing.Size(77, 20);
            this.lblPoblacion.TabIndex = 4;
            this.lblPoblacion.Text = "Poblacion";
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Location = new System.Drawing.Point(263, 268);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(120, 26);
            this.txtPoblacion.TabIndex = 5;
            // 
            // btnAddPais
            // 
            this.btnAddPais.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddPais.Location = new System.Drawing.Point(682, 313);
            this.btnAddPais.Name = "btnAddPais";
            this.btnAddPais.Size = new System.Drawing.Size(140, 66);
            this.btnAddPais.TabIndex = 6;
            this.btnAddPais.Text = "Agregar";
            this.btnAddPais.UseVisualStyleBackColor = true;
            this.btnAddPais.Click += new System.EventHandler(this.btnAddPais_Click);
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.BackColor = System.Drawing.SystemColors.Window;
            this.lblIdioma.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdioma.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblIdioma.Location = new System.Drawing.Point(37, 313);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(58, 20);
            this.lblIdioma.TabIndex = 7;
            this.lblIdioma.Text = "Idioma";
            // 
            // lblIdh
            // 
            this.lblIdh.AutoSize = true;
            this.lblIdh.BackColor = System.Drawing.SystemColors.Window;
            this.lblIdh.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdh.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblIdh.Location = new System.Drawing.Point(263, 313);
            this.lblIdh.Name = "lblIdh";
            this.lblIdh.Size = new System.Drawing.Size(191, 20);
            this.lblIdh.TabIndex = 8;
            this.lblIdh.Text = "Indice Desarrollo Humano";
            // 
            // lblSuperficie
            // 
            this.lblSuperficie.AutoSize = true;
            this.lblSuperficie.BackColor = System.Drawing.SystemColors.Window;
            this.lblSuperficie.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSuperficie.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblSuperficie.Location = new System.Drawing.Point(484, 238);
            this.lblSuperficie.Name = "lblSuperficie";
            this.lblSuperficie.Size = new System.Drawing.Size(136, 20);
            this.lblSuperficie.TabIndex = 9;
            this.lblSuperficie.Text = "Superficie (km^2)";
            // 
            // txtSuperficie
            // 
            this.txtSuperficie.Location = new System.Drawing.Point(484, 268);
            this.txtSuperficie.Name = "txtSuperficie";
            this.txtSuperficie.Size = new System.Drawing.Size(120, 26);
            this.txtSuperficie.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(37, 268);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre del pais";
            this.txtNombre.Size = new System.Drawing.Size(120, 26);
            this.txtNombre.TabIndex = 11;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.Window;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblNombre.Location = new System.Drawing.Point(37, 238);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 20);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.BackColor = System.Drawing.SystemColors.Window;
            this.lblPotencia.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPotencia.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblPotencia.Location = new System.Drawing.Point(678, 238);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(152, 20);
            this.lblPotencia.TabIndex = 13;
            this.lblPotencia.Text = "¿Es Potencia Militar?";
            // 
            // chbPotencia
            // 
            this.chbPotencia.AutoSize = true;
            this.chbPotencia.BackColor = System.Drawing.SystemColors.Window;
            this.chbPotencia.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbPotencia.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.chbPotencia.Location = new System.Drawing.Point(731, 268);
            this.chbPotencia.Name = "chbPotencia";
            this.chbPotencia.Size = new System.Drawing.Size(41, 24);
            this.chbPotencia.TabIndex = 15;
            this.chbPotencia.Text = "SI";
            this.chbPotencia.UseVisualStyleBackColor = false;
            // 
            // btnJson
            // 
            this.btnJson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnJson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnJson.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnJson.Font = new System.Drawing.Font("Segoe UI", 8.765218F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnJson.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnJson.Location = new System.Drawing.Point(682, 404);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(140, 28);
            this.btnJson.TabIndex = 16;
            this.btnJson.Text = "Exportar a Json";
            this.btnJson.UseVisualStyleBackColor = false;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // FrmAltaPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PaisesG20.Properties.Resources.logoSmall1;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.btnJson);
            this.Controls.Add(this.chbPotencia);
            this.Controls.Add(this.lblPotencia);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtSuperficie);
            this.Controls.Add(this.lblSuperficie);
            this.Controls.Add(this.lblIdh);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.btnAddPais);
            this.Controls.Add(this.txtPoblacion);
            this.Controls.Add(this.lblPoblacion);
            this.Controls.Add(this.lblContinente);
            this.Controls.Add(this.cboxIdh);
            this.Controls.Add(this.cboxIdioma);
            this.Controls.Add(this.cboxContinente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAltaPais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "G20 Alta Pais";
            this.Load += new System.EventHandler(this.FrmAltaPais_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxContinente;
        private System.Windows.Forms.ComboBox cboxIdioma;
        private System.Windows.Forms.ComboBox cboxIdh;
        private System.Windows.Forms.Label lblContinente;
        private System.Windows.Forms.Label lblPoblacion;
        private System.Windows.Forms.TextBox txtPoblacion;
        private System.Windows.Forms.Button btnAddPais;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblIdh;
        private System.Windows.Forms.Label lblSuperficie;
        private System.Windows.Forms.TextBox txtSuperficie;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.CheckBox chbPotencia;
        private System.Windows.Forms.Button btnJson;
    }
}