namespace Ej2_queues_farmacia
{
    partial class FormPrincipal
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
            this.bAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBdni = new System.Windows.Forms.TextBox();
            this.gBobra = new System.Windows.Forms.GroupBox();
            this.tBnro = new System.Windows.Forms.TextBox();
            this.rBno = new System.Windows.Forms.RadioButton();
            this.rBsi = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gBobra.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(165, 12);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 78);
            this.bAgregar.TabIndex = 0;
            this.bAgregar.Text = "Ticket";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Atender";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dni";
            // 
            // tBdni
            // 
            this.tBdni.Location = new System.Drawing.Point(52, 6);
            this.tBdni.Name = "tBdni";
            this.tBdni.Size = new System.Drawing.Size(94, 20);
            this.tBdni.TabIndex = 3;
            // 
            // gBobra
            // 
            this.gBobra.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gBobra.Controls.Add(this.tBnro);
            this.gBobra.Controls.Add(this.rBno);
            this.gBobra.Controls.Add(this.rBsi);
            this.gBobra.Location = new System.Drawing.Point(26, 32);
            this.gBobra.Name = "gBobra";
            this.gBobra.Size = new System.Drawing.Size(120, 58);
            this.gBobra.TabIndex = 4;
            this.gBobra.TabStop = false;
            this.gBobra.Text = "Obra Social";
            // 
            // tBnro
            // 
            this.tBnro.Location = new System.Drawing.Point(57, 15);
            this.tBnro.Name = "tBnro";
            this.tBnro.Size = new System.Drawing.Size(57, 20);
            this.tBnro.TabIndex = 2;
            // 
            // rBno
            // 
            this.rBno.AutoSize = true;
            this.rBno.Location = new System.Drawing.Point(3, 36);
            this.rBno.Name = "rBno";
            this.rBno.Size = new System.Drawing.Size(39, 17);
            this.rBno.TabIndex = 1;
            this.rBno.TabStop = true;
            this.rBno.Text = "No";
            this.rBno.UseVisualStyleBackColor = true;
            // 
            // rBsi
            // 
            this.rBsi.AutoSize = true;
            this.rBsi.Location = new System.Drawing.Point(3, 16);
            this.rBsi.Name = "rBsi";
            this.rBsi.Size = new System.Drawing.Size(34, 17);
            this.rBsi.TabIndex = 0;
            this.rBsi.TabStop = true;
            this.rBsi.Text = "Si";
            this.rBsi.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(107, 95);
            this.listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(135, 124);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(105, 95);
            this.listBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Atender";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Con obra social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sin obra social";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 256);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gBobra);
            this.Controls.Add(this.tBdni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincipal";
            this.Text = "Turnero Farmacia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.gBobra.ResumeLayout(false);
            this.gBobra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBdni;
        private System.Windows.Forms.GroupBox gBobra;
        private System.Windows.Forms.TextBox tBnro;
        private System.Windows.Forms.RadioButton rBno;
        private System.Windows.Forms.RadioButton rBsi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

