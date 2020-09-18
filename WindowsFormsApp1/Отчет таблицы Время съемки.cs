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
    public partial class Отчет_таблицы_Время_съемки : Form
    {
        public Отчет_таблицы_Время_съемки()
        {
            InitializeComponent();
        }

        private void Отчет_таблицы_Время_съемки_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Отчеты.Отчет_Время_съемки". При необходимости она может быть перемещена или удалена.
            this.Отчет_Время_съемкиTableAdapter.Fill(this.Отчеты.Отчет_Время_съемки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ФильмыDataSet.Время_съемки". При необходимости она может быть перемещена или удалена.
            this.Время_съемкиTableAdapter.Fill(this.ФильмыDataSet.Время_съемки);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
