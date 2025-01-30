using Microsoft.Maui.Controls;

namespace ComplexGuiAddaptation
{
    public class MainPage : ContentPage
    {
        private Entry inputX, inputY;
        private Button calculateButton;
        private Label resultLabel;

        public MainPage()
        {
            Title = "Complex Number Calculator";

            Label labelX = new Label { Text = "x:" };
            inputX = new Entry { Placeholder = "Enter x" };

            Label labelY = new Label { Text = "y:" };
            inputY = new Entry { Placeholder = "Enter y" };

            calculateButton = new Button { Text = "Calculate" };
            calculateButton.Clicked += CalculateComplex;

            resultLabel = new Label { Text = "Result will appear here", FontSize = 16, TextColor = Microsoft.Maui.Graphics.Colors.DarkGreen };

            Content = new VerticalStackLayout
            {
                Padding = new Thickness(20),
                Children = { labelX, inputX, labelY, inputY, calculateButton, resultLabel }
            };
        }

        private void CalculateComplex(object sender, EventArgs e)
        {
            if (double.TryParse(inputX.Text, out double x) && double.TryParse(inputY.Text, out double y))
            {
                double abs = Math.Sqrt(x * x + y * y);
                double radians = Math.Atan2(y, x);
                double degrees = radians * (180 / Math.PI);
                if (degrees < 0) degrees += 360;

                resultLabel.Text = $"z = {abs:F2} (cos {degrees:F5}° + j sin {degrees:F5}°)";
            }
            else
            {
                resultLabel.Text = "Invalid input. Please enter numeric values.";
            }
        }
    }
}
