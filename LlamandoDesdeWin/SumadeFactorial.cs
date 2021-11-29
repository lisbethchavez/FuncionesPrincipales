using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LlamandoDesdeWin
{
    public partial class frmSumaFactorial : Form
    {
        public frmSumaFactorial()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            BibliotecadeFunciones.Operaciones ob1 = new BibliotecadeFunciones.Operaciones();
            double x1 = ob1.suma(289.89, 100.00);
            double fac = ob1.factorial(5);
            
        }

        private void txtSuma_TextChanged(object sender, EventArgs e)
        {
            BibliotecadeFunciones.Operaciones ob1 = new BibliotecadeFunciones.Operaciones();
            double x1 = ob1.suma(289.89, 100.00);
            double fac = ob1.factorial(5);
        }
    }
}
    
    
