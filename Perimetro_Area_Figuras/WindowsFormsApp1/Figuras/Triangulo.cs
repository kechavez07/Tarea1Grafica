using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1.Figuras
{
    public class Triangulo:Figura
    {
        public double Lado { get; set; }
        public double Altura { get; set; }

        public Triangulo()
        {
            Lado = 0.0f;
            Altura = 0.0f;
            Area = 0.0f;
            Perimetro = 0.0f;
        }
        public void LeerData(TextBox txtLado, TextBox txtAltura)
        {
            try
            {
                Lado = double.Parse(txtLado.Text);
                Altura = double.Parse(txtAltura.Text);

                if (Lado < 0 || Altura < 0)
                {
                    Lado = 0.0f;
                    Altura = 0.0f;
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
        public override double CalcularArea()
        {
            return Area = (Lado * Altura) / 2;
        }
        public override double CalcularPerimetro()
        {
            return Perimetro = Lado * 3;
        }

        public void ImprimirData(TextBox txtArea,TextBox txtPerimetro)
        {

            txtArea.Text = Area.ToString();
            txtPerimetro.Text = Perimetro.ToString();
        }
    }

}
