using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekz
{
    public partial class RazmMas : Form
    {
        public RazmMas()
        {
            InitializeComponent();
        }

        private void f2ok_Click(object sender, EventArgs e)
        {
            Ekz form = new Ekz();
            form.Show();
        }
    }
}
