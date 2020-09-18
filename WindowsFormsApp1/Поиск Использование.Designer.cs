namespace WindowsFormsApp1
{
    partial class Поиск_Использование
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Поиск_Использование));
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.использованиеprocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.использованиеprocTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.ИспользованиеprocTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.DataSet1TableAdapters.TableAdapterManager();
            this.использованиеprocBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.использованиеprocBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.годToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.годToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.жанрToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.жанрToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.фильмToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.фильмToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.использованиеprocDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.использованиеprocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.использованиеprocBindingNavigator)).BeginInit();
            this.использованиеprocBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.использованиеprocDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // использованиеprocBindingSource
            // 
            this.использованиеprocBindingSource.DataMember = "Использованиеproc";
            this.использованиеprocBindingSource.DataSource = this.dataSet1;
            // 
            // использованиеprocTableAdapter
            // 
            this.использованиеprocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // использованиеprocBindingNavigator
            // 
            this.использованиеprocBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.использованиеprocBindingNavigator.BindingSource = this.использованиеprocBindingSource;
            this.использованиеprocBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.использованиеprocBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.использованиеprocBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.использованиеprocBindingNavigatorSaveItem});
            this.использованиеprocBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.использованиеprocBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.использованиеprocBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.использованиеprocBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.использованиеprocBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.использованиеprocBindingNavigator.Name = "использованиеprocBindingNavigator";
            this.использованиеprocBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.использованиеprocBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.использованиеprocBindingNavigator.TabIndex = 0;
            this.использованиеprocBindingNavigator.Text = "bindingNavigator1";
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
            // использованиеprocBindingNavigatorSaveItem
            // 
            this.использованиеprocBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.использованиеprocBindingNavigatorSaveItem.Enabled = false;
            this.использованиеprocBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("использованиеprocBindingNavigatorSaveItem.Image")));
            this.использованиеprocBindingNavigatorSaveItem.Name = "использованиеprocBindingNavigatorSaveItem";
            this.использованиеprocBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.использованиеprocBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.годToolStripLabel,
            this.годToolStripTextBox,
            this.жанрToolStripLabel,
            this.жанрToolStripTextBox,
            this.фильмToolStripLabel,
            this.фильмToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // годToolStripLabel
            // 
            this.годToolStripLabel.Name = "годToolStripLabel";
            this.годToolStripLabel.Size = new System.Drawing.Size(28, 22);
            this.годToolStripLabel.Text = "год:";
            // 
            // годToolStripTextBox
            // 
            this.годToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.годToolStripTextBox.Name = "годToolStripTextBox";
            this.годToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // жанрToolStripLabel
            // 
            this.жанрToolStripLabel.Name = "жанрToolStripLabel";
            this.жанрToolStripLabel.Size = new System.Drawing.Size(39, 22);
            this.жанрToolStripLabel.Text = "жанр:";
            // 
            // жанрToolStripTextBox
            // 
            this.жанрToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.жанрToolStripTextBox.Name = "жанрToolStripTextBox";
            this.жанрToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // фильмToolStripLabel
            // 
            this.фильмToolStripLabel.Name = "фильмToolStripLabel";
            this.фильмToolStripLabel.Size = new System.Drawing.Size(48, 22);
            this.фильмToolStripLabel.Text = "фильм:";
            // 
            // фильмToolStripTextBox
            // 
            this.фильмToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.фильмToolStripTextBox.Name = "фильмToolStripTextBox";
            this.фильмToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // использованиеprocDataGridView
            // 
            this.использованиеprocDataGridView.AutoGenerateColumns = false;
            this.использованиеprocDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.использованиеprocDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.использованиеprocDataGridView.DataSource = this.использованиеprocBindingSource;
            this.использованиеprocDataGridView.Location = new System.Drawing.Point(175, 85);
            this.использованиеprocDataGridView.Name = "использованиеprocDataGridView";
            this.использованиеprocDataGridView.Size = new System.Drawing.Size(436, 220);
            this.использованиеprocDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Год_использования";
            this.dataGridViewTextBoxColumn1.HeaderText = "Год_использования";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название_жанра";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название_жанра";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Название_фильма";
            this.dataGridViewTextBoxColumn3.HeaderText = "Название_фильма";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // Поиск_Использование
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.color_cinema_icons_Mask_1320567857466645022;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.использованиеprocDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.использованиеprocBindingNavigator);
            this.Name = "Поиск_Использование";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск_Использование";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.использованиеprocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.использованиеprocBindingNavigator)).EndInit();
            this.использованиеprocBindingNavigator.ResumeLayout(false);
            this.использованиеprocBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.использованиеprocDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource использованиеprocBindingSource;
        private DataSet1TableAdapters.ИспользованиеprocTableAdapter использованиеprocTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator использованиеprocBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton использованиеprocBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel годToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox годToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel жанрToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox жанрToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel фильмToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox фильмToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView использованиеprocDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}