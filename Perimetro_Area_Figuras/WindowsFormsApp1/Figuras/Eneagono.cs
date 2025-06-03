using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Figuras
{
    public class Eneagono : Figura
    {
        public double Lado { get; set; }
        public double Apotema { get; set; }

        public Eneagono()
        {
            Lado = 0.0f;
            Apotema = 0.0f;
            Area = 0.0f;
            Perimetro = 0.0f;
        }

        public override double CalcularArea()
        {
            double angulo = Math.PI / 9; // 20 grados en radianes
            Apotema = Math.Round(Lado / (2 * Math.Tan(angulo))); 
            Area = Math.Round((CalcularPerimetro() * Apotema) / 2);
            return Area;
        }

        public override double CalcularPerimetro()
        {
            return Perimetro = 9 * Lado;
        }

        public void LeerData(TextBox txtLado)
        {
            try
            {
                Lado = double.Parse(txtLado.Text);
                if (Lado <= 0)
                {
                    Lado = 0.0f;
                    throw new ArgumentException("Los valores no pueden ser negativos.");
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

        public void ImprimirData(TextBox txtArea, TextBox txtPerimetro, TextBox txtApotema)
        {
            txtArea.Text = Area.ToString();
            txtPerimetro.Text = Perimetro.ToString();
            txtApotema.Text = Apotema.ToString();
        }
    }
}
