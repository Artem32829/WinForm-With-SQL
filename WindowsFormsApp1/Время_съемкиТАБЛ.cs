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
    public partial class Время_съемкиТАБЛ : Form
    {
        public Время_съемкиТАБЛ()
        {
            InitializeComponent();
        }

        private void Время_съемкиТАБЛ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet._Год_съемки_фильм_актер". При необходимости она может быть перемещена или удалена.
            this.год_съемки_фильм_актерTableAdapter.Fill(this.фильмыDataSet._Год_съемки_фильм_актер);

        }
    }
}
