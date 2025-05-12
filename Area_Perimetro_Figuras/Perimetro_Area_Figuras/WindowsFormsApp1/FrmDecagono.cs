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
    public partial class FrmDecagono : Form
    {
        private Decagono decagono = new Decagono();
        private static FrmDecagono instance;
        public static FrmDecagono Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmDecagono();
                }
                return instance;
            }
        }
        public FrmDecagono()
        {
            InitializeComponent();
        }

        private void FrmDecagono_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decagono.LeerData(txtLado, txtApotema);
            decagono.CalcularArea();
            decagono.CalcularPerimetro();
            decagono.ImprimirData(txtArea, txtPerimetro);
        }
    }
}
