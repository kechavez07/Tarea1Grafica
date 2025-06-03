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
    public partial class FrmRectangulo : Form
    {
        private Rectangulo rectangulo = new Rectangulo();
        private static FrmRectangulo instance;

        public static FrmRectangulo Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmRectangulo();
                }
                return instance;
            }
        }

        public FrmRectangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            rectangulo.LeerData(txtBase, txtAltura);
            rectangulo.CalcularArea();
            rectangulo.CalcularPerimetro();
            rectangulo.ImprimirData(txtArea, txtPerimetro);
        }
    }
}
