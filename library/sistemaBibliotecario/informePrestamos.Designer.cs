namespace sistemaBibliotecario
{
    partial class informePrestamos
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
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaBDFinalDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaBDFinalDataSet1 = new sistemaBibliotecario.bibliotecaBDFinalDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.prestamoTableAdapter = new sistemaBibliotecario.bibliotecaBDFinalDataSet1TableAdapters.PrestamoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaBDFinalDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaBDFinalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataMember = "Prestamo";
            this.prestamoBindingSource.DataSource = this.bibliotecaBDFinalDataSet1BindingSource;
            // 
            // bibliotecaBDFinalDataSet1BindingSource
            // 
            this.bibliotecaBDFinalDataSet1BindingSource.DataSource = this.bibliotecaBDFinalDataSet1;
            this.bibliotecaBDFinalDataSet1BindingSource.Position = 0;
            // 
            // bibliotecaBDFinalDataSet1
            // 
            this.bibliotecaBDFinalDataSet1.DataSetName = "bibliotecaBDFinalDataSet1";
            this.bibliotecaBDFinalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPrestamo";
            reportDataSource1.Value = this.prestamoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "sistemaBibliotecario.reportePrestamos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // prestamoTableAdapter
            // 
            this.prestamoTableAdapter.ClearBeforeFill = true;
            // 
            // informePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "informePrestamos";
            this.Text = "Informe de Prestamos";
            this.Load += new System.EventHandler(this.informePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaBDFinalDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaBDFinalDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private bibliotecaBDFinalDataSet1 bibliotecaBDFinalDataSet1;
        private System.Windows.Forms.BindingSource bibliotecaBDFinalDataSet1BindingSource;
        private System.Windows.Forms.BindingSource prestamoBindingSource;
        private bibliotecaBDFinalDataSet1TableAdapters.PrestamoTableAdapter prestamoTableAdapter;
    }
}