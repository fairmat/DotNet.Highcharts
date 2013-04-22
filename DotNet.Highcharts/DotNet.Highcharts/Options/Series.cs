using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// The actual series to append to the chart. In addition to 
	/// the members listed below, any member of the plotOptions for that specific
	/// type of plot can be added to a series individually. For example, even though a general
	/// lineWidth is specified in plotOptions.series, an individual
	/// lineWidth can be specified for each series.
	/// </summary>
	public class Series
	{
		/// <summary>
		/// An array of data points for the series. The points can be given in three ways:
		/// 
		/// 	A list of numerical values. In this case, the numberical values will 
		/// 	be interpreted and y values, and x values will be automatically calculated,
		/// 	either starting at 0 and incrementing by 1, or from pointStart 
		/// 	and pointInterval given in the plotOptions. If the axis is
		/// 	has categories, these will be used. Example:
		/// data: [0, 5, 3, 5]
		/// 	
		/// 	A list of arrays with two values. In this case, the first value is the
		/// 	x value and the second is the y value. If the first value is a string, it is
		/// 	applied as the name of the point, and the x value is incremented following
		/// 	the above rules. Example:
		/// data: [[5, 2], [6, 3], [8, 2]]
		/// 	A list of object with named values. In this case the objects are
		/// 	point configuration objects as seen under 
		/// 	options.point. Example:
		/// data: [{
		/// name: 'Point 1',
		/// color: '#00FF00',
		/// y: 0
		/// }, {
		/// name: 'Point 2',
		/// color: '#FF00FF',
		/// y: 5
		/// }] Defaults to ""
		/// </summary>
		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public Data Data { get; set; }

		[Obsolete("This method is deprecated as of version 2.0. Instead, use options preprocessing as described in the  how-to, section #3.")]
		[JsonFormatter("{0}")]
		public string DataParser { get; set; }

		[Obsolete("This method is deprecated as of version 2.0. Instead, load the data using jQuery.ajax and use options preprocessing as described in the  how-to, section #3.")]
		public string DataURL { get; set; }

		/// <summary>
		/// The sequential index of the series in the legend.
		/// 
		/// 
		/// 	Legend in opposite order Defaults to undefined
		/// </summary>
		public Number? LegendIndex { get; set; }

		/// <summary>
		/// The name of the series as shown in the legend, tooltip etc. Defaults to ""
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// This option allows grouping series in a stacked chart. The stack option can be a string 
		/// or a number or anything else, as long as the grouped series' stack options match each other. Defaults to null
		/// </summary>
		public string Stack { get; set; }

		/// <summary>
		/// The type of series. Can be one of area, areaspline,
		/// bar, column, line, pie,
		/// scatter or spline. Defaults to "line"
		/// </summary>
		public ChartTypes? Type { get; set; }

		/// <summary>
		/// When using dual or multiple x axes, this number defines which xAxis the particular
		/// series is connected to. It refers to the index of the axis in the xAxis array, with 
		/// 0 being the first. Defaults to 0
		/// </summary>
		public Number? XAxis { get; set; }

		/// <summary>
		/// When using dual or multiple y axes, this number defines which yAxis the particular
		/// series is connected to. It refers to the index of the axis in the yAxis array, with 
		/// 0 being the first. Defaults to 0
		/// </summary>
		public Number? YAxis { get; set; }

		public Color? Color { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsArea PlotOptionsArea { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsAreaspline PlotOptionsAreaspline { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsBar PlotOptionsBar { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsColumn PlotOptionsColumn { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsLine PlotOptionsLine { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsSpline PlotOptionsSpline { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsPie PlotOptionsPie { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsSeries PlotOptionsSeries { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsScatter PlotOptionsScatter { get; set; }
	}

}