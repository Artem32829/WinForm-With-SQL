namespace WindowsFormsApp1
{
    partial class Отчет_таблицы_Носитель
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
            this.НосительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ФильмыDataSet = new WindowsFormsApp1.ФильмыDataSet();
            this.НосительTableAdapter = new WindowsFormsApp1.ФильмыDataSetTableAdapters.НосительTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Отчеты = new WindowsFormsApp1.Отчеты();
            this.Отчет_НосительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Отчет_НосительTableAdapter = new WindowsFormsApp1.ОтчетыTableAdapters.Отчет_НосительTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.НосительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ФильмыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчеты)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_НосительBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // НосительBindingSource
            // 
            this.НосительBindingSource.DataMember = "Носитель";
            this.НосительBindingSource.DataSource = this.ФильмыDataSet;
            // 
            // ФильмыDataSet
            // 
            this.ФильмыDataSet.DataSetName = "ФильмыDataSet";
            this.ФильмыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // НосительTableAdapter
            // 
            this.НосительTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Носитель";
            reportDataSource1.Value = this.НосительBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Отчет_НосительBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Отчёт Носитель.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(63, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(680, 341);
            this.reportViewer1.TabIndex = 0;
            // 
            // Отчеты
            // 
            this.Отчеты.DataSetName = "Отчеты";
            this.Отчеты.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Отчет_НосительBindingSource
            // 
            this.Отчет_НосительBindingSource.DataMember = "Отчет Носитель";
            this.Отчет_НосительBindingSource.DataSource = this.Отчеты;
            // 
            // Отчет_НосительTableAdapter
            // 
            this.Отчет_НосительTableAdapter.ClearBeforeFill = true;
            // 
            // Отчет_таблицы_Носитель
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.color_cinema_icons_Mask_1320567857466645022;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Отчет_таблицы_Носитель";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет_таблицы_Носитель";
            this.Load += new System.EventHandler(this.Отчет_таблицы_Носитель_Load);
            ((System.ComponentModel.ISupportInitialize)(this.НосительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ФильмыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчеты)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_НосительBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource НосительBindingSource;
        private ФильмыDataSet ФильмыDataSet;
        private ФильмыDataSetTableAdapters.НосительTableAdapter НосительTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Отчет_НосительBindingSource;
        private Отчеты Отчеты;
        private ОтчетыTableAdapters.Отчет_НосительTableAdapter Отчет_НосительTableAdapter;
    }
}