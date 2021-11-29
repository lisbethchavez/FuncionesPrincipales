using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallWin
{
    public partial class frmSumaFactorial : Form
    {
        public frmSumaFactorial()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            BibliotecadeFunciones.Operaciones ob1 = new BibliotecadeFunciones.Operaciones();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            num = int.Parse(Console.ReadLine()); 
        }
    }
}
