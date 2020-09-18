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
    public partial class Фильмы : Form
    {
        public Фильмы()
        {
            InitializeComponent();
        }

        private void фильмыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.фильмыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.фильмыDataSet);

        }

        private void Фильмы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet.Режисссеры". При необходимости она может быть перемещена или удалена.
            this.режисссерыTableAdapter.Fill(this.фильмыDataSet.Режисссеры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.фильмыTableAdapter.Fill(this.фильмыDataSet.Фильмы);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ФильмыТАБЛ v1 = new ФильмыТАБЛ();
            v1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.фильмыBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.фильмыBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.фильмыBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.фильмыBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.фильмыBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.фильмыBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.фильмыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.фильмыDataSet);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Отчет_тыблицы_Фильмы v2 = new Отчет_тыблицы_Фильмы();
            v2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Поиск_Фильмы v3 = new Поиск_Фильмы();
            v3.Show();
        }
    }
}
