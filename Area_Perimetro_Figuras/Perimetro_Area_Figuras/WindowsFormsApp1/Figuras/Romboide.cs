using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Figuras
{
    public class Romboide:Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Lado { get; set; }

        public Romboide()
        {
            Base= 0.0f;
            Altura = 0.0f;
            Lado = 0.0f;
            Area = 0.0f;
            Perimetro = 0.0f;
        }
        public override double CalcularArea()
        {
            return Area=Base * Altura;
        }
        public override double CalcularPerimetro()
        {
            return Perimetro=2 * (Base + Lado);
        }
        public void LeerData(TextBox txtBase, TextBox txtAltura, TextBox txtLado)
        {
            try
            {
                Base = double.Parse(txtBase.Text);
                Altura = double.Parse(txtAltura.Text);
                Lado = double.Parse(txtLado.Text);
                if (Base < 0 || Altura < 0 || Lado < 0)
                {
                    Base = 0.0f;
                    Altura = 0.0f;
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
    }
}
