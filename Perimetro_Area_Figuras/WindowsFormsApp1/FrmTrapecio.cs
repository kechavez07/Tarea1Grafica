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
    public partial class FrmTrapecio : Form
    {
        private Trapecio trapecio=new Trapecio();
        private static FrmTrapecio instance;
        public static FrmTrapecio Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmTrapecio();
                }
                return instance;
            }
        }
        public FrmTrapecio()
        {
            InitializeComponent();
        }

        private void FrmTrapecio_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            trapecio.LeerData(txtBaseMayor, txtBaseMenor, txtAltura,txtLado1,txtLado2);
            trapecio.CalcularArea();
            trapecio.CalcularPerimetro();
            trapecio.ImprimirData(txtArea, txtPerimetro);
        }
    }
}
