namespace WindowsFormsApp1
{
    partial class ИспользованиеТАБЛ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ИспользованиеТАБЛ));
            this.фильмыDataSet = new WindowsFormsApp1.ФильмыDataSet();
            this.жанр_фильм_год_использованияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.жанр_фильм_год_использованияTableAdapter = new WindowsFormsApp1.ФильмыDataSetTableAdapters.Жанр_фильм_год_использованияTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ФильмыDataSetTableAdapters.TableAdapterManager();
            this.жанр_фильм_год_использованияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.жанр_фильм_год_использованияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.жанр_фильм_год_использованияDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанр_фильм_год_использованияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанр_фильм_год_использованияBindingNavigator)).BeginInit();
            this.жанр_фильм_год_использованияBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.жанр_фильм_год_использованияDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // фильмыDataSet
            // 
            this.фильмыDataSet.DataSetName = "ФильмыDataSet";
            this.фильмыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // жанр_фильм_год_использованияBindingSource
            // 
            this.жанр_фильм_год_использованияBindingSource.DataMember = "Жанр-фильм-год использования";
            this.жанр_фильм_год_использованияBindingSource.DataSource = this.фильмыDataSet;
            // 
            // жанр_фильм_год_использованияTableAdapter
            // 
            this.жанр_фильм_год_использованияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.ФильмыDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АктерыTableAdapter = null;
            this.tableAdapterManager.Вид_носителяTableAdapter = null;
            this.tableAdapterManager.Время_записиTableAdapter = null;
            this.tableAdapterManager.Время_съемкиTableAdapter = null;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
            this.tableAdapterManager.ИспользованиеTableAdapter = null;
            this.tableAdapterManager.НосительTableAdapter = null;
            this.tableAdapterManager.РежисссерыTableAdapter = null;
            this.tableAdapterManager.ФильмыTableAdapter = null;
            // 
            // жанр_фильм_год_использованияBindingNavigator
            // 
            this.жанр_фильм_год_использованияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.жанр_фильм_год_использованияBindingNavigator.BindingSource = this.жанр_фильм_год_использованияBindingSource;
            this.жанр_фильм_год_использованияBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.жанр_фильм_год_использованияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.жанр_фильм_год_использованияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.жанр_фильм_год_использованияBindingNavigatorSaveItem});
            this.жанр_фильм_год_использованияBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.жанр_фильм_год_использованияBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.жанр_фильм_год_использованияBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.жанр_фильм_год_использованияBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.жанр_фильм_год_использованияBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.жанр_фильм_год_использованияBindingNavigator.Name = "жанр_фильм_год_использованияBindingNavigator";
            this.жанр_фильм_год_использованияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.жанр_фильм_год_использованияBindingNavigator.Size = new System.Drawing.Size(638, 25);
            this.жанр_фильм_год_использованияBindingNavigator.TabIndex = 0;
            this.жанр_фильм_год_использованияBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // жанр_фильм_год_использованияBindingNavigatorSaveItem
            // 
            this.жанр_фильм_год_использованияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.жанр_фильм_год_использованияBindingNavigatorSaveItem.Enabled = false;
            this.жанр_фильм_год_использованияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("жанр_фильм_год_использованияBindingNavigatorSaveItem.Image")));
            this.жанр_фильм_год_использованияBindingNavigatorSaveItem.Name = "жанр_фильм_год_использованияBindingNavigatorSaveItem";
            this.жанр_фильм_год_использованияBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.жанр_фильм_год_использованияBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // жанр_фильм_год_использованияDataGridView
            // 
            this.жанр_фильм_год_использованияDataGridView.AutoGenerateColumns = false;
            this.жанр_фильм_год_использованияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.жанр_фильм_год_использованияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.жанр_фильм_год_использованияDataGridView.DataSource = this.жанр_фильм_год_использованияBindingSource;
            this.жанр_фильм_год_использованияDataGridView.Location = new System.Drawing.Point(61, 62);
            this.жанр_фильм_год_использованияDataGridView.Name = "жанр_фильм_год_использованияDataGridView";
            this.жанр_фильм_год_использованияDataGridView.Size = new System.Drawing.Size(494, 351);
            this.жанр_фильм_год_использованияDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Название_жанра";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название_жанра";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 160;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Год_использования";
            this.dataGridViewTextBoxColumn2.HeaderText = "Год_использования";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 160;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Название_фильма";
            this.dataGridViewTextBoxColumn3.HeaderText = "Название_фильма";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 160;
            // 
            // ИспользованиеТАБЛ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.color_cinema_icons_Mask_1320567857466645022;
            this.ClientSize = new System.Drawing.Size(638, 504);
            this.Controls.Add(this.жанр_фильм_год_использованияDataGridView);
            this.Controls.Add(this.жанр_фильм_год_использованияBindingNavigator);
            this.Name = "ИспользованиеТАБЛ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИспользованиеТАБЛ";
            this.Load += new System.EventHandler(this.ИспользованиеТАБЛ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.фильмыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанр_фильм_год_использованияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанр_фильм_год_использованияBindingNavigator)).EndInit();
            this.жанр_фильм_год_использованияBindingNavigator.ResumeLayout(false);
            this.жанр_фильм_год_использованияBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.жанр_фильм_год_использованияDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ФильмыDataSet фильмыDataSet;
        private System.Windows.Forms.BindingSource жанр_фильм_год_использованияBindingSource;
        private ФильмыDataSetTableAdapters.Жанр_фильм_год_использованияTableAdapter жанр_фильм_год_использованияTableAdapter;
        private ФильмыDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator жанр_фильм_год_использованияBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton жанр_фильм_год_использованияBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView жанр_фильм_год_использованияDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}