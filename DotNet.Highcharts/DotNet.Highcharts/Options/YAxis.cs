using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// The Y axis or value axis. Normally this is the vertical axis, though if the 
	/// chart is inverted this is the horiontal axis. In case of multiple axes, the yAxis
	/// node is an array of configuration objects.
	/// See the Axis object for programmatic
	/// access to the axis.
	/// </summary>
	public class YAxis : XAxis
	{
		/// <summary>
		/// Whether to force the axis to end on a tick. Use this option with the maxPadding
		/// option to control the axis end. Defaults to true
		/// </summary>
		public bool? EndOnTick { get; set; }

		/// <summary>
		/// The width of the grid lines extending the ticks across the plot area. Defaults to 1
		/// </summary>
		public Number? GridLineWidth { get; set; }

		/// <summary>
		/// The width of the line marking the axis itself. Defaults to 0
		/// </summary>
		public Number? LineWidth { get; set; }

		/// <summary>
		/// Padding of the max value relative to the length of the axis. A padding of 0.05 will make
		/// a 100px axis 5px longer. This is useful when you don't want the highest data
		/// value to appear on the edge of the plot area. Defaults to 0.05
		/// </summary>
		public Number? MaxPadding { get; set; }

		/// <summary>
		/// Padding of the min value relative to the length of the axis. A padding of 0.05 will make
		/// a 100px axis 5px longer. This is useful when you don't want the lowest data
		/// value to appear on the edge of the plot area. Defaults to 0.05
		/// </summary>
		public Number? MinPadding { get; set; }

		/// <summary>
		/// Whether to show the last tick label. Defaults to true
		/// </summary>
		public bool? ShowLastLabel { get; set; }

		/// <summary>
		/// Configuration object for the labels containing the stack total, usually displaying the total 
		/// value for a stacked column or bar chart.
		/// </summary>
		public YAxisStackLabels StackLabels { get; set; }

		/// <summary>
		/// Whether to force the axis to start on a tick. Use this option with the maxPadding
		/// option to control the axis start. Defaults to true
		/// </summary>
		public bool? StartOnTick { get; set; }

		/// <summary>
		/// The pixel width of the major tick marks. Defaults to 0
		/// </summary>
		public Number? TickWidth { get; set; }

	}

}