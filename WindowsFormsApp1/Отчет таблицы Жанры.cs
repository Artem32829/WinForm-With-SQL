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
    public partial class Отчет_таблицы_Жанры : Form
    {
        public Отчет_таблицы_Жанры()
        {
            InitializeComponent();
        }

        private void Отчет_таблицы_Жанры_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ФильмыDataSet.Жанры". При необходимости она может быть перемещена или удалена.
            this.ЖанрыTableAdapter.Fill(this.ФильмыDataSet.Жанры);

            this.reportViewer1.RefreshReport();
        }
    }
}
