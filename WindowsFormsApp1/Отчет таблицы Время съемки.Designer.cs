﻿namespace WindowsFormsApp1
{
    partial class Отчет_таблицы_Время_съемки
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
            this.Время_съемкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ФильмыDataSet = new WindowsFormsApp1.ФильмыDataSet();
            this.Время_съемкиTableAdapter = new WindowsFormsApp1.ФильмыDataSetTableAdapters.Время_съемкиTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Отчеты = new WindowsFormsApp1.Отчеты();
            this.Отчет_Время_съемкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Отчет_Время_съемкиTableAdapter = new WindowsFormsApp1.ОтчетыTableAdapters.Отчет_Время_съемкиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Время_съемкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ФильмыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчеты)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_Время_съемкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Время_съемкиBindingSource
            // 
            this.Время_съемкиBindingSource.DataMember = "Время съемки";
            this.Время_съемкиBindingSource.DataSource = this.ФильмыDataSet;
            // 
            // ФильмыDataSet
            // 
            this.ФильмыDataSet.DataSetName = "ФильмыDataSet";
            this.ФильмыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Время_съемкиTableAdapter
            // 
            this.Время_съемкиTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Время_съемки";
            reportDataSource1.Value = this.Время_съемкиBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Отчет_Время_съемкиBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Отчёт Время съемки.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(39, 27);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(725, 367);
            this.reportViewer1.TabIndex = 0;
            // 
            // Отчеты
            // 
            this.Отчеты.DataSetName = "Отчеты";
            this.Отчеты.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Отчет_Время_съемкиBindingSource
            // 
            this.Отчет_Время_съемкиBindingSource.DataMember = "Отчет Время съемки";
            this.Отчет_Время_съемкиBindingSource.DataSource = this.Отчеты;
            // 
            // Отчет_Время_съемкиTableAdapter
            // 
            this.Отчет_Время_съемкиTableAdapter.ClearBeforeFill = true;
            // 
            // Отчет_таблицы_Время_съемки
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.color_cinema_icons_Mask_1320567857466645022;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Отчет_таблицы_Время_съемки";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет_таблицы_Время_съемки";
            this.Load += new System.EventHandler(this.Отчет_таблицы_Время_съемки_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Время_съемкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ФильмыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчеты)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_Время_съемкиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource Время_съемкиBindingSource;
        private ФильмыDataSet ФильмыDataSet;
        private ФильмыDataSetTableAdapters.Время_съемкиTableAdapter Время_съемкиTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Отчет_Время_съемкиBindingSource;
        private Отчеты Отчеты;
        private ОтчетыTableAdapters.Отчет_Время_съемкиTableAdapter Отчет_Время_съемкиTableAdapter;
    }
}