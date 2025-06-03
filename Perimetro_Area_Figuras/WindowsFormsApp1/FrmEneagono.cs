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
    public partial class FrmEneagono : Form
    {
        private Eneagono eneagono = new Eneagono();
        private static FrmEneagono instance;

        public static FrmEneagono Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmEneagono();
                }
                return instance;
            }
        }

        public FrmEneagono()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            eneagono.LeerData(txtLado);
            eneagono.CalcularArea();
            eneagono.CalcularPerimetro();
            eneagono.ImprimirData(txtArea, txtPerimetro, txtApotema);
        }

        private void lblHeptagono_Click(object sender, EventArgs e)
        {
            // Puedes eliminar esto si no se usa
        }

        private void FrmEneagono_Load(object sender, EventArgs e)
        {

        }
    }
}
