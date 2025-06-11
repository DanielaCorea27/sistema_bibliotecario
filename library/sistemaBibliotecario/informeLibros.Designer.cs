namespace sistemaBibliotecario
{
    partial class informeLibros
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaBDFinalDataSet1 = new sistemaBibliotecario.bibliotecaBDFinalDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.libroTableAdapter = new sistemaBibliotecario.bibliotecaBDFinalDataSet1TableAdapters.LibroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaBDFinalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // libroBindingSource
            // 
            this.libroBindingSource.DataMember = "Libro";
            this.libroBindingSource.DataSource = this.bibliotecaBDFinalDataSet1;
            // 
            // bibliotecaBDFinalDataSet1
            // 
            this.bibliotecaBDFinalDataSet1.DataSetName = "bibliotecaBDFinalDataSet1";
            this.bibliotecaBDFinalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetLibros";
            reportDataSource1.Value = this.libroBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "sistemaBibliotecario.reporteLibros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // libroTableAdapter
            // 
            this.libroTableAdapter.ClearBeforeFill = true;
            // 
            // informeLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "informeLibros";
            this.Text = "Informe de Libros";
            this.Load += new System.EventHandler(this.informeLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaBDFinalDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private bibliotecaBDFinalDataSet1 bibliotecaBDFinalDataSet1;
        private System.Windows.Forms.BindingSource libroBindingSource;
        private bibliotecaBDFinalDataSet1TableAdapters.LibroTableAdapter libroTableAdapter;
    }
}