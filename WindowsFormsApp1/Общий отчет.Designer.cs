namespace WindowsFormsApp1
{
    partial class Общий_отчет
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
            this.Общий_отчетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ФильмыDataSet1 = new WindowsFormsApp1.ФильмыDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Общий_отчетTableAdapter = new WindowsFormsApp1.ФильмыDataSet1TableAdapters.Общий_отчетTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Общий_отчетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ФильмыDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Общий_отчетBindingSource
            // 
            this.Общий_отчетBindingSource.DataMember = "Общий отчет";
            this.Общий_отчетBindingSource.DataSource = this.ФильмыDataSet1;
            // 
            // ФильмыDataSet1
            // 
            this.ФильмыDataSet1.DataSetName = "ФильмыDataSet1";
            this.ФильмыDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ОбщОтчет";
            reportDataSource1.Value = this.Общий_отчетBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Общий отчет.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 23);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 393);
            this.reportViewer1.TabIndex = 0;
            // 
            // Общий_отчетTableAdapter
            // 
            this.Общий_отчетTableAdapter.ClearBeforeFill = true;
            // 
            // Общий_отчет
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.color_cinema_icons_Mask_1320567857466645022;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Общий_отчет";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Общий_отчет";
            this.Load += new System.EventHandler(this.Общий_отчет_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Общий_отчетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ФильмыDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Общий_отчетBindingSource;
        private ФильмыDataSet1 ФильмыDataSet1;
        private ФильмыDataSet1TableAdapters.Общий_отчетTableAdapter Общий_отчетTableAdapter;
    }
}