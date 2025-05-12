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
    public partial class FrmTrapezoide : Form
    {
        private Trapezoide trapezoide = new Trapezoide();
        private static FrmTrapezoide instance;

        public static FrmTrapezoide Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmTrapezoide();
                }
                return instance;
            }
        }

        public FrmTrapezoide()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            trapezoide.LeerData(txtBaseMayor, txtBaseMenor, txtAltura, txtLado1, txtLado2);
            trapezoide.CalcularArea();
            trapezoide.CalcularPerimetro();
            trapezoide.ImprimirData(txtArea, txtPerimetro);
        }
    }
}
