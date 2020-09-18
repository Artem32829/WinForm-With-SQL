namespace WindowsFormsApp1
{
    partial class Отчет_таблицы_Вид_носителя
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
            this.Вид_носителяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ФильмыDataSet = new WindowsFormsApp1.ФильмыDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Вид_носителяTableAdapter = new WindowsFormsApp1.ФильмыDataSetTableAdapters.Вид_носителяTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Вид_носителяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ФильмыDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Вид_носителяBindingSource
            // 
            this.Вид_носителяBindingSource.DataMember = "Вид носителя";
            this.Вид_носителяBindingSource.DataSource = this.ФильмыDataSet;
            // 
            // ФильмыDataSet
            // 
            this.ФильмыDataSet.DataSetName = "ФильмыDataSet";
            this.ФильмыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Вид_носителя";
            reportDataSource1.Value = this.Вид_носителяBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Отчёт Вид носителя.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(711, 350);
            this.reportViewer1.TabIndex = 0;
            // 
            // Вид_носителяTableAdapter
            // 
            this.Вид_носителяTableAdapter.ClearBeforeFill = true;
            // 
            // Отчет_таблицы_Вид_носителя
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.color_cinema_icons_Mask_1320567857466645022;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Отчет_таблицы_Вид_носителя";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет_таблицы_Вид_носителя";
            this.Load += new System.EventHandler(this.Отчет_таблицы_Вид_носителя_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Вид_носителяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ФильмыDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Вид_носителяBindingSource;
        private ФильмыDataSet ФильмыDataSet;
        private ФильмыDataSetTableAdapters.Вид_носителяTableAdapter Вид_носителяTableAdapter;
    }
}