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
    public partial class FrmHexagono : Form
    {
        private Hexagono hexagono = new Hexagono();
        private static FrmHexagono instance;

        public static FrmHexagono Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmHexagono();
                }
                return instance;
            }
        }

        public FrmHexagono()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            hexagono.LeerData(txtLado);
            hexagono.CalcularArea();
            hexagono.CalcularPerimetro();
            hexagono.ImprimirData(txtArea, txtPerimetro, txtApotema);
        }
    }
}
