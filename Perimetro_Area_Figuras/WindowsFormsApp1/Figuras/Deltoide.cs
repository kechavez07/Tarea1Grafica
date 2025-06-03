using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Figuras
{
    public class Deltoide : Figura
    {
        public double DiagonalMayor { get; set; }
        public double DiagonalMenor { get; set; }
        public double LadoMayor { get; set; }
        public double LadoMenor { get; set; }

        public Deltoide()
        {
            DiagonalMayor = 0.0f;
            DiagonalMenor = 0.0f;
            LadoMayor = 0.0f;
            LadoMenor = 0.0f;
            Area = 0.0f;
            Perimetro = 0.0f;
        }

        public override double CalcularArea()
        {
            Area = Math.Round((DiagonalMayor * DiagonalMenor) / 2);
            return Area;
        }

        public override double CalcularPerimetro()
        {
            Perimetro = Math.Round(2 * LadoMayor + 2 * LadoMenor);
            return Perimetro;
        }

        public void LeerData(TextBox txtDiagonalMayor, TextBox txtDiagonalMenor, TextBox txtLadoMayor, TextBox txtLadoMenor)
        {
            try
            {
                DiagonalMayor = double.Parse(txtDiagonalMayor.Text);
                DiagonalMenor = double.Parse(txtDiagonalMenor.Text);
                LadoMayor = double.Parse(txtLadoMayor.Text);
                LadoMenor = double.Parse(txtLadoMenor.Text);

                if (DiagonalMayor <= 0 || DiagonalMenor <= 0 || LadoMayor <= 0 || LadoMenor <= 0)
                {
                    throw new ArgumentException("Todos los valores deben ser positivos.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar valores numéricos.", "Error de formato");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Valor no permitido");
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void ImprimirData(TextBox txtArea, TextBox txtPerimetro)
        {
            txtArea.Text = Area.ToString();
            txtPerimetro.Text = Perimetro.ToString();
        }
    }
}
