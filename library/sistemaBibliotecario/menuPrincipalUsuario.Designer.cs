namespace sistemaBibliotecario
{
    partial class frmMenuPrincipalUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipalUsuario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNoEncontrar = new System.Windows.Forms.Label();
            this.lbNoEncontrado = new System.Windows.Forms.Label();
            this.dgvMostrarLibros = new System.Windows.Forms.DataGridView();
            this.btnReservarLibro = new System.Windows.Forms.Button();
            this.txtInfoAutor = new System.Windows.Forms.TextBox();
            this.txtInfoIsbn = new System.Windows.Forms.TextBox();
            this.txtInfoDisponibles = new System.Windows.Forms.TextBox();
            this.txtInfoGenero = new System.Windows.Forms.TextBox();
            this.txtInfoSaga = new System.Windows.Forms.TextBox();
            this.txtInfoEjemplares = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInfoNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.rbAutor = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cbGeneroLibro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(36, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 196);
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // lbNoEncontrar
            // 
            this.lbNoEncontrar.AutoSize = true;
            this.lbNoEncontrar.BackColor = System.Drawing.Color.Bisque;
            this.lbNoEncontrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoEncontrar.ForeColor = System.Drawing.Color.DarkRed;
            this.lbNoEncontrar.Location = new System.Drawing.Point(379, 369);
            this.lbNoEncontrar.Name = "lbNoEncontrar";
            this.lbNoEncontrar.Size = new System.Drawing.Size(234, 22);
            this.lbNoEncontrar.TabIndex = 98;
            this.lbNoEncontrar.Text = "Mensaje de error No borrar";
            // 
            // lbNoEncontrado
            // 
            this.lbNoEncontrado.AutoSize = true;
            this.lbNoEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoEncontrado.Location = new System.Drawing.Point(281, 233);
            this.lbNoEncontrado.Name = "lbNoEncontrado";
            this.lbNoEncontrado.Size = new System.Drawing.Size(0, 24);
            this.lbNoEncontrado.TabIndex = 97;
            // 
            // dgvMostrarLibros
            // 
            this.dgvMostrarLibros.AllowUserToAddRows = false;
            this.dgvMostrarLibros.AllowUserToDeleteRows = false;
            this.dgvMostrarLibros.AllowUserToResizeColumns = false;
            this.dgvMostrarLibros.AllowUserToResizeRows = false;
            this.dgvMostrarLibros.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvMostrarLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarLibros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMostrarLibros.Location = new System.Drawing.Point(219, 222);
            this.dgvMostrarLibros.Name = "dgvMostrarLibros";
            this.dgvMostrarLibros.ReadOnly = true;
            this.dgvMostrarLibros.RowHeadersWidth = 51;
            this.dgvMostrarLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostrarLibros.Size = new System.Drawing.Size(553, 310);
            this.dgvMostrarLibros.TabIndex = 96;
            this.dgvMostrarLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarLibros_CellClick);
            // 
            // btnReservarLibro
            // 
            this.btnReservarLibro.BackColor = System.Drawing.Color.Firebrick;
            this.btnReservarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservarLibro.ForeColor = System.Drawing.Color.White;
            this.btnReservarLibro.Location = new System.Drawing.Point(43, 369);
            this.btnReservarLibro.Name = "btnReservarLibro";
            this.btnReservarLibro.Size = new System.Drawing.Size(133, 51);
            this.btnReservarLibro.TabIndex = 95;
            this.btnReservarLibro.Text = "RESERVAR LIBRO";
            this.btnReservarLibro.UseVisualStyleBackColor = false;
            this.btnReservarLibro.Click += new System.EventHandler(this.btnReservarLibro_Click);
            // 
            // txtInfoAutor
            // 
            this.txtInfoAutor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoAutor.Location = new System.Drawing.Point(903, 221);
            this.txtInfoAutor.Name = "txtInfoAutor";
            this.txtInfoAutor.Size = new System.Drawing.Size(254, 30);
            this.txtInfoAutor.TabIndex = 94;
            // 
            // txtInfoIsbn
            // 
            this.txtInfoIsbn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoIsbn.Location = new System.Drawing.Point(903, 260);
            this.txtInfoIsbn.Name = "txtInfoIsbn";
            this.txtInfoIsbn.Size = new System.Drawing.Size(254, 30);
            this.txtInfoIsbn.TabIndex = 93;
            // 
            // txtInfoDisponibles
            // 
            this.txtInfoDisponibles.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoDisponibles.Location = new System.Drawing.Point(903, 416);
            this.txtInfoDisponibles.Name = "txtInfoDisponibles";
            this.txtInfoDisponibles.Size = new System.Drawing.Size(254, 30);
            this.txtInfoDisponibles.TabIndex = 92;
            // 
            // txtInfoGenero
            // 
            this.txtInfoGenero.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoGenero.Location = new System.Drawing.Point(903, 300);
            this.txtInfoGenero.Name = "txtInfoGenero";
            this.txtInfoGenero.Size = new System.Drawing.Size(254, 30);
            this.txtInfoGenero.TabIndex = 91;
            // 
            // txtInfoSaga
            // 
            this.txtInfoSaga.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoSaga.Location = new System.Drawing.Point(904, 337);
            this.txtInfoSaga.Name = "txtInfoSaga";
            this.txtInfoSaga.Size = new System.Drawing.Size(254, 30);
            this.txtInfoSaga.TabIndex = 90;
            // 
            // txtInfoEjemplares
            // 
            this.txtInfoEjemplares.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoEjemplares.Location = new System.Drawing.Point(903, 373);
            this.txtInfoEjemplares.Name = "txtInfoEjemplares";
            this.txtInfoEjemplares.Size = new System.Drawing.Size(254, 30);
            this.txtInfoEjemplares.TabIndex = 89;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LemonChiffon;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Firebrick;
            this.label12.Location = new System.Drawing.Point(800, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(333, 29);
            this.label12.TabIndex = 88;
            this.label12.Text = "INFORMACIÓN DEL LIBRO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(851, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 23);
            this.label11.TabIndex = 87;
            this.label11.Text = "ISBN:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(837, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 23);
            this.label10.TabIndex = 86;
            this.label10.Text = "SAGA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(829, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 23);
            this.label9.TabIndex = 85;
            this.label9.Text = "AUTOR:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(814, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 23);
            this.label8.TabIndex = 84;
            this.label8.Text = "GÉNERO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(781, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 23);
            this.label7.TabIndex = 83;
            this.label7.Text = "EJEMPLARES:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(778, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 23);
            this.label6.TabIndex = 82;
            this.label6.Text = "DISPONIBLES:";
            // 
            // txtInfoNombre
            // 
            this.txtInfoNombre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoNombre.Location = new System.Drawing.Point(903, 183);
            this.txtInfoNombre.Name = "txtInfoNombre";
            this.txtInfoNombre.Size = new System.Drawing.Size(254, 30);
            this.txtInfoNombre.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(812, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 80;
            this.label3.Text = "NOMBRE:";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.Firebrick;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefrescar.Location = new System.Drawing.Point(591, 180);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(154, 34);
            this.btnRefrescar.TabIndex = 79;
            this.btnRefrescar.Text = "REFRESCAR";
            this.btnRefrescar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // rbAutor
            // 
            this.rbAutor.AutoSize = true;
            this.rbAutor.BackColor = System.Drawing.Color.LemonChiffon;
            this.rbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAutor.ForeColor = System.Drawing.Color.Firebrick;
            this.rbAutor.Location = new System.Drawing.Point(444, 181);
            this.rbAutor.Name = "rbAutor";
            this.rbAutor.Size = new System.Drawing.Size(92, 33);
            this.rbAutor.TabIndex = 78;
            this.rbAutor.TabStop = true;
            this.rbAutor.Text = "Autor";
            this.rbAutor.UseVisualStyleBackColor = false;
            this.rbAutor.CheckedChanged += new System.EventHandler(this.rbAutor_CheckedChanged);
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.BackColor = System.Drawing.Color.LemonChiffon;
            this.rbNombre.Checked = true;
            this.rbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNombre.ForeColor = System.Drawing.Color.Firebrick;
            this.rbNombre.Location = new System.Drawing.Point(305, 183);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(98, 33);
            this.rbNombre.TabIndex = 77;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Titulo";
            this.rbNombre.UseVisualStyleBackColor = false;
            this.rbNombre.CheckedChanged += new System.EventHandler(this.rbNombre_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Firebrick;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(43, 439);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 40);
            this.btnSalir.TabIndex = 76;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LemonChiffon;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(66, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 26);
            this.label5.TabIndex = 75;
            this.label5.Text = "Género:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(277, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 74;
            this.label2.Text = "Buscar:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(383, 131);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(303, 29);
            this.txtBusqueda.TabIndex = 73;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // cbGeneroLibro
            // 
            this.cbGeneroLibro.DisplayMember = "genero";
            this.cbGeneroLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGeneroLibro.FormattingEnabled = true;
            this.cbGeneroLibro.Location = new System.Drawing.Point(22, 310);
            this.cbGeneroLibro.Name = "cbGeneroLibro";
            this.cbGeneroLibro.Size = new System.Drawing.Size(162, 32);
            this.cbGeneroLibro.TabIndex = 72;
            this.cbGeneroLibro.Text = "SELECCIONAR";
            this.cbGeneroLibro.ValueMember = "genero";
            this.cbGeneroLibro.SelectedIndexChanged += new System.EventHandler(this.cbGeneroLibro_SelectedIndexChanged);
            this.cbGeneroLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbGeneroLibro_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 43);
            this.label1.TabIndex = 71;
            this.label1.Text = "MyBook";
            // 
            // frmMenuPrincipalUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1169, 538);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNoEncontrar);
            this.Controls.Add(this.lbNoEncontrado);
            this.Controls.Add(this.dgvMostrarLibros);
            this.Controls.Add(this.btnReservarLibro);
            this.Controls.Add(this.txtInfoAutor);
            this.Controls.Add(this.txtInfoIsbn);
            this.Controls.Add(this.txtInfoDisponibles);
            this.Controls.Add(this.txtInfoGenero);
            this.Controls.Add(this.txtInfoSaga);
            this.Controls.Add(this.txtInfoEjemplares);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInfoNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.rbAutor);
            this.Controls.Add(this.rbNombre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cbGeneroLibro);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuPrincipalUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuPrincipalUsuario";
            this.Load += new System.EventHandler(this.frmMenuPrincipalUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNoEncontrar;
        private System.Windows.Forms.Label lbNoEncontrado;
        private System.Windows.Forms.DataGridView dgvMostrarLibros;
        private System.Windows.Forms.Button btnReservarLibro;
        private System.Windows.Forms.TextBox txtInfoAutor;
        private System.Windows.Forms.TextBox txtInfoIsbn;
        private System.Windows.Forms.TextBox txtInfoDisponibles;
        private System.Windows.Forms.TextBox txtInfoGenero;
        private System.Windows.Forms.TextBox txtInfoSaga;
        private System.Windows.Forms.TextBox txtInfoEjemplares;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInfoNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.RadioButton rbAutor;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cbGeneroLibro;
        private System.Windows.Forms.Label label1;
    }
}