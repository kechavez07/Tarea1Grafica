using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void círculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCirculo frmCirc= FrmCirculo.Instance;
            frmCirc.MdiParent = this;
            if(!frmCirc.Visible)
            {
                frmCirc.Show();
            }
            else
            {
                frmCirc.BringToFront();
            }
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCuadrado frmCuad = FrmCuadrado.Instance;
            frmCuad.MdiParent = this;
            if (!frmCuad.Visible)
            {
                frmCuad.Show();
            }
            else
            {
                frmCuad.BringToFront();
            }

        }

        private void triánguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriangulo frmTri = FrmTriangulo.Instance;
            frmTri.MdiParent = this;
            if (!frmTri.Visible)
            {
                frmTri.Show();
            }
            else
            {
                frmTri.BringToFront();
            }
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapecio frmTrap = FrmTrapecio.Instance;
            frmTrap.MdiParent = this;
            if (!frmTrap.Visible)
            {
                frmTrap.Show();
            }
            else
            {
                frmTrap.BringToFront();
            }
        }

        private void trapecioIsóscelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapecioIso frmTrapIso = FrmTrapecioIso.Instance;
            frmTrapIso.MdiParent = this;
            if (!frmTrapIso.Visible)
            {
                frmTrapIso.Show();
            }
            else
            {
                frmTrapIso.BringToFront();
            }
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRomboide frmRom = FrmRomboide.Instance;
            frmRom.MdiParent = this;
            if (!frmRom.Visible)
            {
                frmRom.Show();
            }
            else
            {
                frmRom.BringToFront();
            }
        }

        private void heptágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHeptagono frmHep = FrmHeptagono.Instance;
            frmHep.MdiParent = this;
            if (!frmHep.Visible)
            {
                frmHep.Show();
            }
            else
            {
                frmHep.BringToFront();
            }
        }

        private void decágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDecagono frmDec = FrmDecagono.Instance;
            frmDec.MdiParent = this;
            if (!frmDec.Visible)
            {
                frmDec.Show();
            }
            else
            {
                frmDec.BringToFront();
            }
        }

        private void pentágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPentagono frmPen = FrmPentagono.Instance;
            frmPen.MdiParent = this;
            if (!frmPen.Visible)
            {
                frmPen.Show();
            }
            else
            {
                frmPen.BringToFront();
            }
        }

        private void octagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOctagono frmOc = FrmOctagono.Instance;
            frmOc.MdiParent = this;
            if (!frmOc.Visible)
            {
                frmOc.Show();
            }
            else
            {
                frmOc.BringToFront();
            }
        }

        private void eneágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEneagono frmEn = FrmEneagono.Instance;
            frmEn.MdiParent = this;
            if (!frmEn.Visible)
            {
                frmEn.Show();
            }
            else
            {
                frmEn.BringToFront();
            }
        }

        private void hexágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHexagono frmHex = FrmHexagono.Instance;
            frmHex.MdiParent = this;
            if (!frmHex.Visible)
            {
                frmHex.Show();
            }
            else
            {
                frmHex.BringToFront();
            }
        }

        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapezoide frmtra = FrmTrapezoide.Instance;
            frmtra.MdiParent = this;
            if (!frmtra.Visible)
            {
                frmtra.Show();
            }
            else
            {
                frmtra.BringToFront();
            }
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRectangulo frmRec = FrmRectangulo.Instance;
            frmRec.MdiParent = this;
            if (!frmRec.Visible)
            {
                frmRec.Show();
            }
            else
            {
                frmRec.BringToFront();
            }
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRombo frmRom = FrmRombo.Instance;
            frmRom.MdiParent = this;
            if (!frmRom.Visible)
            {
                frmRom.Show();
            }
            else
            {
                frmRom.BringToFront();
            }
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmElipse frmEli = FrmElipse.Instance;
            frmEli.MdiParent = this;
            if (!frmEli.Visible)
            {
                frmEli.Show();
            }
            else
            {
                frmEli.BringToFront();
            }
        }

        private void óvaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOvalo frmOva = FrmOvalo.Instance;
            frmOva.MdiParent = this;
            if (!frmOva.Visible)
            {
                frmOva.Show();
            }
            else
            {
                frmOva.BringToFront();
            }
        }

        private void deltoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeltoide frmDel = FrmDeltoide.Instance;
            frmDel.MdiParent = this;
            if (!frmDel.Visible)
            {
                frmDel.Show();
            }
            else
            {
                frmDel.BringToFront();
            }
        }
    }
}
