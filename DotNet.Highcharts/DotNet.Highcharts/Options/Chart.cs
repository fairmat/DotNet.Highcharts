using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// Options regarding the chart area and plot area as well as general chart options.
	/// </summary>
	public class Chart
	{
		/// <summary>
		/// When using multiple axis, the ticks of two or more opposite axes will 
		/// automatically be aligned by adding ticks to the axis or axes with the least
		/// ticks. This can be prevented by setting alignTicks to false.
		/// If the grid lines look messy, it's a good idea to hide them for the
		/// secondary axis by setting gridLineWidth to 0. Defaults to true
		/// </summary>
		public bool? AlignTicks { get; set; }

		/// <summary>
		/// Set the overall animation for all chart updating. Animation can be disabled throughout
		/// the chart by setting it to false here. It can be overridden for each individual
		/// API method as a function parameter. The only animation not affected by this option is the 
		/// initial series animation, see plotOptions.series
		/// => animation.
		/// 
		/// The animation can either be set as a boolean or a configuration object. If true,
		/// it will use the 'swing' jQuery easing and a duration of 500 ms. If used as a configuration object,
		/// the following properties are supported: 
		/// 
		/// 	duration
		/// 	The duration of the animation in milliseconds.
		/// 	
		/// 	easing
		/// 	When using jQuery as the general framework, the easing can be set to linear or
		/// 	swing. More easing functions are available with the use of jQuery plug-ins, most notably
		/// 	the jQuery UI suite. See the jQuery docs. When using 
		/// 	MooTools as the general framework, use the property name transition instead 
		/// 	of easing. Defaults to true
		/// </summary>
		public Animation Animation { get; set; }

		/// <summary>
		/// The background color or gradient for the outer chart area. Defaults to "#FFFFFF"
		/// </summary>
		[JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
		public BackColorOrGradient BackgroundColor { get; set; }

		/// <summary>
		/// The color of the outer chart border. The border is painted using vector graphic 
		/// techniques to allow rounded corners. Defaults to "#4572A7"
		/// </summary>
		public Color? BorderColor { get; set; }

		/// <summary>
		/// The corner radius of the outer chart border. Defaults to 5
		/// </summary>
		public Number? BorderRadius { get; set; }

		/// <summary>
		/// The pixel width of the outer chart border. The border is painted using vector graphic 
		/// techniques to allow rounded corners. Defaults to 0
		/// </summary>
		public Number? BorderWidth { get; set; }

		/// <summary>
		/// A CSS class name to apply to the charts container div, allowing unique CSS styling
		/// for each chart. Defaults to ""
		/// </summary>
		public string ClassName { get; set; }

		/// <summary>
		/// Alias of type.
		/// </summary>
		public ChartTypes? DefaultSeriesType { get; set; }

		/// <summary>
		/// Event listeners for chart events.
		/// </summary>
		public ChartEvents Events { get; set; }

		/// <summary>
		/// An explicit height for the chart. By default the height is calculated from the offset
		/// height of the containing element. Defaults to null
		/// </summary>
		public Number? Height { get; set; }

		/// <summary>
		/// If true, the axes will scale to the remaining visible series once one series
		/// is hidden. If false, hiding and showing a series will not affect the axes or
		/// the other series. For stacks, once one series within the stack is hidden, the
		/// rest of the stack will close in around it even if the axis is not affected. Defaults to true
		/// </summary>
		public bool? IgnoreHiddenSeries { get; set; }

		/// <summary>
		/// Whether to invert the axes so that the x axis is horizontal and y axis is vertical.
		/// When true, the x axis is reversed by default. If a bar plot is present in the chart,
		/// it will be inverted automatically. Defaults to false
		/// </summary>
		public bool? Inverted { get; set; }

		/// <summary>
		/// The margin between the outer edge of the chart and the plot area. The numbers in
		/// the array designate top, right, bottom and left respectively. Use the options
		/// marginTop, marginRight, marginBottom and
		/// marginLeft for shorthand setting of one option.
		/// Since version 2.1, the margin is 0 by default. The actual space is dynamically calculated 
		/// from the offset of axis labels, axis title, title, subtitle and legend in addition
		/// to the spacingTop, spacingRight, spacingBottom and
		/// spacingLeft options. Defaults to [null]
		/// </summary>
		public int[] Margin { get; set; }

		/// <summary>
		/// The margin between the top outer edge of the chart and the plot area. Use this to set a fixed
		/// pixel value for the margin as opposed to the default dynamic margin. See also spacingTop. Defaults to null
		/// </summary>
		public Number? MarginTop { get; set; }

		/// <summary>
		/// The margin between the right outer edge of the chart and the plot area. Use this to set a fixed
		/// pixel value for the margin as opposed to the default dynamic margin. See also spacingRight. Defaults to 50
		/// </summary>
		public Number? MarginRight { get; set; }

		/// <summary>
		/// The margin between the bottom outer edge of the chart and the plot area. Use this to set a fixed
		/// pixel value for the margin as opposed to the default dynamic margin. See also spacingBottom. Defaults to 70
		/// </summary>
		public Number? MarginBottom { get; set; }

		/// <summary>
		/// The margin between the left outer edge of the chart and the plot area. Use this to set a fixed
		/// pixel value for the margin as opposed to the default dynamic margin. See also spacingLeft. Defaults to 80
		/// </summary>
		public Number? MarginLeft { get; set; }

		/// <summary>
		/// The background color or gradient for the plot area. Defaults to null
		/// </summary>
		[JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
		public BackColorOrGradient PlotBackgroundColor { get; set; }

		/// <summary>
		/// The URL for an image to use as the plot background. To set an image as the background
		/// for the entire chart, set a CSS background image to the container element. Defaults to null
		/// </summary>
		public string PlotBackgroundImage { get; set; }

		/// <summary>
		/// The color of the inner chart or plot area border. Defaults to "#C0C0C0"
		/// </summary>
		public Color? PlotBorderColor { get; set; }

		/// <summary>
		/// The pixel width of the plot area border. Defaults to 0
		/// </summary>
		public Number? PlotBorderWidth { get; set; }

		/// <summary>
		/// Whether to apply a drop shadow to the plot area. Requires that plotBackgroundColor
		/// be set. Defaults to false
		/// </summary>
		public bool? PlotShadow { get; set; }

        /// <summary>
        /// When true, cartesian charts like line, spline, area and column are transformed
        /// into the polar coordinate system. Requires highcharts-more.js.
        /// Defaults to false.
        /// </summary>
        public bool? Polar { get; set; }

		/// <summary>
		/// Whether to reflow the chart to fit the width of the container div on resizing the window. Defaults to true
		/// </summary>
		public bool? Reflow { get; set; }

		/// <summary>
		/// The HTML element where the chart will be rendered. If it is a string, the element by that
		/// id is used. The HTML element can also be passed by direct reference. Defaults to null
		/// </summary>
		// TODO: renderTo for object is not implemented. Just for string when the name of the chart is specified.

		/// <summary>
		/// 
		/// </summary>
		public ChartResetZoomButton ResetZoomButton { get; set; }

		/// <summary>
		/// The background color of the marker square when selecting (zooming in on) an area of the chart. Defaults to rgba(69,114,167,0.25)
		/// </summary>
		public Color? SelectionMarkerFill { get; set; }

		/// <summary>
		/// Whether to apply a drop shadow to the outer chart area. Requires that 
		/// backgroundColor be set. Defaults to false
		/// </summary>
		public bool? Shadow { get; set; }

		/// <summary>
		/// Whether to show the axes initially. This only applies to empty charts where
		/// series are added dynamically,
		/// as axes are automatically added to cartesian series. Defaults to false
		/// </summary>
		public bool? ShowAxes { get; set; }

		/// <summary>
		/// The space between the top edge of the chart and the content (plot area, axis title and labels, title, subtitle or 
		/// legend in top position). Defaults to 10
		/// </summary>
		public Number? SpacingTop { get; set; }

		/// <summary>
		/// The space between the right edge of the chart and the content (plot area, axis title and labels, title, subtitle or 
		/// legend in top position). Defaults to 10
		/// </summary>
		public Number? SpacingRight { get; set; }

		/// <summary>
		/// The space between the bottom edge of the chart and the content (plot area, axis title and labels, title, subtitle or 
		/// legend in top position). Defaults to 15
		/// </summary>
		public Number? SpacingBottom { get; set; }

		/// <summary>
		/// The space between the left edge of the chart and the content (plot area, axis title and labels, title, subtitle or 
		/// legend in top position). Defaults to 10
		/// </summary>
		public Number? SpacingLeft { get; set; }

		/// <summary>
		/// Additional CSS styles to apply inline to the container div. Note that since the default
		/// font styles are applied in the renderer, it is ignorant of the individual chart 
		/// options and must be set globally. Defaults
		/// to:
		/// style: {
		/// fontFamily: '"Lucida Grande", "Lucida Sans Unicode", Verdana, Arial, Helvetica, sans-serif', // default font
		/// fontSize: '12px'
		/// }
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string Style { get; set; }

		/// <summary>
		/// The default series type for the chart. Can be one of line, spline, area, areaspline, 
		/// column, bar, pie and scatter. Defaults to "line"
		/// </summary>
		public ChartTypes? Type { get; set; }

		/// <summary>
		/// An explicit width for the chart. By default the width is calculated from the offset
		/// width of the containing element. Defaults to null
		/// </summary>
		public Number? Width { get; set; }

		/// <summary>
		/// Decides in what dimentions the user can zoom by dragging the mouse. Can 
		/// be one of x, y or xy. Defaults to ""
		/// </summary>
		public ZoomTypes? ZoomType { get; set; }

	}

}