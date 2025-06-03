using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Figuras
{
    public class Ovalo : Figura
    {
        public double EjeMayor { get; set; }
        public double EjeMenor { get; set; }

        public Ovalo()
        {
            EjeMayor = 0.0f;
            EjeMenor = 0.0f;
            Area = 0.0f;
            Perimetro = 0.0f;
        }

        public override double CalcularArea()
        {
            Area = Math.Round(Math.PI * EjeMayor * EjeMenor);
            return Area;
        }

        public override double CalcularPerimetro()
        {
            // Usamos nuevamente la fórmula aproximada de Ramanujan para perímetro de una elipse
            double a = EjeMayor;
            double b = EjeMenor;
            double h = Math.Pow((a - b), 2) / Math.Pow((a + b), 2);
            Perimetro = Math.Round(Math.PI * (a + b) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h))));
            return Perimetro;
        }

        public void LeerData(TextBox txtEjeMayor, TextBox txtEjeMenor)
        {
            try
            {
                EjeMayor = double.Parse(txtEjeMayor.Text);
                EjeMenor = double.Parse(txtEjeMenor.Text);

                if (EjeMayor <= 0 || EjeMenor <= 0)
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
