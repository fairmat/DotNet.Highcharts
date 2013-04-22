using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// The plotOptions is a wrapper object for config objects for each series type.
	/// The config objects for each series can also be overridden for each series 
	/// item as given in the series array.
	/// Configuration options for the series are given in three levels. Options
	/// for all series in a chart are given in the plotOptions.series object. Then options for all series
	/// of a specific type are given in the plotOptions of that type, for example plotOptions.line.
	/// Next, options for one single series are given in the 
	/// series array.
	/// </summary>
	public class PlotOptions
	{
		/// <summary>
		/// Area plot options
		/// </summary>
		public PlotOptionsArea Area { get; set; }

		/// <summary>
		/// Areaspline plot options
		/// </summary>
		public PlotOptionsAreaspline Areaspline { get; set; }

		/// <summary>
		/// Bar chart options
		/// </summary>
		public PlotOptionsBar Bar { get; set; }

		/// <summary>
		/// Column chart options
		/// </summary>
		public PlotOptionsColumn Column { get; set; }

		/// <summary>
		/// Line chart options
		/// </summary>
		public PlotOptionsLine Line { get; set; }

		/// <summary>
		/// Pie chart options
		/// </summary>
		public PlotOptionsPie Pie { get; set; }

		/// <summary>
		/// General options for all series regardless of type.
		/// </summary>
		public PlotOptionsSeries Series { get; set; }

		/// <summary>
		/// Scatter chart options
		/// </summary>
		public PlotOptionsScatter Scatter { get; set; }

		/// <summary>
		/// Spline chart options
		/// </summary>
		public PlotOptionsSpline Spline { get; set; }

	}

}