using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// A colored band stretching across the plot area marking an interval on the axis.
	/// </summary>
	public class XAxisPlotBands
	{
		/// <summary>
		/// The color of the plot band. Defaults to null
		/// </summary>
		public Color? Color { get; set; }

		/// <summary>
		/// An object defining mouse events for the plot band. Supported properties are click,
		/// mouseover, mouseout, mousemove.
		/// </summary>
		public Events Events { get; set; }

		/// <summary>
		/// The start position of the plot band in axis units. Defaults to null
		/// </summary>
		public Number? From { get; set; }

		/// <summary>
		/// An id used for identifying the plot band in Axis.removePlotBand. Defaults to null
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Text labels for the plot bands.
		/// </summary>
		public XAxisPlotBandsLabel Label { get; set; }

		/// <summary>
		/// The end position of the plot band in axis units. Defaults to null
		/// </summary>
		public Number? To { get; set; }

		/// <summary>
		/// The z index of the plot band within the chart. Defaults to null
		/// </summary>
		public Number? ZIndex { get; set; }

	}

}