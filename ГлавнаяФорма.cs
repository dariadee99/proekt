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
    public partial class ГлавнаяФорма : Form
    {
        public ГлавнаяФорма()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Авторизация sqp = new Авторизация();
            sqp.Show();
            this.Hide();
        }
    }
}
