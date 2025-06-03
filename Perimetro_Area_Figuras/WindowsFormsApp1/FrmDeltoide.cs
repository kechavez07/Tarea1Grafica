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
    public partial class FrmDeltoide : Form
    {
        private Deltoide deltoide = new Deltoide();
        private static FrmDeltoide instance;

        public static FrmDeltoide Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmDeltoide();
                }
                return instance;
            }
        }

        public FrmDeltoide()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            deltoide.LeerData(txtDiagonalMayor, txtDiagonalMenor, txtLadoMayor, txtLadoMenor);
            deltoide.CalcularArea();
            deltoide.CalcularPerimetro();
            deltoide.ImprimirData(txtArea, txtPerimetro);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
