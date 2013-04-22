using System.Drawing;
using DotNet.Highcharts.Attributes;

namespace DotNet.Highcharts.Helpers
{
    public class BackColorOrGradient
    {
        public BackColorOrGradient(Color color) { Color = color; }

        public BackColorOrGradient(Gradient gradient) { Gradient = gradient; }

        [JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
        public Color? Color { get; private set; }

        [JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: true)]
        public Gradient Gradient { get; private set; }
    }

    public class Gradient
    {
        public int[] LinearGradient { get; set; }
        public object[,] Stops { get; set; }
    }
}