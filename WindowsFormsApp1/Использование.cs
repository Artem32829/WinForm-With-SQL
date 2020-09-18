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
    public partial class Использование : Form
    {
        public Использование()
        {
            InitializeComponent();
        }

        private void использованиеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.использованиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.фильмыDataSet);

        }

        private void Использование_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.фильмыTableAdapter.Fill(this.фильмыDataSet.Фильмы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet.Жанры". При необходимости она может быть перемещена или удалена.
            this.жанрыTableAdapter.Fill(this.фильмыDataSet.Жанры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet.Использование". При необходимости она может быть перемещена или удалена.
            this.использованиеTableAdapter.Fill(this.фильмыDataSet.Использование);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ИспользованиеТАБЛ v1 = new ИспользованиеТАБЛ();
            v1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.использованиеBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.использованиеBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.использованиеBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.использованиеBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.использованиеBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.использованиеBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.использованиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.фильмыDataSet);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Отчёт_таблицы_Использование v2 = new Отчёт_таблицы_Использование();
            v2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Поиск_Использование v3 = new Поиск_Использование();
            v3.Show();
        }
    }
}
