namespace WindowsFormsApp1
{
    partial class Отчет_таблицы_Режиссеры
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
            this.РежисссерыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ФильмыDataSet = new WindowsFormsApp1.ФильмыDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.РежисссерыTableAdapter = new WindowsFormsApp1.ФильмыDataSetTableAdapters.РежисссерыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.РежисссерыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ФильмыDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // РежисссерыBindingSource
            // 
            this.РежисссерыBindingSource.DataMember = "Режисссеры";
            this.РежисссерыBindingSource.DataSource = this.ФильмыDataSet;
            // 
            // ФильмыDataSet
            // 
            this.ФильмыDataSet.DataSetName = "ФильмыDataSet";
            this.ФильмыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Режиссеры";
            reportDataSource1.Value = this.РежисссерыBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Отчёт Режиссеры.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 27);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(738, 379);
            this.reportViewer1.TabIndex = 0;
            // 
            // РежисссерыTableAdapter
            // 
            this.РежисссерыTableAdapter.ClearBeforeFill = true;
            // 
            // Отчет_таблицы_Режиссеры
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.color_cinema_icons_Mask_1320567857466645022;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Отчет_таблицы_Режиссеры";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет_таблицы_Режиссеры";
            this.Load += new System.EventHandler(this.Отчет_таблицы_Режиссеры_Load);
            ((System.ComponentModel.ISupportInitialize)(this.РежисссерыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ФильмыDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource РежисссерыBindingSource;
        private ФильмыDataSet ФильмыDataSet;
        private ФильмыDataSetTableAdapters.РежисссерыTableAdapter РежисссерыTableAdapter;
    }
}