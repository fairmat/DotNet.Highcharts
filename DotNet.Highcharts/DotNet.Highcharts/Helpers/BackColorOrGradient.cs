using System.Drawing;
using DotNet.Highcharts.Attributes;

namespace DotNet.Highcharts.Helpers
{
    // This must be set specifically as it's a special case which needs brackets
    // for the Gradient and no brackets for the Color.
    [JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
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