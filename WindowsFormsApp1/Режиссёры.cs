using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Режиссёры : Form
    {
        public Режиссёры()
        {
            InitializeComponent();
        }

        private void режисссерыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.режисссерыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.фильмыDataSet);

        }

        private void Режиссёры_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet.Режисссеры". При необходимости она может быть перемещена или удалена.
            this.режисссерыTableAdapter.Fill(this.фильмыDataSet.Режисссеры);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.режисссерыBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.режисссерыBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.режисссерыBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.режисссерыBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.режисссерыBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.режисссерыBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.режисссерыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.фильмыDataSet);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Отчет_таблицы_Режиссеры v1 = new Отчет_таблицы_Режиссеры();
            v1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Поиск_Режиссеры v2 = new Поиск_Режиссеры();
            v2.Show();
        }
    }
}
