using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class PlotOptionsSeriesMarker
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
		/// The radius of the point marker. Defaults to 0
		/// </summary>
		public Number? Radius { get; set; }

		/// <summary>
		/// Interaction states for the point marker.
		/// </summary>
		public PlotOptionsSeriesMarkerStates States { get; set; }

		/// <summary>
		/// A predefined shape or symbol for the marker. When null, the symbol is pulled from
		/// options.symbols. Other possible values are "circle", "square", "diamond", "triangle"
		/// and "triangle-down". Additionally, the URL to a graphic can be given on this form: 
		/// "url(graphic.png)". Defaults to null
		/// </summary>
		public string Symbol { get; set; }

	}

}