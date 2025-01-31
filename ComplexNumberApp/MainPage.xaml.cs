namespace ComplexNumberApp // <-- Change this to match your project namespace
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); // This error happens if XAML and C# are not linked properly
        }

        private void OnCalculateClicked(object sender, EventArgs e)
        {
            if (double.TryParse(RealEntry.Text, out double x) &&
                double.TryParse(ImaginaryEntry.Text, out double y))
            {
                double abs = Math.Sqrt(x * x + y * y);
                double radians = Math.Atan2(y, x);
                double degrees = radians * (180 / Math.PI);
                if (degrees < 0) degrees += 360;

                ResultLabel.Text = $"Goniometric form:\n" +
                                   $"z = {abs:F2} (cos {degrees:F2}° + j sin {degrees:F2}°)";
                ResultLabel.IsVisible = true;
            }
            else
            {
                ResultLabel.Text = "Invalid input! Please enter valid numbers.";
                ResultLabel.TextColor = Colors.Red;
                ResultLabel.IsVisible = true;
            }
        }
    }
}
