using JustWcfServiceReference;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace JustWpfFigureLab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private FigureContract _figure = new();


        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            using var figureServiceClient = new FigureServiceClient();
            _figure = figureServiceClient.Load();

            offsetTopBox.Text = _figure.OffsetTop.ToString();
            offsetLeftBox.Text = _figure.OffsetLeft.ToString();
            heightBox.Text = _figure.Height.ToString();
            widthBox.Text = _figure.Width.ToString();

            if (string.IsNullOrEmpty(_figure.Color) || _figure.Color.Length != 7)
                _figure.Color = "#ff0000";

            colorBox.Text = _figure.Color.Replace("#", "");

            canvasFigure.Margin = new Thickness(_figure.OffsetLeft, _figure.OffsetTop, 0, 0);
            canvasFigure.Height = _figure.Height;
            canvasFigure.Width = _figure.Width;
            canvasFigure.Fill = GetBrushFromColor(_figure.Color);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using var figureServiceClient = new FigureServiceClient();
            figureServiceClient.Save(_figure);
        }

        private void OffsetTop_TextChanged(object sender, TextChangedEventArgs e)
        {
            _figure.OffsetTop = int.TryParse(offsetTopBox.Text, out var x) ? x : _figure.OffsetTop;
            canvasFigure.Margin = new Thickness(_figure.OffsetLeft, _figure.OffsetTop, 0, 0);
        }

        private void OffsetLeft_TextChanged(object sender, TextChangedEventArgs e)
        {
            _figure.OffsetLeft = int.TryParse(offsetLeftBox.Text, out var x) ? x : _figure.OffsetLeft;
            canvasFigure.Margin = new Thickness(_figure.OffsetLeft, _figure.OffsetTop, 0, 0);
        }

        private void Height_TextChanged(object sender, TextChangedEventArgs e)
        {
            _figure.Height = int.TryParse(heightBox.Text, out var x) ? x : _figure.Height;
            canvasFigure.Height = _figure.Height;
        }

        private void Width_TextChanged(object sender, TextChangedEventArgs e)
        {
            _figure.Width = int.TryParse(widthBox.Text, out var x) ? x : _figure.Width;
            canvasFigure.Width = _figure.Width;
        }

        private void Color_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (colorBox.Text.Length > 6)
                colorBox.Text = colorBox.Text.Substring(0, 6);
            else if (colorBox.Text.Length < 6)
                return;
            _figure.Color = "#" + colorBox.Text.Trim();

            try
            {
                canvasFigure.Fill = GetBrushFromColor(_figure.Color);
            }
            catch (Exception)
            {
                _figure.Color = "#ff0000";
                canvasFigure.Fill = GetBrushFromColor(_figure.Color);
            }
        }

        private static SolidColorBrush GetBrushFromColor(string color)
        {
            byte R = Convert.ToByte(color.Substring(1, 2), 16);
            byte G = Convert.ToByte(color.Substring(3, 2), 16);
            byte B = Convert.ToByte(color.Substring(5, 2), 16);
            return new SolidColorBrush(Color.FromRgb(R, G, B));
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
