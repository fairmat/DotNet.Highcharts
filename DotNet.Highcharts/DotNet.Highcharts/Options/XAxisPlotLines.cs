using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// A line streching across the plot area, marking a specific value on one of the axes.
	/// </summary>
	public class XAxisPlotLines
	{
		/// <summary>
		/// The color of the line. Defaults to null
		/// </summary>
		public Color? Color { get; set; }

		/// <summary>
		/// The dashing or dot style for the plot line. For possible values see 
		/// this overview. Defaults to Solid
		/// </summary>
		public DashStyles? DashStyle { get; set; }

		/// <summary>
		/// An object defining mouse events for the plot line. Supported properties are click,
		/// mouseover, mouseout, mousemove.
		/// </summary>
		public Events Events { get; set; }

		/// <summary>
		/// An id used for identifying the plot line in Axis.removePlotLine. Defaults to null
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Text labels for the plot lines.
		/// </summary>
		public XAxisPlotLinesLabel Label { get; set; }

		/// <summary>
		/// The position of the line in axis units. Defaults to null
		/// </summary>
		public Number? Value { get; set; }

		/// <summary>
		/// The width or thickness of the plot line. Defaults to null
		/// </summary>
		public Number? Width { get; set; }

		/// <summary>
		/// The z index of the plot line within the chart. Defaults to null
		/// </summary>
		public Number? ZIndex { get; set; }

	}

}