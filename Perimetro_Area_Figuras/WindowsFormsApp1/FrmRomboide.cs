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
    public partial class FrmRomboide : Form
    {
        private Romboide romboide=new Romboide();
        private static FrmRomboide instance;
        public static FrmRomboide Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmRomboide();
                }
                return instance;
            }
        }
        public FrmRomboide()
        {
            InitializeComponent();
        }

        private void FrmRomboide_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            romboide.LeerData(txtBase, txtAltura, txtLado);
            romboide.CalcularArea();
            romboide.CalcularPerimetro();
            romboide.ImprimirData(txtArea, txtPerimetro);
        }
    }
}
