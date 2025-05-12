using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Figuras;

namespace WindowsFormsApp1
{
    public partial class FrmCuadrado : Form
    {
        private Cuadrado cuadrado = new Cuadrado();
        private static FrmCuadrado instance;
        public static FrmCuadrado Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmCuadrado();
                }
                return instance;
            }

        }
        public FrmCuadrado()
        {
            InitializeComponent();
        }

        private void FrmCuadrado_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            cuadrado.LeerData(txtLado);
            cuadrado.CalcularArea();
            cuadrado.CalcularPerimetro();
            cuadrado.ImprimirData(txtArea, txtPerimetro);
        }
    }
}
