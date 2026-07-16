
// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace RadialGaugeGettingStartedDesktop
{
    using Microsoft.UI;
    using Microsoft.UI.Text;
    using Microsoft.UI.Xaml;
    using Microsoft.UI.Xaml.Controls;
    using Microsoft.UI.Xaml.Media;
    using Syncfusion.UI.Xaml.Gauges;

    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            //SfRadialGauge sfRadialGauge = new SfRadialGauge();

            //RadialAxis radialAxis = new RadialAxis();
            //radialAxis.Maximum = 150;
            //sfRadialGauge.Axes.Add(radialAxis);

            //GaugeRange gaugeRange1 = new GaugeRange();
            //gaugeRange1.StartValue = 0;
            //gaugeRange1.EndValue = 50;
            //gaugeRange1.Background = new SolidColorBrush(Colors.Red);
            //radialAxis.Ranges.Add(gaugeRange1);

            //GaugeRange gaugeRange2 = new GaugeRange();
            //gaugeRange2.StartValue = 50;
            //gaugeRange2.EndValue = 100;
            //gaugeRange2.Background = new SolidColorBrush(Colors.Orange);
            //radialAxis.Ranges.Add(gaugeRange2);

            //GaugeRange gaugeRange3 = new GaugeRange();
            //gaugeRange3.StartValue = 100;
            //gaugeRange3.EndValue = 150;
            //gaugeRange3.Background = new SolidColorBrush(Colors.Green);
            //radialAxis.Ranges.Add(gaugeRange3);

            //NeedlePointer needlePointer = new NeedlePointer();
            //needlePointer.Value = 90;
            //radialAxis.Pointers.Add(needlePointer);

            //GaugeAnnotation gaugeAnnotation = new GaugeAnnotation();
            //gaugeAnnotation.DirectionUnit = AnnotationDirection.Angle;
            //gaugeAnnotation.DirectionValue = 90;
            //gaugeAnnotation.PositionFactor = 0.5;
            //gaugeAnnotation.Content = new TextBlock { Text = "90", FontWeight = FontWeights.Bold, FontSize = 25 };
            //radialAxis.Annotations.Add(gaugeAnnotation);

            //this.Content = sfRadialGauge;
        }
    }
}
