namespace Ej1_queues_banco
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbBandejaClientes = new System.Windows.Forms.ListBox();
            this.lbBandejaCajas = new System.Windows.Forms.ListBox();
            this.lbBandejaCajasDivisa = new System.Windows.Forms.ListBox();
            this.btnTurno = new System.Windows.Forms.Button();
            this.cbTipoTramite = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtencionPuestoCajaDivisas = new System.Windows.Forms.Button();
            this.btnAtencionCaja = new System.Windows.Forms.Button();
            this.btnAtencionCliente = new System.Windows.Forms.Button();
            this.cbAtencionPuestosCajaDivisas = new System.Windows.Forms.ComboBox();
            this.cbAtencionPuestosCliente = new System.Windows.Forms.ComboBox();
            this.cbAtencionPuestosCaja = new System.Windows.Forms.ComboBox();
            this.lbTurnosEnAtención = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBandejaClientes
            // 
            this.lbBandejaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBandejaClientes.FormattingEnabled = true;
            this.lbBandejaClientes.ItemHeight = 20;
            this.lbBandejaClientes.Location = new System.Drawing.Point(6, 25);
            this.lbBandejaClientes.Name = "lbBandejaClientes";
            this.lbBandejaClientes.Size = new System.Drawing.Size(182, 164);
            this.lbBandejaClientes.TabIndex = 0;
            // 
            // lbBandejaCajas
            // 
            this.lbBandejaCajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBandejaCajas.FormattingEnabled = true;
            this.lbBandejaCajas.ItemHeight = 20;
            this.lbBandejaCajas.Location = new System.Drawing.Point(194, 25);
            this.lbBandejaCajas.Name = "lbBandejaCajas";
            this.lbBandejaCajas.Size = new System.Drawing.Size(181, 164);
            this.lbBandejaCajas.TabIndex = 1;
            // 
            // lbBandejaCajasDivisa
            // 
            this.lbBandejaCajasDivisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBandejaCajasDivisa.FormattingEnabled = true;
            this.lbBandejaCajasDivisa.ItemHeight = 20;
            this.lbBandejaCajasDivisa.Location = new System.Drawing.Point(381, 25);
            this.lbBandejaCajasDivisa.Name = "lbBandejaCajasDivisa";
            this.lbBandejaCajasDivisa.Size = new System.Drawing.Size(207, 164);
            this.lbBandejaCajasDivisa.TabIndex = 2;
            // 
            // btnTurno
            // 
            this.btnTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurno.Location = new System.Drawing.Point(464, 28);
            this.btnTurno.Name = "btnTurno";
            this.btnTurno.Size = new System.Drawing.Size(108, 57);
            this.btnTurno.TabIndex = 3;
            this.btnTurno.Text = "Solicitud Turno";
            this.btnTurno.UseVisualStyleBackColor = true;
            this.btnTurno.Click += new System.EventHandler(this.btnTurno_Click);
            // 
            // cbTipoTramite
            // 
            this.cbTipoTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoTramite.FormattingEnabled = true;
            this.cbTipoTramite.Items.AddRange(new object[] {
            "Prestamos",
            "Tarjetas",
            "Cuentas",
            "Plazo Fijo",
            "Pagos Cobros",
            "Compra Venta de Dolares"});
            this.cbTipoTramite.Location = new System.Drawing.Point(141, 43);
            this.cbTipoTramite.Name = "cbTipoTramite";
            this.cbTipoTramite.Size = new System.Drawing.Size(294, 28);
            this.cbTipoTramite.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbTipoTramite);
            this.groupBox1.Controls.Add(this.btnTurno);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 110);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo Tramite";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnAtencionPuestoCajaDivisas);
            this.groupBox2.Controls.Add(this.btnAtencionCaja);
            this.groupBox2.Controls.Add(this.btnAtencionCliente);
            this.groupBox2.Controls.Add(this.cbAtencionPuestosCajaDivisas);
            this.groupBox2.Controls.Add(this.cbAtencionPuestosCliente);
            this.groupBox2.Controls.Add(this.cbAtencionPuestosCaja);
            this.groupBox2.Controls.Add(this.lbBandejaClientes);
            this.groupBox2.Controls.Add(this.lbBandejaCajas);
            this.groupBox2.Controls.Add(this.lbBandejaCajasDivisa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 298);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bandejas de esperas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Atención Divisas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Atención Cajas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Atención Clientes";
            // 
            // btnAtencionPuestoCajaDivisas
            // 
            this.btnAtencionPuestoCajaDivisas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtencionPuestoCajaDivisas.Location = new System.Drawing.Point(434, 252);
            this.btnAtencionPuestoCajaDivisas.Name = "btnAtencionPuestoCajaDivisas";
            this.btnAtencionPuestoCajaDivisas.Size = new System.Drawing.Size(104, 40);
            this.btnAtencionPuestoCajaDivisas.TabIndex = 10;
            this.btnAtencionPuestoCajaDivisas.Text = "Atender";
            this.btnAtencionPuestoCajaDivisas.UseVisualStyleBackColor = true;
            this.btnAtencionPuestoCajaDivisas.Click += new System.EventHandler(this.btnAtencionPuestoCajaDivisas_Click);
            // 
            // btnAtencionCaja
            // 
            this.btnAtencionCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtencionCaja.Location = new System.Drawing.Point(234, 252);
            this.btnAtencionCaja.Name = "btnAtencionCaja";
            this.btnAtencionCaja.Size = new System.Drawing.Size(104, 40);
            this.btnAtencionCaja.TabIndex = 9;
            this.btnAtencionCaja.Text = "Atender";
            this.btnAtencionCaja.UseVisualStyleBackColor = true;
            this.btnAtencionCaja.Click += new System.EventHandler(this.btnAtencionCaja_Click);
            // 
            // btnAtencionCliente
            // 
            this.btnAtencionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtencionCliente.Location = new System.Drawing.Point(45, 252);
            this.btnAtencionCliente.Name = "btnAtencionCliente";
            this.btnAtencionCliente.Size = new System.Drawing.Size(104, 40);
            this.btnAtencionCliente.TabIndex = 8;
            this.btnAtencionCliente.Text = "Atender";
            this.btnAtencionCliente.UseVisualStyleBackColor = true;
            this.btnAtencionCliente.Click += new System.EventHandler(this.btnAtencionPuestoCliente_Click);
            // 
            // cbAtencionPuestosCajaDivisas
            // 
            this.cbAtencionPuestosCajaDivisas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtencionPuestosCajaDivisas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAtencionPuestosCajaDivisas.FormattingEnabled = true;
            this.cbAtencionPuestosCajaDivisas.Items.AddRange(new object[] {
            "Caja 1"});
            this.cbAtencionPuestosCajaDivisas.Location = new System.Drawing.Point(381, 218);
            this.cbAtencionPuestosCajaDivisas.Name = "cbAtencionPuestosCajaDivisas";
            this.cbAtencionPuestosCajaDivisas.Size = new System.Drawing.Size(207, 28);
            this.cbAtencionPuestosCajaDivisas.TabIndex = 7;
            // 
            // cbAtencionPuestosCliente
            // 
            this.cbAtencionPuestosCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtencionPuestosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAtencionPuestosCliente.FormattingEnabled = true;
            this.cbAtencionPuestosCliente.Items.AddRange(new object[] {
            "Puesto 1",
            "Puesto 2"});
            this.cbAtencionPuestosCliente.Location = new System.Drawing.Point(6, 218);
            this.cbAtencionPuestosCliente.Name = "cbAtencionPuestosCliente";
            this.cbAtencionPuestosCliente.Size = new System.Drawing.Size(182, 28);
            this.cbAtencionPuestosCliente.TabIndex = 6;
            // 
            // cbAtencionPuestosCaja
            // 
            this.cbAtencionPuestosCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtencionPuestosCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAtencionPuestosCaja.FormattingEnabled = true;
            this.cbAtencionPuestosCaja.Items.AddRange(new object[] {
            "Caja 2",
            "Caja 3"});
            this.cbAtencionPuestosCaja.Location = new System.Drawing.Point(194, 218);
            this.cbAtencionPuestosCaja.Name = "cbAtencionPuestosCaja";
            this.cbAtencionPuestosCaja.Size = new System.Drawing.Size(181, 28);
            this.cbAtencionPuestosCaja.TabIndex = 5;
            // 
            // lbTurnosEnAtención
            // 
            this.lbTurnosEnAtención.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTurnosEnAtención.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurnosEnAtención.FormattingEnabled = true;
            this.lbTurnosEnAtención.ItemHeight = 20;
            this.lbTurnosEnAtención.Location = new System.Drawing.Point(6, 24);
            this.lbTurnosEnAtención.Name = "lbTurnosEnAtención";
            this.lbTurnosEnAtención.Size = new System.Drawing.Size(343, 382);
            this.lbTurnosEnAtención.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbTurnosEnAtención);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(612, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 414);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Turnos en Atención";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 438);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrincipal";
            this.Text = "Atención al cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBandejaClientes;
        private System.Windows.Forms.ListBox lbBandejaCajas;
        private System.Windows.Forms.ListBox lbBandejaCajasDivisa;
        private System.Windows.Forms.Button btnTurno;
        private System.Windows.Forms.ComboBox cbTipoTramite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbAtencionPuestosCajaDivisas;
        private System.Windows.Forms.ComboBox cbAtencionPuestosCliente;
        private System.Windows.Forms.ComboBox cbAtencionPuestosCaja;
        private System.Windows.Forms.ListBox lbTurnosEnAtención;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAtencionPuestoCajaDivisas;
        private System.Windows.Forms.Button btnAtencionCaja;
        private System.Windows.Forms.Button btnAtencionCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

