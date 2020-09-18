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
    public partial class НосительТАБЛ : Form
    {
        public НосительТАБЛ()
        {
            InitializeComponent();
        }

        private void НосительТАБЛ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet._Название_носител_память". При необходимости она может быть перемещена или удалена.
            this.название_носител_памятьTableAdapter.Fill(this.фильмыDataSet._Название_носител_память);

        }
    }
}
