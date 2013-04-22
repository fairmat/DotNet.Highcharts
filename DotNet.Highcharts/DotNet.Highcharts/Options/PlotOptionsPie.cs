using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class PlotOptionsPie : PlotOptionsSeries
	{
		/// <summary>
		/// The color of the border surronding each slice. Defaults to "#FFFFFF"
		/// </summary>
		public Color? BorderColor { get; set; }

		/// <summary>
		/// The width of the border surronding each slice. Defaults to 1
		/// </summary>
		public Number? BorderWidth { get; set; }

		/// <summary>
		/// The center of the pie chart relative to the plot area. Can be percentages
		/// or pixel values. Defaults to ['50%', '50%']
		/// </summary>
		public string[] Center { get; set; }

		/// <summary>
		/// The size of the inner diameter for the pie. A size greater than 0
		/// renders a donut chart. Can be a percentage
		/// or pixel value. Percentages are relative to the size of the plot area.
		/// Pixel values are given as integers. Defaults to 0
		/// </summary>
		public string InnerSize { get; set; }

		/// <summary>
		/// Whether to display this particular series or series type in the legend. Since 2.1,
		/// pies are not shown in the legend by default. Defaults to false
		/// </summary>
		public bool? ShowInLegend { get; set; }

		/// <summary>
		/// The diameter of the pie relative to the plot area. Can be a percentage
		/// or pixel value. Pixel values are given as integers. Defaults to "75%"
		/// </summary>
		public string Size { get; set; }

		/// <summary>
		/// If a point is sliced, moved out from the center, how many pixels should 
		/// it be moved? Defaults to 10
		/// </summary>
		public Number? SlicedOffset { get; set; }

	}

}