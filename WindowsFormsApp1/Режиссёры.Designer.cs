namespace WindowsFormsApp1
{
    partial class Режиссёры
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
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Режиссёры));
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.фильмыDataSet = new WindowsFormsApp1.ФильмыDataSet();
            this.режисссерыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.режисссерыTableAdapter = new WindowsFormsApp1.ФильмыDataSetTableAdapters.РежисссерыTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ФильмыDataSetTableAdapters.TableAdapterManager();
            this.режисссерыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.режисссерыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.режисссерыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.режисссерыBindingNavigator)).BeginInit();
            this.режисссерыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(131, 175);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(59, 13);
            фамилияLabel.TabIndex = 23;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(131, 201);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(32, 13);
            имяLabel.TabIndex = 25;
            имяLabel.Text = "Имя:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(323, 293);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 29);
            this.button7.TabIndex = 21;
            this.button7.Text = "Следующая";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(204, 343);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 29);
            this.button6.TabIndex = 20;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(204, 393);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 29);
            this.button5.TabIndex = 19;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(323, 343);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 29);
            this.button4.TabIndex = 18;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(204, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 29);
            this.button3.TabIndex = 17;
            this.button3.Text = "Последняя";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // фильмыDataSet
            // 
            this.фильмыDataSet.DataSetName = "ФильмыDataSet";
            this.фильмыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // режисссерыBindingSource
            // 
            this.режисссерыBindingSource.DataMember = "Режисссеры";
            this.режисссерыBindingSource.DataSource = this.фильмыDataSet;
            // 
            // режисссерыTableAdapter
            // 
            this.режисссерыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.ФильмыDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АктерыTableAdapter = null;
            this.tableAdapterManager.Вид_носителяTableAdapter = null;
            this.tableAdapterManager.Время_записиTableAdapter = null;
            this.tableAdapterManager.Время_съемкиTableAdapter = null;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
            this.tableAdapterManager.ИспользованиеTableAdapter = null;
            this.tableAdapterManager.НосительTableAdapter = null;
            this.tableAdapterManager.РежисссерыTableAdapter = this.режисссерыTableAdapter;
            this.tableAdapterManager.ФильмыTableAdapter = null;
            // 
            // режисссерыBindingNavigator
            // 
            this.режисссерыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.режисссерыBindingNavigator.BindingSource = this.режисссерыBindingSource;
            this.режисссерыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.режисссерыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.режисссерыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.режисссерыBindingNavigatorSaveItem});
            this.режисссерыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.режисссерыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.режисссерыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.режисссерыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.режисссерыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.режисссерыBindingNavigator.Name = "режисссерыBindingNavigator";
            this.режисссерыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.режисссерыBindingNavigator.Size = new System.Drawing.Size(551, 25);
            this.режисссерыBindingNavigator.TabIndex = 23;
            this.режисссерыBindingNavigator.Text = "bindingNavigator1";
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
            // режисссерыBindingNavigatorSaveItem
            // 
            this.режисссерыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.режисссерыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("режисссерыBindingNavigatorSaveItem.Image")));
            this.режисссерыBindingNavigatorSaveItem.Name = "режисссерыBindingNavigatorSaveItem";
            this.режисссерыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.режисссерыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.режисссерыBindingNavigatorSaveItem.Click += new System.EventHandler(this.режисссерыBindingNavigatorSaveItem_Click);
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.режисссерыBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(215, 172);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(158, 20);
            this.фамилияTextBox.TabIndex = 24;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.режисссерыBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(215, 198);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(158, 20);
            this.имяTextBox.TabIndex = 26;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.color_cinema_icons_Mask_1320567857466645022;
            this.button9.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(426, 215);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(87, 31);
            this.button9.TabIndex = 28;
            this.button9.Text = "Отчёт";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(207, 237);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(99, 28);
            this.button8.TabIndex = 29;
            this.button8.Text = "Поиск";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Режиссёры
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.color_cinema_icons_Mask_1320567857466645022;
            this.ClientSize = new System.Drawing.Size(551, 495);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(this.режисссерыBindingNavigator);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Режиссёры";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Режиссёры";
            this.Load += new System.EventHandler(this.Режиссёры_Load);
            ((System.ComponentModel.ISupportInitialize)(this.фильмыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.режисссерыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.режисссерыBindingNavigator)).EndInit();
            this.режисссерыBindingNavigator.ResumeLayout(false);
            this.режисссерыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private ФильмыDataSet фильмыDataSet;
        private System.Windows.Forms.BindingSource режисссерыBindingSource;
        private ФильмыDataSetTableAdapters.РежисссерыTableAdapter режисссерыTableAdapter;
        private ФильмыDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator режисссерыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton режисссерыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
    }
}