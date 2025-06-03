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
    public partial class FrmPentagono : Form
    {
        private Pentagono pentagono = new Pentagono();
        private static FrmPentagono instance;
        public static FrmPentagono Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmPentagono();
                }
                return instance;
            }
        }
        public FrmPentagono()
        {
            InitializeComponent();
        }

        private void FrmPentagono_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            pentagono.LeerData(txtLado, txtApotema);
            pentagono.CalcularArea();
            pentagono.CalcularPerimetro();
            pentagono.ImprimirData(txtArea, txtPerimetro);
        }
    }
}
