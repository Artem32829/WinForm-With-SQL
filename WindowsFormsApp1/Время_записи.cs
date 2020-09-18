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
    public partial class Время_записи : Form
    {
        public Время_записи()
        {
            InitializeComponent();
        }

        private void время_записиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.время_записиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.фильмыDataSet);

        }

        private void Время_записи_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.фильмыTableAdapter.Fill(this.фильмыDataSet.Фильмы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet.Вид_носителя". При необходимости она может быть перемещена или удалена.
            this.вид_носителяTableAdapter.Fill(this.фильмыDataSet.Вид_носителя);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet.Носитель". При необходимости она может быть перемещена или удалена.
            this.носительTableAdapter.Fill(this.фильмыDataSet.Носитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet.Время_записи". При необходимости она может быть перемещена или удалена.
            this.время_записиTableAdapter.Fill(this.фильмыDataSet.Время_записи);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Время_записиТАБЛ v1 = new Время_записиТАБЛ();
            v1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.время_записиBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.время_записиBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.время_записиBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.время_записиBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.время_записиBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.время_записиBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.время_записиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.фильмыDataSet);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Отчёт_таблицы_Время_записи v2 = new Отчёт_таблицы_Время_записи();
            v2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Поиск_Время_записи v3 = new Поиск_Время_записи();
            v3.Show();
        }
    }
}
