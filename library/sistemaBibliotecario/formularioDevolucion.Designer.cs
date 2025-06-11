namespace sistemaBibliotecario
{
    partial class frmFormularioDevolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormularioDevolucion));
            this.lbNoEncontrar = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnHistorialDevoluciones = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCarnetL = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMostrarLibrosDevueltos = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarLibrosDevueltos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNoEncontrar
            // 
            this.lbNoEncontrar.AutoSize = true;
            this.lbNoEncontrar.BackColor = System.Drawing.Color.Bisque;
            this.lbNoEncontrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoEncontrar.ForeColor = System.Drawing.Color.DarkRed;
            this.lbNoEncontrar.Location = new System.Drawing.Point(621, 398);
            this.lbNoEncontrar.Name = "lbNoEncontrar";
            this.lbNoEncontrar.Size = new System.Drawing.Size(234, 22);
            this.lbNoEncontrar.TabIndex = 410;
            this.lbNoEncontrar.Text = "Mensaje de error No borrar";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.LemonChiffon;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Firebrick;
            this.label16.Location = new System.Drawing.Point(687, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(159, 23);
            this.label16.TabIndex = 409;
            this.label16.Text = "Editar Prestamo:";
            // 
            // btnHistorialDevoluciones
            // 
            this.btnHistorialDevoluciones.BackColor = System.Drawing.Color.Firebrick;
            this.btnHistorialDevoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialDevoluciones.ForeColor = System.Drawing.Color.White;
            this.btnHistorialDevoluciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialDevoluciones.Location = new System.Drawing.Point(329, 503);
            this.btnHistorialDevoluciones.Name = "btnHistorialDevoluciones";
            this.btnHistorialDevoluciones.Size = new System.Drawing.Size(129, 53);
            this.btnHistorialDevoluciones.TabIndex = 408;
            this.btnHistorialDevoluciones.Text = "Ver Historial Devoluciones";
            this.btnHistorialDevoluciones.UseVisualStyleBackColor = false;
            this.btnHistorialDevoluciones.Click += new System.EventHandler(this.btnHistorialDevoluciones_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LemonChiffon;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Firebrick;
            this.label15.Location = new System.Drawing.Point(163, 516);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 23);
            this.label15.TabIndex = 407;
            this.label15.Text = "DEVOLUCIONES:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(635, 168);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 406;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(504, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 23);
            this.label14.TabIndex = 405;
            this.label14.Text = "ID prestamo:";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEstado.Location = new System.Drawing.Point(720, 201);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 404;
            this.txtEstado.Text = "DEVUELTO";
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstado_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(640, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 23);
            this.label13.TabIndex = 403;
            this.label13.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(747, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 23);
            this.label7.TabIndex = 402;
            this.label7.Text = "Carnet usuario:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(316, 229);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(179, 150);
            this.txtObservacion.TabIndex = 401;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Firebrick;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(865, 236);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(111, 42);
            this.btnBuscar.TabIndex = 400;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(712, 241);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(134, 30);
            this.txtBusqueda.TabIndex = 399;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolucion.Location = new System.Drawing.Point(326, 202);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(100, 20);
            this.dtpDevolucion.TabIndex = 398;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(206, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 23);
            this.label10.TabIndex = 397;
            this.label10.Text = "ID del libro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(109, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 23);
            this.label9.TabIndex = 396;
            this.label9.Text = "Fecha de Devolución:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(329, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 37);
            this.btnCancelar.TabIndex = 395;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(509, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 23);
            this.label6.TabIndex = 394;
            this.label6.Text = "Buscar ID Prestatario:";
            // 
            // txtCarnetL
            // 
            this.txtCarnetL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCarnetL.Location = new System.Drawing.Point(326, 171);
            this.txtCarnetL.Name = "txtCarnetL";
            this.txtCarnetL.ReadOnly = true;
            this.txtCarnetL.Size = new System.Drawing.Size(100, 20);
            this.txtCarnetL.TabIndex = 393;
            this.txtCarnetL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarnetL_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Firebrick;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(187, 392);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 37);
            this.btnGuardar.TabIndex = 392;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ink Free", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(272, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(664, 37);
            this.label5.TabIndex = 391;
            this.label5.Text = "FORMULARIO DE DEVOLUCIÓN DE LIBROS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 390;
            this.label3.Text = "Observación:";
            // 
            // dgvMostrarLibrosDevueltos
            // 
            this.dgvMostrarLibrosDevueltos.AllowUserToResizeColumns = false;
            this.dgvMostrarLibrosDevueltos.AllowUserToResizeRows = false;
            this.dgvMostrarLibrosDevueltos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostrarLibrosDevueltos.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvMostrarLibrosDevueltos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarLibrosDevueltos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMostrarLibrosDevueltos.Location = new System.Drawing.Point(510, 284);
            this.dgvMostrarLibrosDevueltos.Name = "dgvMostrarLibrosDevueltos";
            this.dgvMostrarLibrosDevueltos.ReadOnly = true;
            this.dgvMostrarLibrosDevueltos.RowHeadersWidth = 51;
            this.dgvMostrarLibrosDevueltos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostrarLibrosDevueltos.Size = new System.Drawing.Size(466, 260);
            this.dgvMostrarLibrosDevueltos.TabIndex = 389;
            this.dgvMostrarLibrosDevueltos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarLibrosDevueltos_CellClick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Firebrick;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(76, 24);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(132, 41);
            this.btnRegresar.TabIndex = 388;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(214, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 23);
            this.label1.TabIndex = 387;
            this.label1.Text = "Información de Prestamo:";
            // 
            // txtCarnet
            // 
            this.txtCarnet.BackColor = System.Drawing.Color.White;
            this.txtCarnet.Location = new System.Drawing.Point(898, 169);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.ReadOnly = true;
            this.txtCarnet.Size = new System.Drawing.Size(100, 20);
            this.txtCarnet.TabIndex = 411;
            // 
            // frmFormularioDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 556);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.lbNoEncontrar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnHistorialDevoluciones);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dtpDevolucion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCarnetL);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMostrarLibrosDevueltos);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFormularioDevolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formularioDevolucion";
            this.Load += new System.EventHandler(this.frmFormularioDevolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarLibrosDevueltos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNoEncontrar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnHistorialDevoluciones;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCarnetL;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMostrarLibrosDevueltos;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCarnet;
    }
}