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
    public partial class Отчет_таблицы_Режиссеры : Form
    {
        public Отчет_таблицы_Режиссеры()
        {
            InitializeComponent();
        }

        private void Отчет_таблицы_Режиссеры_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ФильмыDataSet.Режисссеры". При необходимости она может быть перемещена или удалена.
            this.РежисссерыTableAdapter.Fill(this.ФильмыDataSet.Режисссеры);

            this.reportViewer1.RefreshReport();
        }
    }
}
