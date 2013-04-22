using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class PlotOptionsArea : PlotOptionsSeries
	{
		/// <summary>
		/// Fill color or gradient for the area. When null, the series' color  is 
		/// used with the series' fillOpacity. Defaults to null
		/// </summary>
		public BackColorOrGradient FillColor { get; set; }

		/// <summary>
		/// Fill opacity for the area. Defaults to .75
		/// </summary>
		public Number? FillOpacity { get; set; }

		/// <summary>
		/// A separate color for the graph line. By default the line takes the color
		/// of the series, but the lineColor setting allows setting a separate
		/// color for the line without altering the fillColor. Defaults to null
		/// </summary>
		public Color? LineColor { get; set; }

		/// <summary>
		/// The Y axis value to serve as the base for the area, for distinguishing
		/// between values above and below a threshold. Defaults to 0
		/// </summary>
		public Number? Threshold { get; set; }

	}

}