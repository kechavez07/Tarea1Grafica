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
    public partial class FrmTriangulo : Form
    {
        private Triangulo triangulo= new Triangulo();
        private static FrmTriangulo instance;
        public static FrmTriangulo Instance 
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmTriangulo();
                }
                return instance;
            }
        }
        public FrmTriangulo()
        {
            InitializeComponent();
        }

        private void FrmTriangulo_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            triangulo.LeerData(txtLado, txtAltura);
            triangulo.CalcularArea();
            triangulo.CalcularPerimetro();
            triangulo.ImprimirData(txtArea,txtPerimetro);
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTiPer_Click(object sender, EventArgs e)
        {

        }

        private void lblTiArea_Click(object sender, EventArgs e)
        {

        }

        private void txtPerimetro_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTriangulo_Click(object sender, EventArgs e)
        {

        }
    }
}
