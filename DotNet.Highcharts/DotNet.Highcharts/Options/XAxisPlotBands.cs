using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// <p>A colored band stretching across the plot area marking an interval on the axis.</p><p>In a gauge, a plot band on the Y axis (value axis) will stretch along the perimiter of the gauge.</p>
	/// </summary>
	public class XAxisPlotBands
	{
		/// <summary>
		/// The color of the plot band.
		/// </summary>
		public Color? Color { get; set; }

		/// <summary>
		/// An object defining mouse events for the plot band. Supported properties are <code>click</code>, <code>mouseover</code>, <code>mouseout</code>, <code>mousemove</code>.
		/// </summary>
		public Events Events { get; set; }

		/// <summary>
		/// The start position of the plot band in axis units.
		/// </summary>
		public Number? From { get; set; }

		/// <summary>
		/// An id used for identifying the plot band in Axis.removePlotBand.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Text labels for the plot bands
		/// </summary>
		public XAxisPlotBandsLabel Label { get; set; }

		/// <summary>
		/// The end position of the plot band in axis units.
		/// </summary>
		public Number? To { get; set; }

		/// <summary>
		/// The z index of the plot band within the chart.
		/// </summary>
		public Number? ZIndex { get; set; }

	}

}