namespace WindowsFormsApp1
{
    partial class Отчёт_таблицы_Время_записи
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
            this.Время_записиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ФильмыDataSet = new WindowsFormsApp1.ФильмыDataSet();
            this.Время_записиTableAdapter = new WindowsFormsApp1.ФильмыDataSetTableAdapters.Время_записиTableAdapter();
            this.отчеты = new WindowsFormsApp1.Отчеты();
            this.отчет_Время_записиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отчет_Время_записиTableAdapter = new WindowsFormsApp1.ОтчетыTableAdapters.Отчет_Время_записиTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ОтчетыTableAdapters.TableAdapterManager();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Время_записиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ФильмыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчеты)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчет_Время_записиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Время_записиBindingSource
            // 
            this.Время_записиBindingSource.DataMember = "Время записи";
            this.Время_записиBindingSource.DataSource = this.ФильмыDataSet;
            // 
            // ФильмыDataSet
            // 
            this.ФильмыDataSet.DataSetName = "ФильмыDataSet";
            this.ФильмыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Время_записиTableAdapter
            // 
            this.Время_записиTableAdapter.ClearBeforeFill = true;
            // 
            // отчеты
            // 
            this.отчеты.DataSetName = "Отчеты";
            this.отчеты.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отчет_Время_записиBindingSource
            // 
            this.отчет_Время_записиBindingSource.DataMember = "Отчет Время записи";
            this.отчет_Время_записиBindingSource.DataSource = this.отчеты;
            // 
            // отчет_Время_записиTableAdapter
            // 
            this.отчет_Время_записиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.ОтчетыTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.отчет_Время_записиBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Отчёт Время записи.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(58, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(657, 362);
            this.reportViewer1.TabIndex = 0;
            // 
            // Отчёт_таблицы_Время_записи
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.color_cinema_icons_Mask_1320567857466645022;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Отчёт_таблицы_Время_записи";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт_таблицы_Время_записи";
            this.Load += new System.EventHandler(this.Отчёт_таблицы_Время_записи_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Время_записиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ФильмыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчеты)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчет_Время_записиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource Время_записиBindingSource;
        private ФильмыDataSet ФильмыDataSet;
        private ФильмыDataSetTableAdapters.Время_записиTableAdapter Время_записиTableAdapter;
        private Отчеты отчеты;
        private System.Windows.Forms.BindingSource отчет_Время_записиBindingSource;
        private ОтчетыTableAdapters.Отчет_Время_записиTableAdapter отчет_Время_записиTableAdapter;
        private ОтчетыTableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}