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
    public partial class Носитель : Form
    {
        public Носитель()
        {
            InitializeComponent();
        }

        private void носительBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.носительBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.фильмыDataSet);

        }

        private void Носитель_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet.Вид_носителя". При необходимости она может быть перемещена или удалена.
            this.вид_носителяTableAdapter.Fill(this.фильмыDataSet.Вид_носителя);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet.Носитель". При необходимости она может быть перемещена или удалена.
            this.носительTableAdapter.Fill(this.фильмыDataSet.Носитель);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            НосительТАБЛ v1 = new НосительТАБЛ();
            v1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.носительBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.носительBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.носительBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.носительBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.носительBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.носительBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.носительBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.фильмыDataSet);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Отчет_таблицы_Носитель v2 = new Отчет_таблицы_Носитель();
            v2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Поиск_Носитель v3 = new Поиск_Носитель();
            v3.Show();
        }
    }
}
