using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Figuras
{
    public class Rectangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Rectangulo()
        {
            Base = 0.0f;
            Altura = 0.0f;
            Area = 0.0f;
            Perimetro = 0.0f;
        }

        public override double CalcularArea()
        {
            Area = Math.Round(Base * Altura);
            return Area;
        }

        public override double CalcularPerimetro()
        {
            Perimetro = Math.Round(2 * (Base + Altura));
            return Perimetro;
        }

        public void LeerData(TextBox txtBase, TextBox txtAltura)
        {
            try
            {
                Base = double.Parse(txtBase.Text);
                Altura = double.Parse(txtAltura.Text);

                if (Base <= 0 || Altura <= 0)
                {
                    throw new ArgumentException("Los valores deben ser positivos.");
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
