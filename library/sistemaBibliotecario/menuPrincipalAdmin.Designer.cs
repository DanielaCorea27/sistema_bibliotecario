namespace sistemaBibliotecario
{
    partial class frmMenuPrincipalAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipalAdmin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fORMULARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fORMULARIOSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormulariosPrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormulariosDevolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hISTORIALESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistorialSolicitudesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistorialPrestamosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistorialDevolucionesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbNoEncontrar = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.rbAutor = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cbGeneroLibro = new System.Windows.Forms.ComboBox();
            this.dgvMostrarLibros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(43, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 201);
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Firebrick;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fORMULARIOSToolStripMenuItem,
            this.fORMULARIOSToolStripMenuItem1,
            this.hISTORIALESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(965, 34);
            this.menuStrip1.TabIndex = 84;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fORMULARIOSToolStripMenuItem
            // 
            this.fORMULARIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuariosToolStripMenuItem,
            this.menuLibrosToolStripMenuItem});
            this.fORMULARIOSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fORMULARIOSToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.fORMULARIOSToolStripMenuItem.Name = "fORMULARIOSToolStripMenuItem";
            this.fORMULARIOSToolStripMenuItem.Size = new System.Drawing.Size(155, 30);
            this.fORMULARIOSToolStripMenuItem.Text = "ADMINISTRAR";
            // 
            // menuUsuariosToolStripMenuItem
            // 
            this.menuUsuariosToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.menuUsuariosToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.menuUsuariosToolStripMenuItem.Name = "menuUsuariosToolStripMenuItem";
            this.menuUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.menuUsuariosToolStripMenuItem.Text = "USUARIOS";
            this.menuUsuariosToolStripMenuItem.Click += new System.EventHandler(this.menuUsuariosToolStripMenuItem_Click);
            // 
            // menuLibrosToolStripMenuItem
            // 
            this.menuLibrosToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.menuLibrosToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.menuLibrosToolStripMenuItem.Name = "menuLibrosToolStripMenuItem";
            this.menuLibrosToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.menuLibrosToolStripMenuItem.Text = "LIBROS";
            this.menuLibrosToolStripMenuItem.Click += new System.EventHandler(this.menuLibrosToolStripMenuItem_Click);
            // 
            // fORMULARIOSToolStripMenuItem1
            // 
            this.fORMULARIOSToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormulariosPrestamosToolStripMenuItem,
            this.menuFormulariosDevolucionesToolStripMenuItem});
            this.fORMULARIOSToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fORMULARIOSToolStripMenuItem1.ForeColor = System.Drawing.Color.Gold;
            this.fORMULARIOSToolStripMenuItem1.Name = "fORMULARIOSToolStripMenuItem1";
            this.fORMULARIOSToolStripMenuItem1.Size = new System.Drawing.Size(160, 30);
            this.fORMULARIOSToolStripMenuItem1.Text = "FORMULARIOS";
            // 
            // menuFormulariosPrestamosToolStripMenuItem
            // 
            this.menuFormulariosPrestamosToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.menuFormulariosPrestamosToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.menuFormulariosPrestamosToolStripMenuItem.Name = "menuFormulariosPrestamosToolStripMenuItem";
            this.menuFormulariosPrestamosToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.menuFormulariosPrestamosToolStripMenuItem.Text = "PRESTAMOS";
            this.menuFormulariosPrestamosToolStripMenuItem.Click += new System.EventHandler(this.menuFormulariosPrestamosToolStripMenuItem_Click);
            // 
            // menuFormulariosDevolucionesToolStripMenuItem
            // 
            this.menuFormulariosDevolucionesToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.menuFormulariosDevolucionesToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.menuFormulariosDevolucionesToolStripMenuItem.Name = "menuFormulariosDevolucionesToolStripMenuItem";
            this.menuFormulariosDevolucionesToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.menuFormulariosDevolucionesToolStripMenuItem.Text = "DEVOLUCIONES";
            this.menuFormulariosDevolucionesToolStripMenuItem.Click += new System.EventHandler(this.menuFormulariosDevolucionesToolStripMenuItem_Click);
            // 
            // hISTORIALESToolStripMenuItem
            // 
            this.hISTORIALESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHistorialSolicitudesToolStripMenuItem1,
            this.menuHistorialPrestamosToolStripMenuItem1,
            this.menuHistorialDevolucionesToolStripMenuItem2});
            this.hISTORIALESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hISTORIALESToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.hISTORIALESToolStripMenuItem.Name = "hISTORIALESToolStripMenuItem";
            this.hISTORIALESToolStripMenuItem.Size = new System.Drawing.Size(144, 30);
            this.hISTORIALESToolStripMenuItem.Text = "HISTORIALES";
            // 
            // menuHistorialSolicitudesToolStripMenuItem1
            // 
            this.menuHistorialSolicitudesToolStripMenuItem1.BackColor = System.Drawing.Color.Firebrick;
            this.menuHistorialSolicitudesToolStripMenuItem1.ForeColor = System.Drawing.Color.Gold;
            this.menuHistorialSolicitudesToolStripMenuItem1.Name = "menuHistorialSolicitudesToolStripMenuItem1";
            this.menuHistorialSolicitudesToolStripMenuItem1.Size = new System.Drawing.Size(326, 30);
            this.menuHistorialSolicitudesToolStripMenuItem1.Text = "SOLICITUDES PRESTAMOS";
            this.menuHistorialSolicitudesToolStripMenuItem1.Click += new System.EventHandler(this.menuHistorialSolicitudesToolStripMenuItem1_Click);
            // 
            // menuHistorialPrestamosToolStripMenuItem1
            // 
            this.menuHistorialPrestamosToolStripMenuItem1.BackColor = System.Drawing.Color.Firebrick;
            this.menuHistorialPrestamosToolStripMenuItem1.ForeColor = System.Drawing.Color.Gold;
            this.menuHistorialPrestamosToolStripMenuItem1.Name = "menuHistorialPrestamosToolStripMenuItem1";
            this.menuHistorialPrestamosToolStripMenuItem1.Size = new System.Drawing.Size(326, 30);
            this.menuHistorialPrestamosToolStripMenuItem1.Text = "PRESTAMOS";
            this.menuHistorialPrestamosToolStripMenuItem1.Click += new System.EventHandler(this.menuHistorialPrestamosToolStripMenuItem1_Click);
            // 
            // menuHistorialDevolucionesToolStripMenuItem2
            // 
            this.menuHistorialDevolucionesToolStripMenuItem2.BackColor = System.Drawing.Color.Firebrick;
            this.menuHistorialDevolucionesToolStripMenuItem2.ForeColor = System.Drawing.Color.Gold;
            this.menuHistorialDevolucionesToolStripMenuItem2.Name = "menuHistorialDevolucionesToolStripMenuItem2";
            this.menuHistorialDevolucionesToolStripMenuItem2.Size = new System.Drawing.Size(326, 30);
            this.menuHistorialDevolucionesToolStripMenuItem2.Text = "DEVOLUCIONES";
            this.menuHistorialDevolucionesToolStripMenuItem2.Click += new System.EventHandler(this.menuHistorialDevolucionesToolStripMenuItem2_Click);
            // 
            // lbNoEncontrar
            // 
            this.lbNoEncontrar.AutoSize = true;
            this.lbNoEncontrar.BackColor = System.Drawing.Color.Bisque;
            this.lbNoEncontrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoEncontrar.ForeColor = System.Drawing.Color.DarkRed;
            this.lbNoEncontrar.Location = new System.Drawing.Point(430, 351);
            this.lbNoEncontrar.Name = "lbNoEncontrar";
            this.lbNoEncontrar.Size = new System.Drawing.Size(234, 22);
            this.lbNoEncontrar.TabIndex = 83;
            this.lbNoEncontrar.Text = "Mensaje de error No borrar";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.Firebrick;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefrescar.Location = new System.Drawing.Point(646, 212);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(155, 32);
            this.btnRefrescar.TabIndex = 82;
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
            this.rbAutor.Location = new System.Drawing.Point(525, 212);
            this.rbAutor.Name = "rbAutor";
            this.rbAutor.Size = new System.Drawing.Size(92, 33);
            this.rbAutor.TabIndex = 81;
            this.rbAutor.TabStop = true;
            this.rbAutor.Text = "Autor";
            this.rbAutor.UseVisualStyleBackColor = false;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.BackColor = System.Drawing.Color.LemonChiffon;
            this.rbNombre.Checked = true;
            this.rbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNombre.ForeColor = System.Drawing.Color.Firebrick;
            this.rbNombre.Location = new System.Drawing.Point(411, 212);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(98, 33);
            this.rbNombre.TabIndex = 80;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Titulo";
            this.rbNombre.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Firebrick;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(65, 420);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 49);
            this.btnSalir.TabIndex = 79;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LemonChiffon;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(68, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 31);
            this.label5.TabIndex = 78;
            this.label5.Text = "Género:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(283, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 77;
            this.label2.Text = "Buscar:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(387, 166);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(303, 29);
            this.txtBusqueda.TabIndex = 76;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // cbGeneroLibro
            // 
            this.cbGeneroLibro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGeneroLibro.FormattingEnabled = true;
            this.cbGeneroLibro.Location = new System.Drawing.Point(43, 325);
            this.cbGeneroLibro.Name = "cbGeneroLibro";
            this.cbGeneroLibro.Size = new System.Drawing.Size(161, 29);
            this.cbGeneroLibro.TabIndex = 75;
            this.cbGeneroLibro.Text = "SELECCIONAR";
            this.cbGeneroLibro.SelectedIndexChanged += new System.EventHandler(this.cbGeneroLibro_SelectedIndexChanged);
            this.cbGeneroLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbGeneroLibro_KeyPress);
            // 
            // dgvMostrarLibros
            // 
            this.dgvMostrarLibros.AllowUserToAddRows = false;
            this.dgvMostrarLibros.AllowUserToDeleteRows = false;
            this.dgvMostrarLibros.AllowUserToResizeColumns = false;
            this.dgvMostrarLibros.AllowUserToResizeRows = false;
            this.dgvMostrarLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostrarLibros.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvMostrarLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarLibros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMostrarLibros.Location = new System.Drawing.Point(262, 260);
            this.dgvMostrarLibros.Name = "dgvMostrarLibros";
            this.dgvMostrarLibros.ReadOnly = true;
            this.dgvMostrarLibros.RowHeadersWidth = 51;
            this.dgvMostrarLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostrarLibros.Size = new System.Drawing.Size(552, 227);
            this.dgvMostrarLibros.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 43);
            this.label1.TabIndex = 73;
            this.label1.Text = "MyBook";
            // 
            // frmMenuPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 522);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbNoEncontrar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.rbAutor);
            this.Controls.Add(this.rbNombre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cbGeneroLibro);
            this.Controls.Add(this.dgvMostrarLibros);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuPrincipalAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuPrincipalAdmin";
            this.Load += new System.EventHandler(this.frmMenuPrincipalAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fORMULARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fORMULARIOSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuFormulariosPrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFormulariosDevolucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hISTORIALESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHistorialSolicitudesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuHistorialPrestamosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuHistorialDevolucionesToolStripMenuItem2;
        private System.Windows.Forms.Label lbNoEncontrar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.RadioButton rbAutor;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cbGeneroLibro;
        private System.Windows.Forms.DataGridView dgvMostrarLibros;
        private System.Windows.Forms.Label label1;
    }
}