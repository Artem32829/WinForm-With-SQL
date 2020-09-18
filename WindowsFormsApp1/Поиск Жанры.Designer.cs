namespace WindowsFormsApp1
{
    partial class Поиск_Жанры
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
            this.названиежанраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.коджанраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жанрыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фильмыDataSet = new WindowsFormsApp1.ФильмыDataSet();
            this.жанрыTableAdapter = new WindowsFormsApp1.ФильмыDataSetTableAdapters.ЖанрыTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиежанраDataGridViewTextBoxColumn,
            this.коджанраDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.жанрыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(218, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(358, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // названиежанраDataGridViewTextBoxColumn
            // 
            this.названиежанраDataGridViewTextBoxColumn.DataPropertyName = "Название_жанра";
            this.названиежанраDataGridViewTextBoxColumn.HeaderText = "Название_жанра";
            this.названиежанраDataGridViewTextBoxColumn.Name = "названиежанраDataGridViewTextBoxColumn";
            this.названиежанраDataGridViewTextBoxColumn.Width = 160;
            // 
            // коджанраDataGridViewTextBoxColumn
            // 
            this.коджанраDataGridViewTextBoxColumn.DataPropertyName = "Код_жанра";
            this.коджанраDataGridViewTextBoxColumn.HeaderText = "Код_жанра";
            this.коджанраDataGridViewTextBoxColumn.Name = "коджанраDataGridViewTextBoxColumn";
            this.коджанраDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // жанрыBindingSource
            // 
            this.жанрыBindingSource.DataMember = "Жанры";
            this.жанрыBindingSource.DataSource = this.фильмыDataSet;
            // 
            // фильмыDataSet
            // 
            this.фильмыDataSet.DataSetName = "ФильмыDataSet";
            this.фильмыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // жанрыTableAdapter
            // 
            this.жанрыTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 314);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Поиск_Жанры
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.color_cinema_icons_Mask_1320567857466645022;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Поиск_Жанры";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск_Жанры";
            this.Load += new System.EventHandler(this.Поиск_Жанры_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ФильмыDataSet фильмыDataSet;
        private System.Windows.Forms.BindingSource жанрыBindingSource;
        private ФильмыDataSetTableAdapters.ЖанрыTableAdapter жанрыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиежанраDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn коджанраDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
    }
}