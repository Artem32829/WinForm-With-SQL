namespace WindowsFormsApp1
{
    partial class ФильмыТАБЛ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ФильмыТАБЛ));
            this.фильмыDataSet = new WindowsFormsApp1.ФильмыDataSet();
            this.фильм_режиссерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фильм_режиссерTableAdapter = new WindowsFormsApp1.ФильмыDataSetTableAdapters.Фильм_режиссерTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ФильмыDataSetTableAdapters.TableAdapterManager();
            this.фильм_режиссерBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.фильм_режиссерBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.фильм_режиссерDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильм_режиссерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильм_режиссерBindingNavigator)).BeginInit();
            this.фильм_режиссерBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фильм_режиссерDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // фильмыDataSet
            // 
            this.фильмыDataSet.DataSetName = "ФильмыDataSet";
            this.фильмыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // фильм_режиссерBindingSource
            // 
            this.фильм_режиссерBindingSource.DataMember = "Фильм-режиссер";
            this.фильм_режиссерBindingSource.DataSource = this.фильмыDataSet;
            // 
            // фильм_режиссерTableAdapter
            // 
            this.фильм_режиссерTableAdapter.ClearBeforeFill = true;
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
            // фильм_режиссерBindingNavigator
            // 
            this.фильм_режиссерBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.фильм_режиссерBindingNavigator.BindingSource = this.фильм_режиссерBindingSource;
            this.фильм_режиссерBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.фильм_режиссерBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.фильм_режиссерBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.фильм_режиссерBindingNavigatorSaveItem});
            this.фильм_режиссерBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.фильм_режиссерBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.фильм_режиссерBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.фильм_режиссерBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.фильм_режиссерBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.фильм_режиссерBindingNavigator.Name = "фильм_режиссерBindingNavigator";
            this.фильм_режиссерBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.фильм_режиссерBindingNavigator.Size = new System.Drawing.Size(596, 25);
            this.фильм_режиссерBindingNavigator.TabIndex = 0;
            this.фильм_режиссерBindingNavigator.Text = "bindingNavigator1";
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
            // фильм_режиссерBindingNavigatorSaveItem
            // 
            this.фильм_режиссерBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.фильм_режиссерBindingNavigatorSaveItem.Enabled = false;
            this.фильм_режиссерBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("фильм_режиссерBindingNavigatorSaveItem.Image")));
            this.фильм_режиссерBindingNavigatorSaveItem.Name = "фильм_режиссерBindingNavigatorSaveItem";
            this.фильм_режиссерBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.фильм_режиссерBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // фильм_режиссерDataGridView
            // 
            this.фильм_режиссерDataGridView.AutoGenerateColumns = false;
            this.фильм_режиссерDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.фильм_режиссерDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.фильм_режиссерDataGridView.DataSource = this.фильм_режиссерBindingSource;
            this.фильм_режиссерDataGridView.Location = new System.Drawing.Point(12, 55);
            this.фильм_режиссерDataGridView.Name = "фильм_режиссерDataGridView";
            this.фильм_режиссерDataGridView.Size = new System.Drawing.Size(572, 385);
            this.фильм_режиссерDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Название_фильма";
            this.dataGridViewTextBoxColumn3.HeaderText = "Название_фильма";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 160;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Продолжительность";
            this.dataGridViewTextBoxColumn4.HeaderText = "Продолжительность";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 160;
            // 
            // ФильмыТАБЛ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.color_cinema_icons_Mask_1320567857466645022;
            this.ClientSize = new System.Drawing.Size(596, 513);
            this.Controls.Add(this.фильм_режиссерDataGridView);
            this.Controls.Add(this.фильм_режиссерBindingNavigator);
            this.Name = "ФильмыТАБЛ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ФильмыТАБЛ";
            this.Load += new System.EventHandler(this.ФильмыТАБЛ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.фильмыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильм_режиссерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильм_режиссерBindingNavigator)).EndInit();
            this.фильм_режиссерBindingNavigator.ResumeLayout(false);
            this.фильм_режиссерBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фильм_режиссерDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ФильмыDataSet фильмыDataSet;
        private System.Windows.Forms.BindingSource фильм_режиссерBindingSource;
        private ФильмыDataSetTableAdapters.Фильм_режиссерTableAdapter фильм_режиссерTableAdapter;
        private ФильмыDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator фильм_режиссерBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton фильм_режиссерBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView фильм_режиссерDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}