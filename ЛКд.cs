using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УчебнаяПрактика1
{
    public partial class ЛКд : Form
    {
        public ЛКд()
        {
            InitializeComponent();
        }

        

        private void ЛКд_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учетDataSet.Sotrydnik". При необходимости она может быть перемещена или удалена.
            this.sotrydnikTableAdapter.Fill(this.учетDataSet.Sotrydnik);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
