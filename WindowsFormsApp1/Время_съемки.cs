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
    public partial class Время_съемки : Form
    {
        public Время_съемки()
        {
            InitializeComponent();
        }

        private void время_съемкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.время_съемкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.фильмыDataSet);

        }

        private void Время_съемки_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet.Актеры". При необходимости она может быть перемещена или удалена.
            this.актерыTableAdapter.Fill(this.фильмыDataSet.Актеры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.фильмыTableAdapter.Fill(this.фильмыDataSet.Фильмы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet.Время_съемки". При необходимости она может быть перемещена или удалена.
            this.время_съемкиTableAdapter.Fill(this.фильмыDataSet.Время_съемки);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Время_съемкиТАБЛ v1 = new Время_съемкиТАБЛ();
            v1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.время_съемкиBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.время_съемкиBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.время_съемкиBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.время_съемкиBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.время_съемкиBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.время_съемкиBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.время_съемкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.фильмыDataSet);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Отчет_таблицы_Время_съемки v2 = new Отчет_таблицы_Время_съемки();
            v2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Поиск_Время_съемки v3 = new Поиск_Время_съемки();
            v3.Show();
        }
    }
}
