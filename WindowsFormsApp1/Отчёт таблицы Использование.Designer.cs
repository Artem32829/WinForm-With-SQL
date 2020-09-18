namespace WindowsFormsApp1
{
    partial class Отчёт_таблицы_Использование
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ИспользованиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ФильмыDataSet = new WindowsFormsApp1.ФильмыDataSet();
            this.ИспользованиеTableAdapter = new WindowsFormsApp1.ФильмыDataSetTableAdapters.ИспользованиеTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Отчеты = new WindowsFormsApp1.Отчеты();
            this.Отчет_ИспользованиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Отчет_ИспользованиеTableAdapter = new WindowsFormsApp1.ОтчетыTableAdapters.Отчет_ИспользованиеTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ИспользованиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ФильмыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчеты)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_ИспользованиеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ИспользованиеBindingSource
            // 
            this.ИспользованиеBindingSource.DataMember = "Использование";
            this.ИспользованиеBindingSource.DataSource = this.ФильмыDataSet;
            // 
            // ФильмыDataSet
            // 
            this.ФильмыDataSet.DataSetName = "ФильмыDataSet";
            this.ФильмыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ИспользованиеTableAdapter
            // 
            this.ИспользованиеTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Использование";
            reportDataSource1.Value = this.ИспользованиеBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Отчет_ИспользованиеBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Отчёт Использование.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(74, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(689, 366);
            this.reportViewer1.TabIndex = 0;
            // 
            // Отчеты
            // 
            this.Отчеты.DataSetName = "Отчеты";
            this.Отчеты.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Отчет_ИспользованиеBindingSource
            // 
            this.Отчет_ИспользованиеBindingSource.DataMember = "Отчет Использование";
            this.Отчет_ИспользованиеBindingSource.DataSource = this.Отчеты;
            // 
            // Отчет_ИспользованиеTableAdapter
            // 
            this.Отчет_ИспользованиеTableAdapter.ClearBeforeFill = true;
            // 
            // Отчёт_таблицы_Использование
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.color_cinema_icons_Mask_1320567857466645022;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Отчёт_таблицы_Использование";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт_таблицы_Использование";
            this.Load += new System.EventHandler(this.Отчёт_таблицы_Использование_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ИспользованиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ФильмыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчеты)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_ИспользованиеBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ИспользованиеBindingSource;
        private ФильмыDataSet ФильмыDataSet;
        private ФильмыDataSetTableAdapters.ИспользованиеTableAdapter ИспользованиеTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Отчет_ИспользованиеBindingSource;
        private Отчеты Отчеты;
        private ОтчетыTableAdapters.Отчет_ИспользованиеTableAdapter Отчет_ИспользованиеTableAdapter;
    }
}