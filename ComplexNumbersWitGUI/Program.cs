using System;
using System.Windows.Forms;

namespace ComplexNumberCalculatorGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Parse the user input
            double x = double.Parse(txtX.Text);
            double y = double.Parse(txtY.Text);

            // Calculate polar form
            double abs = Math.Sqrt(x * x + y * y);
            double radians = Math.Atan2(y, x);
            double degrees = radians * (180 / Math.PI);

            if (degrees < 0)
            {
                degrees += 360;
            }

            // Output the result
            lblResult.Text = $"Goniometrický Tvar komplexního čísla je:\n" +
                             $"z = {abs:F2} (cos {degrees:F5}° + j sin {degrees:F5}°)";
        }
    }
}
