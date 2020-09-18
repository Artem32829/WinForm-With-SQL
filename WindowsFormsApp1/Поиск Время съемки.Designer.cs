namespace WindowsFormsApp1
{
    partial class Поиск_Время_съемки
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Поиск_Время_съемки));
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.времяСъемкиprocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.времяСъемкиprocTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.ВремяСъемкиprocTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.DataSet1TableAdapters.TableAdapterManager();
            this.времяСъемкиprocBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.времяСъемкиprocBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.годToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.годToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.фильмToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.фильмToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.фамилияToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.фамилияToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.имяToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.имяToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.отчествоToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.отчествоToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.времяСъемкиprocDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.времяСъемкиprocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.времяСъемкиprocBindingNavigator)).BeginInit();
            this.времяСъемкиprocBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.времяСъемкиprocDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // времяСъемкиprocBindingSource
            // 
            this.времяСъемкиprocBindingSource.DataMember = "ВремяСъемкиproc";
            this.времяСъемкиprocBindingSource.DataSource = this.dataSet1;
            // 
            // времяСъемкиprocTableAdapter
            // 
            this.времяСъемкиprocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // времяСъемкиprocBindingNavigator
            // 
            this.времяСъемкиprocBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.времяСъемкиprocBindingNavigator.BindingSource = this.времяСъемкиprocBindingSource;
            this.времяСъемкиprocBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.времяСъемкиprocBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.времяСъемкиprocBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.времяСъемкиprocBindingNavigatorSaveItem});
            this.времяСъемкиprocBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.времяСъемкиprocBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.времяСъемкиprocBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.времяСъемкиprocBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.времяСъемкиprocBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.времяСъемкиprocBindingNavigator.Name = "времяСъемкиprocBindingNavigator";
            this.времяСъемкиprocBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.времяСъемкиprocBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.времяСъемкиprocBindingNavigator.TabIndex = 0;
            this.времяСъемкиprocBindingNavigator.Text = "bindingNavigator1";
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
            // времяСъемкиprocBindingNavigatorSaveItem
            // 
            this.времяСъемкиprocBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.времяСъемкиprocBindingNavigatorSaveItem.Enabled = false;
            this.времяСъемкиprocBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("времяСъемкиprocBindingNavigatorSaveItem.Image")));
            this.времяСъемкиprocBindingNavigatorSaveItem.Name = "времяСъемкиprocBindingNavigatorSaveItem";
            this.времяСъемкиprocBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.времяСъемкиprocBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.годToolStripLabel,
            this.годToolStripTextBox,
            this.фильмToolStripLabel,
            this.фильмToolStripTextBox,
            this.фамилияToolStripLabel,
            this.фамилияToolStripTextBox,
            this.имяToolStripLabel,
            this.имяToolStripTextBox,
            this.отчествоToolStripLabel,
            this.отчествоToolStripTextBox,
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
            // отчествоToolStripLabel
            // 
            this.отчествоToolStripLabel.Name = "отчествоToolStripLabel";
            this.отчествоToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.отчествоToolStripLabel.Text = "отчество:";
            // 
            // отчествоToolStripTextBox
            // 
            this.отчествоToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.отчествоToolStripTextBox.Name = "отчествоToolStripTextBox";
            this.отчествоToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // времяСъемкиprocDataGridView
            // 
            this.времяСъемкиprocDataGridView.AutoGenerateColumns = false;
            this.времяСъемкиprocDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.времяСъемкиprocDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.времяСъемкиprocDataGridView.DataSource = this.времяСъемкиprocBindingSource;
            this.времяСъемкиprocDataGridView.Location = new System.Drawing.Point(107, 91);
            this.времяСъемкиprocDataGridView.Name = "времяСъемкиprocDataGridView";
            this.времяСъемкиprocDataGridView.Size = new System.Drawing.Size(578, 220);
            this.времяСъемкиprocDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Год_съемки";
            this.dataGridViewTextBoxColumn1.HeaderText = "Год_съемки";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название_фильма";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название_фильма";
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn5.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Поиск_Время_съемки
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.color_cinema_icons_Mask_1320567857466645022;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.времяСъемкиprocDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.времяСъемкиprocBindingNavigator);
            this.Name = "Поиск_Время_съемки";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск_Время_съемки";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.времяСъемкиprocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.времяСъемкиprocBindingNavigator)).EndInit();
            this.времяСъемкиprocBindingNavigator.ResumeLayout(false);
            this.времяСъемкиprocBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.времяСъемкиprocDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource времяСъемкиprocBindingSource;
        private DataSet1TableAdapters.ВремяСъемкиprocTableAdapter времяСъемкиprocTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator времяСъемкиprocBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton времяСъемкиprocBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel годToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox годToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel фильмToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox фильмToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel фамилияToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox фамилияToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel имяToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox имяToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel отчествоToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox отчествоToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView времяСъемкиprocDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}