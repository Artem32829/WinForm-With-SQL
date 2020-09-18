namespace WindowsFormsApp1
{
    partial class Носитель
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
            System.Windows.Forms.Label памятьLabel;
            System.Windows.Forms.Label кодНосителяLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Носитель));
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.фильмыDataSet = new WindowsFormsApp1.ФильмыDataSet();
            this.носительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.носительTableAdapter = new WindowsFormsApp1.ФильмыDataSetTableAdapters.НосительTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ФильмыDataSetTableAdapters.TableAdapterManager();
            this.носительBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.носительBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.памятьTextBox = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.видНосителяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вид_носителяTableAdapter = new WindowsFormsApp1.ФильмыDataSetTableAdapters.Вид_носителяTableAdapter();
            this.button10 = new System.Windows.Forms.Button();
            памятьLabel = new System.Windows.Forms.Label();
            кодНосителяLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.носительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.носительBindingNavigator)).BeginInit();
            this.носительBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.видНосителяBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // памятьLabel
            // 
            памятьLabel.AutoSize = true;
            памятьLabel.Location = new System.Drawing.Point(102, 166);
            памятьLabel.Name = "памятьLabel";
            памятьLabel.Size = new System.Drawing.Size(49, 13);
            памятьLabel.TabIndex = 23;
            памятьLabel.Text = "Память:";
            // 
            // кодНосителяLabel
            // 
            кодНосителяLabel.AutoSize = true;
            кодНосителяLabel.Location = new System.Drawing.Point(102, 208);
            кодНосителяLabel.Name = "кодНосителяLabel";
            кодНосителяLabel.Size = new System.Drawing.Size(110, 13);
            кодНосителяLabel.TabIndex = 27;
            кодНосителяLabel.Text = "Название носителя:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(328, 295);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 29);
            this.button7.TabIndex = 21;
            this.button7.Text = "Следующая";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(209, 345);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 29);
            this.button6.TabIndex = 20;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(209, 395);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 29);
            this.button5.TabIndex = 19;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(328, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 29);
            this.button4.TabIndex = 18;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(209, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 29);
            this.button3.TabIndex = 17;
            this.button3.Text = "Последняя";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 295);
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
            // носительBindingSource
            // 
            this.носительBindingSource.DataMember = "Носитель";
            this.носительBindingSource.DataSource = this.фильмыDataSet;
            // 
            // носительTableAdapter
            // 
            this.носительTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.НосительTableAdapter = this.носительTableAdapter;
            this.tableAdapterManager.РежисссерыTableAdapter = null;
            this.tableAdapterManager.ФильмыTableAdapter = null;
            // 
            // носительBindingNavigator
            // 
            this.носительBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.носительBindingNavigator.BindingSource = this.носительBindingSource;
            this.носительBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.носительBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.носительBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.носительBindingNavigatorSaveItem});
            this.носительBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.носительBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.носительBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.носительBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.носительBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.носительBindingNavigator.Name = "носительBindingNavigator";
            this.носительBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.носительBindingNavigator.Size = new System.Drawing.Size(556, 25);
            this.носительBindingNavigator.TabIndex = 23;
            this.носительBindingNavigator.Text = "bindingNavigator1";
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
            // носительBindingNavigatorSaveItem
            // 
            this.носительBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.носительBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("носительBindingNavigatorSaveItem.Image")));
            this.носительBindingNavigatorSaveItem.Name = "носительBindingNavigatorSaveItem";
            this.носительBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.носительBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.носительBindingNavigatorSaveItem.Click += new System.EventHandler(this.носительBindingNavigatorSaveItem_Click);
            // 
            // памятьTextBox
            // 
            this.памятьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.носительBindingSource, "Память", true));
            this.памятьTextBox.Location = new System.Drawing.Point(232, 163);
            this.памятьTextBox.Name = "памятьTextBox";
            this.памятьTextBox.Size = new System.Drawing.Size(178, 20);
            this.памятьTextBox.TabIndex = 24;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.color_cinema_icons_Mask_1320567857466645022;
            this.button9.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(446, 222);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(87, 31);
            this.button9.TabIndex = 30;
            this.button9.Text = "Отчёт";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.color_cinema_icons_Mask_1320567857466645022;
            this.button8.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(446, 185);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 31);
            this.button8.TabIndex = 29;
            this.button8.Text = "Таблица";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.носительBindingSource, "Код_носителя", true));
            this.comboBox1.DataSource = this.видНосителяBindingSource;
            this.comboBox1.DisplayMember = "Название_Носителя";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(232, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.ValueMember = "Код_носителя";
            // 
            // видНосителяBindingSource
            // 
            this.видНосителяBindingSource.DataMember = "Вид носителя";
            this.видНосителяBindingSource.DataSource = this.фильмыDataSet;
            // 
            // вид_носителяTableAdapter
            // 
            this.вид_носителяTableAdapter.ClearBeforeFill = true;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button10.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(212, 242);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(99, 28);
            this.button10.TabIndex = 32;
            this.button10.Text = "Поиск";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Носитель
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.color_cinema_icons_Mask_1320567857466645022;
            this.ClientSize = new System.Drawing.Size(556, 511);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(памятьLabel);
            this.Controls.Add(this.памятьTextBox);
            this.Controls.Add(кодНосителяLabel);
            this.Controls.Add(this.носительBindingNavigator);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Носитель";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Носитель";
            this.Load += new System.EventHandler(this.Носитель_Load);
            ((System.ComponentModel.ISupportInitialize)(this.фильмыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.носительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.носительBindingNavigator)).EndInit();
            this.носительBindingNavigator.ResumeLayout(false);
            this.носительBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.видНосителяBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource носительBindingSource;
        private ФильмыDataSetTableAdapters.НосительTableAdapter носительTableAdapter;
        private ФильмыDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator носительBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton носительBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox памятьTextBox;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource видНосителяBindingSource;
        private ФильмыDataSetTableAdapters.Вид_носителяTableAdapter вид_носителяTableAdapter;
        private System.Windows.Forms.Button button10;
    }
}