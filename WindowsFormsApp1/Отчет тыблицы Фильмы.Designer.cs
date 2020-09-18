namespace WindowsFormsApp1
{
    partial class Отчет_тыблицы_Фильмы
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
            this.ФильмыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ФильмыDataSet = new WindowsFormsApp1.ФильмыDataSet();
            this.ФильмыTableAdapter = new WindowsFormsApp1.ФильмыDataSetTableAdapters.ФильмыTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Отчеты = new WindowsFormsApp1.Отчеты();
            this.Отчет_ФильмыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Отчет_ФильмыTableAdapter = new WindowsFormsApp1.ОтчетыTableAdapters.Отчет_ФильмыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ФильмыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ФильмыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчеты)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_ФильмыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ФильмыBindingSource
            // 
            this.ФильмыBindingSource.DataMember = "Фильмы";
            this.ФильмыBindingSource.DataSource = this.ФильмыDataSet;
            // 
            // ФильмыDataSet
            // 
            this.ФильмыDataSet.DataSetName = "ФильмыDataSet";
            this.ФильмыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ФильмыTableAdapter
            // 
            this.ФильмыTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Фильмы";
            reportDataSource1.Value = this.ФильмыBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Отчет_ФильмыBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Отчёт Фильмы.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(59, 36);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(668, 353);
            this.reportViewer1.TabIndex = 0;
            // 
            // Отчеты
            // 
            this.Отчеты.DataSetName = "Отчеты";
            this.Отчеты.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Отчет_ФильмыBindingSource
            // 
            this.Отчет_ФильмыBindingSource.DataMember = "Отчет Фильмы";
            this.Отчет_ФильмыBindingSource.DataSource = this.Отчеты;
            // 
            // Отчет_ФильмыTableAdapter
            // 
            this.Отчет_ФильмыTableAdapter.ClearBeforeFill = true;
            // 
            // Отчет_тыблицы_Фильмы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.color_cinema_icons_Mask_1320567857466645022;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Отчет_тыблицы_Фильмы";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет_тыблицы_Фильмы";
            this.Load += new System.EventHandler(this.Отчет_тыблицы_Фильмы_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ФильмыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ФильмыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчеты)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_ФильмыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ФильмыBindingSource;
        private ФильмыDataSet ФильмыDataSet;
        private ФильмыDataSetTableAdapters.ФильмыTableAdapter ФильмыTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Отчет_ФильмыBindingSource;
        private Отчеты Отчеты;
        private ОтчетыTableAdapters.Отчет_ФильмыTableAdapter Отчет_ФильмыTableAdapter;
    }
}