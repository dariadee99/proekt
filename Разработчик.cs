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
    public partial class Разработчик : Form
    {
        public Разработчик()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ЛКр spr = new ЛКр();
            spr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Авторизация spr = new Авторизация();
            spr.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Разработчик_Load(object sender, EventArgs e)
        {

        }
    }
}
