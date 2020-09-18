namespace WindowsFormsApp1
{
    partial class Поиск_Фильмы
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Поиск_Фильмы));
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.фильмыprocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фильмыprocTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.ФильмыprocTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.DataSet1TableAdapters.TableAdapterManager();
            this.фильмыprocBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.фильмыprocBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.названиеToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.названиеToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.продолжительностьToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.продолжительностьToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.фамилияToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.фамилияToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.имяToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.имяToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.фильмыprocDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыprocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыprocBindingNavigator)).BeginInit();
            this.фильмыprocBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыprocDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // фильмыprocBindingSource
            // 
            this.фильмыprocBindingSource.DataMember = "Фильмыproc";
            this.фильмыprocBindingSource.DataSource = this.dataSet1;
            // 
            // фильмыprocTableAdapter
            // 
            this.фильмыprocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // фильмыprocBindingNavigator
            // 
            this.фильмыprocBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.фильмыprocBindingNavigator.BindingSource = this.фильмыprocBindingSource;
            this.фильмыprocBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.фильмыprocBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.фильмыprocBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.фильмыprocBindingNavigatorSaveItem});
            this.фильмыprocBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.фильмыprocBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.фильмыprocBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.фильмыprocBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.фильмыprocBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.фильмыprocBindingNavigator.Name = "фильмыprocBindingNavigator";
            this.фильмыprocBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.фильмыprocBindingNavigator.Size = new System.Drawing.Size(767, 25);
            this.фильмыprocBindingNavigator.TabIndex = 0;
            this.фильмыprocBindingNavigator.Text = "bindingNavigator1";
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
            // фильмыprocBindingNavigatorSaveItem
            // 
            this.фильмыprocBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.фильмыprocBindingNavigatorSaveItem.Enabled = false;
            this.фильмыprocBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("фильмыprocBindingNavigatorSaveItem.Image")));
            this.фильмыprocBindingNavigatorSaveItem.Name = "фильмыprocBindingNavigatorSaveItem";
            this.фильмыprocBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.фильмыprocBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.названиеToolStripLabel,
            this.названиеToolStripTextBox,
            this.продолжительностьToolStripLabel,
            this.продолжительностьToolStripTextBox,
            this.фамилияToolStripLabel,
            this.фамилияToolStripTextBox,
            this.имяToolStripLabel,
            this.имяToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(767, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // названиеToolStripLabel
            // 
            this.названиеToolStripLabel.Name = "названиеToolStripLabel";
            this.названиеToolStripLabel.Size = new System.Drawing.Size(60, 22);
            this.названиеToolStripLabel.Text = "название:";
            // 
            // названиеToolStripTextBox
            // 
            this.названиеToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.названиеToolStripTextBox.Name = "названиеToolStripTextBox";
            this.названиеToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // продолжительностьToolStripLabel
            // 
            this.продолжительностьToolStripLabel.Name = "продолжительностьToolStripLabel";
            this.продолжительностьToolStripLabel.Size = new System.Drawing.Size(122, 22);
            this.продолжительностьToolStripLabel.Text = "продолжительность:";
            // 
            // продолжительностьToolStripTextBox
            // 
            this.продолжительностьToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.продолжительностьToolStripTextBox.Name = "продолжительностьToolStripTextBox";
            this.продолжительностьToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // фамилияToolStripLabel
            // 
            this.фамилияToolStripLabel.Name = "фамилияToolStripLabel";
            this.фамилияToolStripLabel.Size = new System.Drawing.Size(61, 22);
            this.фамилияToolStripLabel.Text = "фамилия:";
            // 
            // фамилияToolStripTextBox
            // 
            this.фамилияToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.фамилияToolStripTextBox.Name = "фамилияToolStripTextBox";
            this.фамилияToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // имяToolStripLabel
            // 
            this.имяToolStripLabel.Name = "имяToolStripLabel";
            this.имяToolStripLabel.Size = new System.Drawing.Size(32, 22);
            this.имяToolStripLabel.Text = "имя:";
            // 
            // имяToolStripTextBox
            // 
            this.имяToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.имяToolStripTextBox.Name = "имяToolStripTextBox";
            this.имяToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // фильмыprocDataGridView
            // 
            this.фильмыprocDataGridView.AutoGenerateColumns = false;
            this.фильмыprocDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.фильмыprocDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.фильмыprocDataGridView.DataSource = this.фильмыprocBindingSource;
            this.фильмыprocDataGridView.Location = new System.Drawing.Point(144, 103);
            this.фильмыprocDataGridView.Name = "фильмыprocDataGridView";
            this.фильмыprocDataGridView.Size = new System.Drawing.Size(505, 220);
            this.фильмыprocDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Название_фильма";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название фильма";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Продолжительность";
            this.dataGridViewTextBoxColumn2.HeaderText = "Продолжительность";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn3.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn4.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Поиск_Фильмы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.color_cinema_icons_Mask_1320567857466645022;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.фильмыprocDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.фильмыprocBindingNavigator);
            this.Name = "Поиск_Фильмы";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск_Фильмы";
            this.Load += new System.EventHandler(this.Поиск_Фильмы_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыprocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыprocBindingNavigator)).EndInit();
            this.фильмыprocBindingNavigator.ResumeLayout(false);
            this.фильмыprocBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыprocDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource фильмыprocBindingSource;
        private DataSet1TableAdapters.ФильмыprocTableAdapter фильмыprocTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator фильмыprocBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton фильмыprocBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel названиеToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox названиеToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel продолжительностьToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox продолжительностьToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel фамилияToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox фамилияToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel имяToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox имяToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView фильмыprocDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}