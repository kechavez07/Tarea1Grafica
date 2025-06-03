using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Figuras
{
    public class Circulo:Figura
    {
        public double Radio { get; set; }
        public Circulo()
        {
            Radio = 0.0f;
            Area = 0.0f;
            Perimetro = 0.0f;
        }
        public void LeerData(TextBox txtRadio)
        {
            try
            {
                Radio = double.Parse(txtRadio.Text);

                if (Radio < 0)
                {
                    Radio = 0.0f;
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
            return Area= Math.PI * Radio * Radio;

        }
        public override double CalcularPerimetro()
        {
            return Perimetro= 2*Math.PI*Radio;
        }
    }
}
