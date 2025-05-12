using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Figuras
{
    public class TrapecioIsosceles:Figura
    {
        public double BaseMayor { get; set; }
        public double BaseMenor { get; set; }
        public double Altura { get; set; }
        public double Lado { get; set; }

        public TrapecioIsosceles()
        {
            BaseMayor= 0.0f;
            BaseMenor = 0.0f;
            Altura = 0.0f;
            Lado = 0.0f;
            Area = 0.0f;
            Perimetro = 0.0f;
        }
        public override double CalcularArea()
        {
            return Area=((BaseMayor + BaseMenor) * Altura) / 2;
        }
        public override double CalcularPerimetro()
        {
            return Perimetro=BaseMayor + BaseMenor + 2 * Lado;
        }
        public void LeerData(TextBox txtBaseMayor, TextBox txtBaseMenor, TextBox txtAltura, TextBox txtLado)
        {
            try
            {
                BaseMayor = double.Parse(txtBaseMayor.Text);
                BaseMenor = double.Parse(txtBaseMenor.Text);
                Altura = double.Parse(txtAltura.Text);
                Lado = double.Parse(txtLado.Text);

                if (BaseMayor < 0 || BaseMenor < 0 || Altura < 0 || Lado < 0)
                {
                    BaseMayor = 0.0f;
                    BaseMenor = 0.0f;
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
