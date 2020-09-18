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
    public partial class Отчёт_таблицы_Использование : Form
    {
        public Отчёт_таблицы_Использование()
        {
            InitializeComponent();
        }

        private void Отчёт_таблицы_Использование_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Отчеты.Отчет_Использование". При необходимости она может быть перемещена или удалена.
            this.Отчет_ИспользованиеTableAdapter.Fill(this.Отчеты.Отчет_Использование);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ФильмыDataSet.Использование". При необходимости она может быть перемещена или удалена.
            this.ИспользованиеTableAdapter.Fill(this.ФильмыDataSet.Использование);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
