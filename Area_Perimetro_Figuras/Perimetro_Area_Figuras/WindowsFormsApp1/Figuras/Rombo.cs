using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Figuras
{
    public class Rombo : Figura
    {
        public double DiagonalMayor { get; set; }
        public double DiagonalMenor { get; set; }
        public double Lado { get; set; }

        public Rombo()
        {
            DiagonalMayor = 0.0f;
            DiagonalMenor = 0.0f;
            Lado = 0.0f;
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
            Perimetro = Math.Round(4 * Lado);
            return Perimetro;
        }

        public void LeerData(TextBox txtDiagonalMayor, TextBox txtDiagonalMenor, TextBox txtLado)
        {
            try
            {
                DiagonalMayor = double.Parse(txtDiagonalMayor.Text);
                DiagonalMenor = double.Parse(txtDiagonalMenor.Text);
                Lado = double.Parse(txtLado.Text);

                if (DiagonalMayor <= 0 || DiagonalMenor <= 0 || Lado <= 0)
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
