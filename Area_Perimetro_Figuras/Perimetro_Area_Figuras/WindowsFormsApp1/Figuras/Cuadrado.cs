using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Figuras
{
    public class Cuadrado:Figura
    {
        public double Lado { get; set; }
        public Cuadrado()
        {
            Lado = 0.0f;
            Area = 0.0f;
            Perimetro = 0.0f;
        }
        public void LeerData(TextBox txtLado)
        {
            try
            {
                Lado = double.Parse(txtLado.Text);

                if (Lado < 0)
                {
                    Lado = 0.0f;
                    throw new ArgumentException("Los valores no pueden ser negativos.");

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar valores numéricos.",
                                "Error de formato");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message,
                                "Valor no permitido");
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...",
                                "Mensaje de error");
            }
        }
        public void ImprimirData(TextBox txtArea, TextBox txtPerimetro)
        {

            txtArea.Text = Area.ToString();
            txtPerimetro.Text = Perimetro.ToString();
        }

        public override double CalcularArea()
        {
            return Area=Lado * Lado;
        }
        public override double CalcularPerimetro()
        {
            return Perimetro=4 * Lado;
        }
    }
}
