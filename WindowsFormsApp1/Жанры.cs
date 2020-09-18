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
    public partial class Жанры : Form
    {
        public Жанры()
        {
            InitializeComponent();
        }

        private void жанрыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.жанрыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.фильмыDataSet);

        }

        private void Жанры_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet.Жанры". При необходимости она может быть перемещена или удалена.
            this.жанрыTableAdapter.Fill(this.фильмыDataSet.Жанры);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.жанрыBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.жанрыBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.жанрыBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.жанрыBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.жанрыBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.жанрыBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.жанрыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.фильмыDataSet);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Отчет_таблицы_Жанры v1 = new Отчет_таблицы_Жанры();
            v1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Поиск_Жанры v2 = new Поиск_Жанры();
            v2.Show();
        }
    }
}
