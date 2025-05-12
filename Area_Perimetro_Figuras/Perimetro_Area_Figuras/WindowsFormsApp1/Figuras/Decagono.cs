using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Figuras
{
    public class Decagono:Figura
    {
        public double Lado { get; set; }
        public double Apotema { get; set; }

        public Decagono()
        {
            Lado = 0.0f;
            Apotema = 0.0f;
            Area = 0.0f;
            Perimetro = 0.0f;
        }
        public override double CalcularArea()
        {
            double perimetro = 10 * Lado;
            return Area=(perimetro * Apotema) / 2;
        }
        public override double CalcularPerimetro()
        {
            return Perimetro=10 * Lado;
        }
        public void LeerData(TextBox txtLado, TextBox txtApotema)
        {
            try
            {
                Lado = double.Parse(txtLado.Text);
                Apotema = double.Parse(txtApotema.Text);
                if (Lado < 0 || Apotema < 0)
                {
                    Lado = 0.0f;
                    Apotema = 0.0f;
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
    }

}
