using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// General options for all series types.
	/// </summary>
	public class PlotOptionsSeries
	{
		/// <summary>
		/// Allow this series' points to be selected by clicking on the markers, bars or pie slices. Defaults to false
		/// </summary>
		public bool? AllowPointSelect { get; set; }

		/// <summary>
		/// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation
		/// can be set as a configuration object. Please note that this option only applies to the initial
		/// animation of the series itself. For other animations, see 
		/// #chart => animation and the animation parameter under the API methods.
		/// The following properties are supported: 
		/// 
		/// 	duration
		/// 	The duration of the animation in milliseconds.
		/// 	
		/// 	easing
		/// 	When using jQuery as the general framework, the easing can be set to linear or
		/// 	swing. More easing functions are available with the use of jQuery plug-ins, most notably
		/// 	the jQuery UI suite. See the jQuery docs. When using 
		/// 	MooToos as the general framework, use the property name transition instead of easing. Defaults to true
		/// </summary>
		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public Animation Animation { get; set; }

		/// <summary>
		/// The main color or the series. In line type series it applies to the line and the point
		/// markers unless otherwise specified. In bar type series it applies to the bars
		/// unless a color is specified per point. The default value is pulled from the 
		/// options.colors array.
		/// </summary>
		public Color? Color { get; set; }

		/// <summary>
		/// Whether to connect a graph line across null points. Defaults to false
		/// </summary>
		public bool? ConnectNulls { get; set; }

		/// <summary>
		/// When the series contains less points than the crop threshold, all points are drawn, 
		/// event if the points fall outside the visible plot area at the current zoom. The advantage
		/// of drawing all points (including markers and columns), is that animation is performed on
		/// updates. On the other hand, when the series contains more points than the crop threshold,
		/// the series data is cropped to only contain points that fall within the plot area. The advantage
		/// of cropping away invisible points is to increase performance on large series. Defaults to 300
		/// </summary>
		public Number? CropThreshold { get; set; }

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attached to 
		/// the series, to signal to the user that the points and lines can be clicked. Defaults to ''
		/// </summary>
		public Cursors? Cursor { get; set; }

		/// <summary>
		/// A name for the dash style to use for the graph. Applies only to series type having a graph,
		/// like line, spline, area and scatter in 
		/// case it has a lineWidth. The value for the dashStyle include:
		///     
		///     	Solid
		///     	ShortDash
		///     	ShortDot
		///     	ShortDashDot
		///     	ShortDashDotDot
		///     	Dot
		///     	Dash
		///     	LongDash
		///     	DashDot
		///     	LongDashDot
		///     	LongDashDotDot Defaults to null
		/// </summary>
		public DashStyles? DashStyle { get; set; }

		/// <summary>
		/// Defines the appearance of the data labels, static labels for each point.
		/// </summary>
		public PlotOptionsSeriesDataLabels DataLabels { get; set; }

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. This includes
		/// point tooltips and click events on graphs and points. For large datasets
		/// it improves performance. Defaults to true
		/// </summary>
		public bool? EnableMouseTracking { get; set; }

		/// <summary>
		/// Event listeners for the series.
		/// </summary>
		public PlotOptionsSeriesEvents Events { get; set; }

		/// <summary>
		/// An id for the series. This can be used after render time to get a pointer
		/// to the series object through chart.get(). Defaults to null
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Pixel with of the graph line. Defaults to 2
		/// </summary>
		public Number? LineWidth { get; set; }

		/// <summary>
		/// Defines the appearance of the point markers.
		/// </summary>
		public PlotOptionsSeriesMarker Marker { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSeriesPoint Point { get; set; }

		/// <summary>
		/// If no x values are given for the points in a series, pointStart defines
		/// on what value to start. For example, if a series contains one yearly value
		/// starting from 1945, set pointStart to 1945. Defaults to 0
		/// </summary>
		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PointStart PointStart { get; set; }

		/// <summary>
		/// If no x values are given for the points in a series, pointInterval defines
		/// the interval of the x values. For example, if a series contains one value
		/// every decade starting from year 0, set pointInterval to 10. Defaults to 1
		/// </summary>
		public Number? PointInterval { get; set; }

		/// <summary>
		/// Whether to select the series initially. If showCheckbox is true,
		/// the checkbox next to the series name will be checked for a selected series. Defaults to false
		/// </summary>
		public bool? Selected { get; set; }

		/// <summary>
		/// Whether to apply a drop shadow to the graph line. Defaults to true
		/// </summary>
		public bool? Shadow { get; set; }

		/// <summary>
		/// If true, a checkbox is displayed
		/// next to the legend item to allow selecting the series. The state of the
		/// checkbox is determined by the selected option. Defaults to false
		/// </summary>
		public bool? ShowCheckbox { get; set; }

		/// <summary>
		/// Whether to display this particular series or series type in the legend. Defaults to true
		/// </summary>
		public bool? ShowInLegend { get; set; }

		/// <summary>
		/// Whether to stack the values of each series on top of each other. Possible values
		/// are null to disable, "normal" to stack by value or "percent". Defaults to null
		/// </summary>
		public Stackings? Stacking { get; set; }

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public PlotOptionsSeriesStates States { get; set; }

		/// <summary>
		/// Sticky tracking of mouse events. When true, the mouseOut event
		/// on a series isn't triggered until the mouse moves over another series, or out
		/// of the plot area. When false, the mouseOut event on a series is
		/// triggered when the mouse leaves the area around the series' graph or markers.
		/// This also implies the tooltip. When stickyTracking is false, the 
		/// tooltip will be hidden when moving the mouse between series. Defaults to true
		/// </summary>
		public bool? StickyTracking { get; set; }

		/// <summary>
		/// A configuration object for the tooltip rendering of each single series. Properties are inherited
		/// from #tooltip. Overridable properties are headerFormat, pointFormat,
		/// valueDecimals, xDateFormat, valuePrefix and valueSuffix. Defaults to {}
		/// </summary>
		public Object Tooltip { get; set; }

		/// <summary>
		/// When a series contains a data array that is longer than this, only one dimensional arrays of numbers,
		/// or two dimensional arrays with x and y values are allowed. Also, only the first
		/// point is tested, and the rest are assumed to be the same format. This saves expensive
		/// data checking and indexing in long series. Defaults to 1000
		/// </summary>
		public Number? TurboThreshold { get; set; }

		/// <summary>
		/// Set the initial visibility of the series. Defaults to true
		/// </summary>
		public bool? Visible { get; set; }

		/// <summary>
		/// Define the z index of the series. Defaults to null
		/// </summary>
		public Number? ZIndex { get; set; }

	}

}