namespace WindowsFormsApp1
{
    partial class Поиск_Вид_носителя
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.названиеНосителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодносителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видНосителяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фильмыDataSet = new WindowsFormsApp1.ФильмыDataSet();
            this.вид_носителяTableAdapter = new WindowsFormsApp1.ФильмыDataSetTableAdapters.Вид_носителяTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видНосителяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеНосителяDataGridViewTextBoxColumn,
            this.кодносителяDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.видНосителяBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(166, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // названиеНосителяDataGridViewTextBoxColumn
            // 
            this.названиеНосителяDataGridViewTextBoxColumn.DataPropertyName = "Название_Носителя";
            this.названиеНосителяDataGridViewTextBoxColumn.HeaderText = "Название_Носителя";
            this.названиеНосителяDataGridViewTextBoxColumn.Name = "названиеНосителяDataGridViewTextBoxColumn";
            this.названиеНосителяDataGridViewTextBoxColumn.Width = 200;
            // 
            // кодносителяDataGridViewTextBoxColumn
            // 
            this.кодносителяDataGridViewTextBoxColumn.DataPropertyName = "Код_носителя";
            this.кодносителяDataGridViewTextBoxColumn.HeaderText = "Код_носителя";
            this.кодносителяDataGridViewTextBoxColumn.Name = "кодносителяDataGridViewTextBoxColumn";
            this.кодносителяDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодносителяDataGridViewTextBoxColumn.Width = 200;
            // 
            // видНосителяBindingSource
            // 
            this.видНосителяBindingSource.DataMember = "Вид носителя";
            this.видНосителяBindingSource.DataSource = this.фильмыDataSet;
            // 
            // фильмыDataSet
            // 
            this.фильмыDataSet.DataSetName = "ФильмыDataSet";
            this.фильмыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // вид_носителяTableAdapter
            // 
            this.вид_носителяTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 323);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Поиск_Вид_носителя
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.color_cinema_icons_Mask_1320567857466645022;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Поиск_Вид_носителя";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск_Вид_носителя";
            this.Load += new System.EventHandler(this.Поиск_Вид_носителя_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видНосителяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ФильмыDataSet фильмыDataSet;
        private System.Windows.Forms.BindingSource видНосителяBindingSource;
        private ФильмыDataSetTableAdapters.Вид_носителяTableAdapter вид_носителяTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеНосителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодносителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
    }
}