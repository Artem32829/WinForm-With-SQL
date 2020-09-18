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
    public partial class Отчет_таблицы_Носитель : Form
    {
        public Отчет_таблицы_Носитель()
        {
            InitializeComponent();
        }

        private void Отчет_таблицы_Носитель_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Отчеты.Отчет_Носитель". При необходимости она может быть перемещена или удалена.
            this.Отчет_НосительTableAdapter.Fill(this.Отчеты.Отчет_Носитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ФильмыDataSet.Носитель". При необходимости она может быть перемещена или удалена.
            this.НосительTableAdapter.Fill(this.ФильмыDataSet.Носитель);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
