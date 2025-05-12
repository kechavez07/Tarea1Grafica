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
    public partial class FrmOctagono : Form
    {
        private Octagono octagono = new Octagono();
        private static FrmOctagono instance;

        public static FrmOctagono Instance
        {
            get 
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmOctagono();
                }
                return instance;
            }
        }

        public FrmOctagono()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            octagono.LeerData(txtLado);
            octagono.CalcularArea();
            octagono.CalcularPerimetro();
            octagono.ImprimirData(txtArea, txtPerimetro, txtApotema);
        }

       
    }
}
