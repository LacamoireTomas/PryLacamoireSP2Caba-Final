namespace PryLacamoireSP2Cabaña
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mrcTipoCabaña = new System.Windows.Forms.GroupBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lstPersonas = new System.Windows.Forms.ComboBox();
            this.lstTipo = new System.Windows.Forms.ComboBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.mrcAdicionales = new System.Windows.Forms.GroupBox();
            this.chkTelevisor = new System.Windows.Forms.CheckBox();
            this.chkHeladera = new System.Windows.Forms.CheckBox();
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.mrcFormaDePago = new System.Windows.Forms.GroupBox();
            this.lblTarjetas = new System.Windows.Forms.Label();
            this.lstTarjetas = new System.Windows.Forms.ComboBox();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.mrcTitularReserva = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.mrcTipoCabaña.SuspendLayout();
            this.mrcAdicionales.SuspendLayout();
            this.mrcFormaDePago.SuspendLayout();
            this.mrcTitularReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcTipoCabaña
            // 
            this.mrcTipoCabaña.Controls.Add(this.txtDias);
            this.mrcTipoCabaña.Controls.Add(this.lstPersonas);
            this.mrcTipoCabaña.Controls.Add(this.lstTipo);
            this.mrcTipoCabaña.Controls.Add(this.lblDias);
            this.mrcTipoCabaña.Controls.Add(this.lblPersonas);
            this.mrcTipoCabaña.Controls.Add(this.lblTipo);
            this.mrcTipoCabaña.Location = new System.Drawing.Point(55, 35);
            this.mrcTipoCabaña.Name = "mrcTipoCabaña";
            this.mrcTipoCabaña.Size = new System.Drawing.Size(599, 84);
            this.mrcTipoCabaña.TabIndex = 0;
            this.mrcTipoCabaña.TabStop = false;
            this.mrcTipoCabaña.Text = "Tipo de Cabaña";
            this.mrcTipoCabaña.Enter += new System.EventHandler(this.mrcTipoCabaña_Enter);
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(492, 37);
            this.txtDias.MaxLength = 3;
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(66, 20);
            this.txtDias.TabIndex = 5;
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            this.txtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDias_KeyPress);
            // 
            // lstPersonas
            // 
            this.lstPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstPersonas.FormattingEnabled = true;
            this.lstPersonas.Location = new System.Drawing.Point(280, 37);
            this.lstPersonas.Name = "lstPersonas";
            this.lstPersonas.Size = new System.Drawing.Size(121, 21);
            this.lstPersonas.TabIndex = 4;
            // 
            // lstTipo
            // 
            this.lstTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTipo.FormattingEnabled = true;
            this.lstTipo.Items.AddRange(new object[] {
            "A",
            "B"});
            this.lstTipo.Location = new System.Drawing.Point(70, 37);
            this.lstTipo.Name = "lstTipo";
            this.lstTipo.Size = new System.Drawing.Size(121, 21);
            this.lstTipo.TabIndex = 3;
            this.lstTipo.SelectedIndexChanged += new System.EventHandler(this.lstTipo_SelectedIndexChanged);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(456, 40);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(30, 13);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "Días";
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Location = new System.Drawing.Point(223, 40);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(51, 13);
            this.lblPersonas.TabIndex = 1;
            this.lblPersonas.Text = "Personas";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(36, 40);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo";
            // 
            // mrcAdicionales
            // 
            this.mrcAdicionales.Controls.Add(this.chkTelevisor);
            this.mrcAdicionales.Controls.Add(this.chkHeladera);
            this.mrcAdicionales.Controls.Add(this.chkCocina);
            this.mrcAdicionales.Location = new System.Drawing.Point(55, 147);
            this.mrcAdicionales.Name = "mrcAdicionales";
            this.mrcAdicionales.Size = new System.Drawing.Size(155, 129);
            this.mrcAdicionales.TabIndex = 1;
            this.mrcAdicionales.TabStop = false;
            this.mrcAdicionales.Text = "Adicionales";
            // 
            // chkTelevisor
            // 
            this.chkTelevisor.AutoSize = true;
            this.chkTelevisor.Location = new System.Drawing.Point(15, 82);
            this.chkTelevisor.Name = "chkTelevisor";
            this.chkTelevisor.Size = new System.Drawing.Size(69, 17);
            this.chkTelevisor.TabIndex = 2;
            this.chkTelevisor.Text = "Televisor";
            this.chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            this.chkHeladera.AutoSize = true;
            this.chkHeladera.Location = new System.Drawing.Point(15, 59);
            this.chkHeladera.Name = "chkHeladera";
            this.chkHeladera.Size = new System.Drawing.Size(69, 17);
            this.chkHeladera.TabIndex = 1;
            this.chkHeladera.Text = "Heladera";
            this.chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(15, 36);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(59, 17);
            this.chkCocina.TabIndex = 0;
            this.chkCocina.Text = "Cocina";
            this.chkCocina.UseVisualStyleBackColor = true;
            this.chkCocina.CheckedChanged += new System.EventHandler(this.chkCocina_CheckedChanged);
            // 
            // mrcFormaDePago
            // 
            this.mrcFormaDePago.Controls.Add(this.lblTarjetas);
            this.mrcFormaDePago.Controls.Add(this.lstTarjetas);
            this.mrcFormaDePago.Controls.Add(this.rbTarjeta);
            this.mrcFormaDePago.Controls.Add(this.rbEfectivo);
            this.mrcFormaDePago.Location = new System.Drawing.Point(252, 147);
            this.mrcFormaDePago.Name = "mrcFormaDePago";
            this.mrcFormaDePago.Size = new System.Drawing.Size(402, 129);
            this.mrcFormaDePago.TabIndex = 2;
            this.mrcFormaDePago.TabStop = false;
            this.mrcFormaDePago.Text = "Forma de Pago";
            // 
            // lblTarjetas
            // 
            this.lblTarjetas.AutoSize = true;
            this.lblTarjetas.Location = new System.Drawing.Point(26, 63);
            this.lblTarjetas.Name = "lblTarjetas";
            this.lblTarjetas.Size = new System.Drawing.Size(45, 13);
            this.lblTarjetas.TabIndex = 3;
            this.lblTarjetas.Text = "Tarjetas";
            // 
            // lstTarjetas
            // 
            this.lstTarjetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTarjetas.FormattingEnabled = true;
            this.lstTarjetas.Location = new System.Drawing.Point(29, 82);
            this.lstTarjetas.Name = "lstTarjetas";
            this.lstTarjetas.Size = new System.Drawing.Size(214, 21);
            this.lstTarjetas.TabIndex = 2;
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Location = new System.Drawing.Point(130, 36);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(58, 17);
            this.rbTarjeta.TabIndex = 1;
            this.rbTarjeta.TabStop = true;
            this.rbTarjeta.Text = "Tarjeta";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            this.rbTarjeta.CheckedChanged += new System.EventHandler(this.rbTarjeta_CheckedChanged);
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Location = new System.Drawing.Point(29, 36);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rbEfectivo.TabIndex = 0;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            this.rbEfectivo.CheckedChanged += new System.EventHandler(this.rbEfectivo_CheckedChanged);
            // 
            // mrcTitularReserva
            // 
            this.mrcTitularReserva.Controls.Add(this.txtTelefono);
            this.mrcTitularReserva.Controls.Add(this.txtNombre);
            this.mrcTitularReserva.Controls.Add(this.lblTelefono);
            this.mrcTitularReserva.Controls.Add(this.lblNombre);
            this.mrcTitularReserva.Location = new System.Drawing.Point(55, 282);
            this.mrcTitularReserva.Name = "mrcTitularReserva";
            this.mrcTitularReserva.Size = new System.Drawing.Size(599, 113);
            this.mrcTitularReserva.TabIndex = 3;
            this.mrcTitularReserva.TabStop = false;
            this.mrcTitularReserva.Text = "Titular de la Reserva";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(156, 68);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(355, 20);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(156, 28);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(355, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(20, 68);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(281, 412);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(75, 23);
            this.cmdAceptar.TabIndex = 4;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 459);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.mrcTitularReserva);
            this.Controls.Add(this.mrcFormaDePago);
            this.Controls.Add(this.mrcAdicionales);
            this.Controls.Add(this.mrcTipoCabaña);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva Cabañas";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mrcTipoCabaña.ResumeLayout(false);
            this.mrcTipoCabaña.PerformLayout();
            this.mrcAdicionales.ResumeLayout(false);
            this.mrcAdicionales.PerformLayout();
            this.mrcFormaDePago.ResumeLayout(false);
            this.mrcFormaDePago.PerformLayout();
            this.mrcTitularReserva.ResumeLayout(false);
            this.mrcTitularReserva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcTipoCabaña;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.ComboBox lstPersonas;
        private System.Windows.Forms.ComboBox lstTipo;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox mrcAdicionales;
        private System.Windows.Forms.CheckBox chkTelevisor;
        private System.Windows.Forms.CheckBox chkHeladera;
        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.GroupBox mrcFormaDePago;
        private System.Windows.Forms.Label lblTarjetas;
        private System.Windows.Forms.ComboBox lstTarjetas;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.GroupBox mrcTitularReserva;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button cmdAceptar;
    }
}

