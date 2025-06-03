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
    public partial class FrmOvalo : Form
    {
        private Ovalo ovalo = new Ovalo();
        private static FrmOvalo instance;

        public static FrmOvalo Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmOvalo();
                }
                return instance;
            }
        }

        public FrmOvalo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ovalo.LeerData(txtEjeMayor, txtEjeMenor);
            ovalo.CalcularArea();
            ovalo.CalcularPerimetro();
            ovalo.ImprimirData(txtArea, txtPerimetro);
        }
    }
}
