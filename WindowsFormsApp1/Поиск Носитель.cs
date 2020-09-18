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
    public partial class Поиск_Носитель : Form
    {
        public Поиск_Носитель()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.носительprocTableAdapter.Fill(this.dataSet1.Носительproc, new System.Nullable<int>(((int)(System.Convert.ChangeType(памятьToolStripTextBox.Text, typeof(int))))), названиеToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
