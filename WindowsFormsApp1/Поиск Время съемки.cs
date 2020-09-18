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
    public partial class Поиск_Время_съемки : Form
    {
        public Поиск_Время_съемки()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.времяСъемкиprocTableAdapter.Fill(this.dataSet1.ВремяСъемкиproc, new System.Nullable<int>(((int)(System.Convert.ChangeType(годToolStripTextBox.Text, typeof(int))))), фильмToolStripTextBox.Text, фамилияToolStripTextBox.Text, имяToolStripTextBox.Text, отчествоToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
