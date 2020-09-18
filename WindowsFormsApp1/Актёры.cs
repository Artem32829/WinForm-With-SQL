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
    public partial class Актёры : Form
    {
        public Актёры()
        {
            InitializeComponent();
        }

        private void актерыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.актерыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.фильмыDataSet);

        }

        private void Актёры_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet.Актеры". При необходимости она может быть перемещена или удалена.
            this.актерыTableAdapter.Fill(this.фильмыDataSet.Актеры);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.актерыBindingSource.MoveLast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.актерыBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.актерыBindingSource.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.актерыBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.актерыBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.актерыBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.актерыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.фильмыDataSet);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Отчёт_таблицы_Актёры v1 = new Отчёт_таблицы_Актёры();
            v1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Поиск_Актеры v2 = new Поиск_Актеры();
            v2.Show();
        }
    }
}
