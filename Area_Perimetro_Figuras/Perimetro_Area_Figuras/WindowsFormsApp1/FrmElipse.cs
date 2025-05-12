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
    public partial class FrmElipse : Form
    {
        private Elipse elipse = new Elipse();
        private static FrmElipse instance;

        public static FrmElipse Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmElipse();
                }
                return instance;
            }
        }

        public FrmElipse()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            elipse.LeerData(txtEjeMayor, txtEjeMenor);
            elipse.CalcularArea();
            elipse.CalcularPerimetro();
            elipse.ImprimirData(txtArea, txtPerimetro);
        }
    }
}
