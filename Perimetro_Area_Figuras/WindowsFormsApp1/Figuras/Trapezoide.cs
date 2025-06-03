using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Figuras
{
    public class Trapezoide : Figura
    {
        public double BaseMayor { get; set; }
        public double BaseMenor { get; set; }
        public double Altura { get; set; }
        public double Lado1 { get; set; } // Lado lateral izquierdo
        public double Lado2 { get; set; } // Lado lateral derecho

        public Trapezoide()
        {
            BaseMayor = 0.0f;
            BaseMenor = 0.0f;
            Altura = 0.0f;
            Lado1 = 0.0f;
            Lado2 = 0.0f;
            Area = 0.0f;
            Perimetro = 0.0f;
        }

        public override double CalcularArea()
        {
            Area = Math.Round(((BaseMayor + BaseMenor) * Altura) / 2);
            return Area;
        }

        public override double CalcularPerimetro()
        {
            Perimetro = Math.Round(BaseMayor + BaseMenor + Lado1 + Lado2);
            return Perimetro;
        }

        public void LeerData(TextBox txtBaseMayor, TextBox txtBaseMenor, TextBox txtAltura, TextBox txtLado1, TextBox txtLado2)
        {
            try
            {
                BaseMayor = double.Parse(txtBaseMayor.Text);
                BaseMenor = double.Parse(txtBaseMenor.Text);
                Altura = double.Parse(txtAltura.Text);
                Lado1 = double.Parse(txtLado1.Text);
                Lado2 = double.Parse(txtLado2.Text);

                if (BaseMayor <= 0 || BaseMenor <= 0 || Altura <= 0 || Lado1 <= 0 || Lado2 <= 0)
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
