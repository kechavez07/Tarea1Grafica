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
    public partial class FrmHeptagono : Form
    {
        private Heptagono hept=new Heptagono();
        private static FrmHeptagono instance;
        public static FrmHeptagono Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmHeptagono();
                }
                return instance;
            }
        }
        public FrmHeptagono()
        {
            InitializeComponent();
        }

        private void FrmHeptagono_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            hept.LeerData(txtLado, txtApotema);
            hept.CalcularArea();
            hept.CalcularPerimetro();
            hept.ImprimirData(txtArea, txtPerimetro);
        }
    }
}
