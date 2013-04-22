using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class PlotOptionsColumn : PlotOptionsSeries
	{
		/// <summary>
		/// The color of the border surronding each column or bar. Defaults to "#FFFFFF"
		/// </summary>
		public Color? BorderColor { get; set; }

		/// <summary>
		/// The corner radius of the border surronding each column or bar. Defaults to 0
		/// </summary>
		public Number? BorderRadius { get; set; }

		/// <summary>
		/// The width of the border surronding each column or bar. Defaults to 1
		/// </summary>
		public Number? BorderWidth { get; set; }

		/// <summary>
		/// When using automatic point colors pulled from the options.colors
		/// collection, this option determines whether the chart should receive 
		/// one color per series or one color per point. Defaults to false
		/// </summary>
		public bool? ColorByPoint { get; set; }

		/// <summary>
		/// When the series contains less points than the crop threshold, all points are drawn, 
		/// event if the points fall outside the visible plot area at the current zoom. The advantage
		/// of drawing all points (including markers and columns), is that animation is performed on
		/// updates. On the other hand, when the series contains more points than the crop threshold,
		/// the series data is cropped to only contain points that fall within the plot area. The advantage
		/// of cropping away invisible points is to increase performance on large series. Defaults to 50
		/// </summary>
		public Number? CropThreshold { get; set; }

		/// <summary>
		/// Padding between each value groups, in x axis units. Defaults to 0.2
		/// </summary>
		public Number? GroupPadding { get; set; }

		/// <summary>
		/// The minimal height for a column or width for a bar. By default, 0 values
		/// are not shown. To visualize a 0 (or close to zero) point, set the minimal point length to a 
		/// pixel value like 3. In stacked column charts, minPointLength might not be respected for tightly
		/// packed values. Defaults to 0
		/// </summary>
		public Number? MinPointLength { get; set; }

		/// <summary>
		/// Padding between each column or bar, in x axis units. Defaults to 0.1
		/// </summary>
		public Number? PointPadding { get; set; }

		/// <summary>
		/// A pixel value specifying a fixed width for each column or bar. When null,
		/// the width is calculated from the pointPadding and groupPadding. Defaults to null
		/// </summary>
		public Number? PointWidth { get; set; }

	}

}