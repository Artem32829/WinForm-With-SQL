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
    public partial class Время_записиТАБЛ : Form
    {
        public Время_записиТАБЛ()
        {
            InitializeComponent();
        }

        private void Время_записиТАБЛ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet._Год_записи___название_фильма". При необходимости она может быть перемещена или удалена.
            this.год_записи___название_фильмаTableAdapter.Fill(this.фильмыDataSet._Год_записи___название_фильма);

        }
    }
}
