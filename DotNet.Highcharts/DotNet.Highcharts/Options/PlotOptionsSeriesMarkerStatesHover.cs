using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class PlotOptionsSeriesMarkerStatesHover
	{
		/// <summary>
		/// Enable or disable the point marker. Defaults to true
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// The fill color of the point marker. When null, the series' or point's color
		/// is used. Defaults to null
		/// </summary>
		public Color? FillColor { get; set; }

		/// <summary>
		/// The color of the point marker's outline. When null, the series' or point's color
		/// is used. Defaults to "#FFFFFF"
		/// </summary>
		public Color? LineColor { get; set; }

		/// <summary>
		/// The width of the point marker's outline. Defaults to 0
		/// </summary>
		public Number? LineWidth { get; set; }

		/// <summary>
		/// The radius of the point marker. In hover state, it defaults
		/// to the normal state's radius + 2.
		/// </summary>
		public Number? Radius { get; set; }

	}

}