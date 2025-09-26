namespace SistemaMilitarPereira
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGenerarObjetivos = new System.Windows.Forms.Button();
            this.BtnLimpiarRadar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblObjetivoSeleccionado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCompatibilidad = new System.Windows.Forms.Label();
            this.BtnCambiarArma = new System.Windows.Forms.Button();
            this.BtnDisparar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblArmaActual = new System.Windows.Forms.Label();
            this.lblAlcanceArma = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RtxtBitacora = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjetivoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanciaObjetivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArmaUsada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanciaDisparo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acierto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 49);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Militar - Saraza S.A.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 433);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1050, 255);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.Controls.Add(this.BtnLimpiarRadar);
            this.panel2.Controls.Add(this.BtnGenerarObjetivos);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 384);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel3.Controls.Add(this.RtxtBitacora);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblAlcanceArma);
            this.panel3.Controls.Add(this.lblArmaActual);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(773, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 384);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel5.Controls.Add(this.BtnDisparar);
            this.panel5.Controls.Add(this.BtnCambiarArma);
            this.panel5.Controls.Add(this.lblCompatibilidad);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.lblObjetivoSeleccionado);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(317, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(456, 384);
            this.panel5.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Radar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Distancia,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(299, 210);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Distancia
            // 
            this.Distancia.HeaderText = "Distancia";
            this.Distancia.Name = "Distancia";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // BtnGenerarObjetivos
            // 
            this.BtnGenerarObjetivos.Location = new System.Drawing.Point(85, 285);
            this.BtnGenerarObjetivos.Name = "BtnGenerarObjetivos";
            this.BtnGenerarObjetivos.Size = new System.Drawing.Size(122, 31);
            this.BtnGenerarObjetivos.TabIndex = 3;
            this.BtnGenerarObjetivos.Text = "Generar Objetivos";
            this.BtnGenerarObjetivos.UseVisualStyleBackColor = true;
            this.BtnGenerarObjetivos.Click += new System.EventHandler(this.BtnGenerarObjetivos_Click);
            // 
            // BtnLimpiarRadar
            // 
            this.BtnLimpiarRadar.Location = new System.Drawing.Point(85, 322);
            this.BtnLimpiarRadar.Name = "BtnLimpiarRadar";
            this.BtnLimpiarRadar.Size = new System.Drawing.Size(122, 31);
            this.BtnLimpiarRadar.TabIndex = 4;
            this.BtnLimpiarRadar.Text = "Limpiar Radar";
            this.BtnLimpiarRadar.UseVisualStyleBackColor = true;
            this.BtnLimpiarRadar.Click += new System.EventHandler(this.BtnLimpiarRadar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Control";
            // 
            // lblObjetivoSeleccionado
            // 
            this.lblObjetivoSeleccionado.AutoSize = true;
            this.lblObjetivoSeleccionado.Location = new System.Drawing.Point(170, 45);
            this.lblObjetivoSeleccionado.Name = "lblObjetivoSeleccionado";
            this.lblObjetivoSeleccionado.Size = new System.Drawing.Size(10, 13);
            this.lblObjetivoSeleccionado.TabIndex = 6;
            this.lblObjetivoSeleccionado.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Control de Armas:";
            // 
            // lblCompatibilidad
            // 
            this.lblCompatibilidad.AutoSize = true;
            this.lblCompatibilidad.Location = new System.Drawing.Point(170, 213);
            this.lblCompatibilidad.Name = "lblCompatibilidad";
            this.lblCompatibilidad.Size = new System.Drawing.Size(10, 13);
            this.lblCompatibilidad.TabIndex = 8;
            this.lblCompatibilidad.Text = ":";
            // 
            // BtnCambiarArma
            // 
            this.BtnCambiarArma.Location = new System.Drawing.Point(173, 285);
            this.BtnCambiarArma.Name = "BtnCambiarArma";
            this.BtnCambiarArma.Size = new System.Drawing.Size(122, 31);
            this.BtnCambiarArma.TabIndex = 5;
            this.BtnCambiarArma.Text = "Cambiar Arma";
            this.BtnCambiarArma.UseVisualStyleBackColor = true;
            this.BtnCambiarArma.Click += new System.EventHandler(this.BtnCambiarArma_Click);
            // 
            // BtnDisparar
            // 
            this.BtnDisparar.Location = new System.Drawing.Point(173, 322);
            this.BtnDisparar.Name = "BtnDisparar";
            this.BtnDisparar.Size = new System.Drawing.Size(122, 31);
            this.BtnDisparar.TabIndex = 9;
            this.BtnDisparar.Text = "Disparar";
            this.BtnDisparar.UseVisualStyleBackColor = true;
            this.BtnDisparar.Click += new System.EventHandler(this.BtnDisparar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estado";
            // 
            // lblArmaActual
            // 
            this.lblArmaActual.AutoSize = true;
            this.lblArmaActual.Location = new System.Drawing.Point(32, 72);
            this.lblArmaActual.Name = "lblArmaActual";
            this.lblArmaActual.Size = new System.Drawing.Size(67, 13);
            this.lblArmaActual.TabIndex = 11;
            this.lblArmaActual.Text = "Arma Actual:";
            // 
            // lblAlcanceArma
            // 
            this.lblAlcanceArma.AutoSize = true;
            this.lblAlcanceArma.Location = new System.Drawing.Point(32, 95);
            this.lblAlcanceArma.Name = "lblAlcanceArma";
            this.lblAlcanceArma.Size = new System.Drawing.Size(49, 13);
            this.lblAlcanceArma.TabIndex = 13;
            this.lblAlcanceArma.Text = "Alcance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bitacora";
            // 
            // RtxtBitacora
            // 
            this.RtxtBitacora.BackColor = System.Drawing.SystemColors.InfoText;
            this.RtxtBitacora.Location = new System.Drawing.Point(6, 210);
            this.RtxtBitacora.Name = "RtxtBitacora";
            this.RtxtBitacora.Size = new System.Drawing.Size(268, 168);
            this.RtxtBitacora.TabIndex = 15;
            this.RtxtBitacora.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(496, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Historial";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaHora,
            this.ObjetivoId,
            this.DistanciaObjetivo,
            this.ArmaUsada,
            this.DistanciaDisparo,
            this.Acierto});
            this.dataGridView2.Location = new System.Drawing.Point(12, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1026, 206);
            this.dataGridView2.TabIndex = 11;
            // 
            // FechaHora
            // 
            this.FechaHora.HeaderText = "FechaHora";
            this.FechaHora.Name = "FechaHora";
            // 
            // ObjetivoId
            // 
            this.ObjetivoId.HeaderText = "ObjetivoId";
            this.ObjetivoId.Name = "ObjetivoId";
            // 
            // DistanciaObjetivo
            // 
            this.DistanciaObjetivo.HeaderText = "DistanciaObjetivo";
            this.DistanciaObjetivo.Name = "DistanciaObjetivo";
            // 
            // ArmaUsada
            // 
            this.ArmaUsada.HeaderText = "ArmaUsada";
            this.ArmaUsada.Name = "ArmaUsada";
            // 
            // DistanciaDisparo
            // 
            this.DistanciaDisparo.HeaderText = "DistanciaDisparo";
            this.DistanciaDisparo.Name = "DistanciaDisparo";
            // 
            // Acierto
            // 
            this.Acierto.HeaderText = "Acierto";
            this.Acierto.Name = "Acierto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 688);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnLimpiarRadar;
        private System.Windows.Forms.Button BtnGenerarObjetivos;
        private System.Windows.Forms.Label lblObjetivoSeleccionado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RtxtBitacora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAlcanceArma;
        private System.Windows.Forms.Label lblArmaActual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnDisparar;
        private System.Windows.Forms.Button BtnCambiarArma;
        private System.Windows.Forms.Label lblCompatibilidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjetivoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanciaObjetivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArmaUsada;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanciaDisparo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acierto;
        private System.Windows.Forms.Label label7;
    }
}

