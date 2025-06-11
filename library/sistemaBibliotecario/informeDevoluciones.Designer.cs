namespace sistemaBibliotecario
{
    partial class informeDevoluciones
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bibliotecaBDFinalDataSet1 = new sistemaBibliotecario.bibliotecaBDFinalDataSet1();
            this.devolucionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devolucionTableAdapter = new sistemaBibliotecario.bibliotecaBDFinalDataSet1TableAdapters.DevolucionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaBDFinalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "informes";
            reportDataSource1.Value = this.devolucionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "sistemaBibliotecario.reporteDevoluciones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // bibliotecaBDFinalDataSet1
            // 
            this.bibliotecaBDFinalDataSet1.DataSetName = "bibliotecaBDFinalDataSet1";
            this.bibliotecaBDFinalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devolucionBindingSource
            // 
            this.devolucionBindingSource.DataMember = "Devolucion";
            this.devolucionBindingSource.DataSource = this.bibliotecaBDFinalDataSet1;
            // 
            // devolucionTableAdapter
            // 
            this.devolucionTableAdapter.ClearBeforeFill = true;
            // 
            // informeDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "informeDevoluciones";
            this.Text = "informeDevoluciones";
            this.Load += new System.EventHandler(this.informeDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaBDFinalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private bibliotecaBDFinalDataSet1 bibliotecaBDFinalDataSet1;
        private System.Windows.Forms.BindingSource devolucionBindingSource;
        private bibliotecaBDFinalDataSet1TableAdapters.DevolucionTableAdapter devolucionTableAdapter;
    }
}