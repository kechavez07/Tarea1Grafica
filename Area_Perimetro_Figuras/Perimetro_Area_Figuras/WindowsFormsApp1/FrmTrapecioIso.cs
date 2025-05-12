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
    public partial class FrmTrapecioIso : Form
    {
        private TrapecioIsosceles trapecioIso=new TrapecioIsosceles();
        private static FrmTrapecioIso instance;
        public static FrmTrapecioIso Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmTrapecioIso();
                }
                return instance;
            }
        }
        public FrmTrapecioIso()
        {
            InitializeComponent();
        }

        private void FrmTrapecioIso_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            trapecioIso.LeerData(txtBaseMayor, txtBaseMenor, txtAltura, txtLado);
            trapecioIso.CalcularArea();
            trapecioIso.CalcularPerimetro();
            trapecioIso.ImprimirData(txtArea, txtPerimetro);
        }
    }
}
