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
    public partial class FrmRombo : Form
    {
        private Rombo rombo = new Rombo();
        private static FrmRombo instance;

        public static FrmRombo Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmRombo();
                }
                return instance;
            }
        }

        public FrmRombo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            rombo.LeerData(txtDiagonalMayor, txtDiagonalMenor, txtLado);
            rombo.CalcularArea();
            rombo.CalcularPerimetro();
            rombo.ImprimirData(txtArea, txtPerimetro);
        }
    }
}
