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
		/// When using multiple axis, the ticks of two or more opposite axes will  automatically be aligned by adding ticks to the axis or axes with the least ticks. This can be prevented by setting <code>alignTicks</code> to false. If the grid lines look messy, it's a good idea to hide them for the secondary axis by setting <code>gridLineWidth</code> to 0.
		/// Default: true
		/// </summary>
		public bool? AlignTicks { get; set; }

		/// <summary>
		/// <p>Set the overall animation for all chart updating. Animation can be disabled throughout the chart by setting it to false here. It can be overridden for each individual API method as a function parameter. The only animation not affected by this option is the  initial series animation, see <a class='internal' href='#plotOptions.series.animation'>plotOptions.series.animation</a>.</p>  <p>The animation can either be set as a boolean or a configuration object. If <code>true</code>, it will use the 'swing' jQuery easing and a duration of 500 ms. If used as a configuration object, the following properties are supported:  </p><dl> <dt>duration</dt> <dd>The duration of the animation in milliseconds.</dd>  <dt>easing</dt> <dd>When using jQuery as the general framework, the easing can be set to <code>linear</code> or <code>swing</code>. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See <a href='http://api.jquery.com/animate/'>the jQuery docs</a>. When using  MooTools as the general framework, use the property name <code>transition</code> instead  of <code>easing</code>.</dd> </dl>.
		/// Default: true
		/// </summary>
		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public Animation Animation { get; set; }

		/// <summary>
		/// The background color or gradient for the outer chart area.
		/// Default: #FFFFFF
		/// </summary>
		[JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
		public BackColorOrGradient BackgroundColor { get; set; }

		/// <summary>
		/// The color of the outer chart border. The border is painted using vector graphic  techniques to allow rounded corners.
		/// Default: #4572A7
		/// </summary>
		public Color? BorderColor { get; set; }

		/// <summary>
		/// The corner radius of the outer chart border. In export, the radius defaults to 0.
		/// Default: 5
		/// </summary>
		public Number? BorderRadius { get; set; }

		/// <summary>
		/// The pixel width of the outer chart border. The border is painted using vector graphic  techniques to allow rounded corners.
		/// Default: 0
		/// </summary>
		public Number? BorderWidth { get; set; }

		/// <summary>
		/// A CSS class name to apply to the charts container <code>div</code>, allowing unique CSS styling for each chart.
		/// </summary>
		public string ClassName { get; set; }

		/// <summary>
		/// Alias of <code>type</code>.
		/// Default: line
		/// </summary>
		public ChartTypes? DefaultSeriesType { get; set; }

		/// <summary>
		/// Event listeners for the chart.
		/// </summary>
		public ChartEvents Events { get; set; }

		/// <summary>
		/// An explicit height for the chart. By default the height is calculated from the offset height of the containing element, or 400 pixels if the containing element's height is 0.
		/// </summary>
		public Number? Height { get; set; }

		/// <summary>
		/// If true, the axes will scale to the remaining visible series once one series is hidden. If false, hiding and showing a series will not affect the axes or the other series. For stacks, once one series within the stack is hidden, the rest of the stack will close in around it even if the axis is not affected.
		/// Default: true
		/// </summary>
		public bool? IgnoreHiddenSeries { get; set; }

		/// <summary>
		/// Whether to invert the axes so that the x axis is vertical and y axis is horizontal. When true, the x axis is reversed by default. If a bar series is present in the chart, it will be inverted automatically.
		/// Default: false
		/// </summary>
		public bool? Inverted { get; set; }

		/// <summary>
		/// <p>The margin between the outer edge of the chart and the plot area. The numbers in the array designate top, right, bottom and left respectively. Use the options <code>marginTop</code>, <code>marginRight</code>, <code>marginBottom</code> and <code>marginLeft</code> for shorthand setting of one option.</p> <p>Since version 2.1, the margin is 0 by default. The actual space is dynamically calculated  from the offset of axis labels, axis title, title, subtitle and legend in addition to the <code>spacingTop</code>, <code>spacingRight</code>, <code>spacingBottom</code> and <code>spacingLeft</code> options.</p> Defaults to <code>[null]</code>.
		/// </summary>
		public int[] Margin { get; set; }

		/// <summary>
		/// The margin between the bottom outer edge of the chart and the plot area. Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also <code>spacingBottom</code>.
		/// </summary>
		public Number? MarginBottom { get; set; }

		/// <summary>
		/// The margin between the left outer edge of the chart and the plot area. Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also <code>spacingLeft</code>.
		/// </summary>
		public Number? MarginLeft { get; set; }

		/// <summary>
		/// The margin between the right outer edge of the chart and the plot area. Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also <code>spacingRight</code>.
		/// </summary>
		public Number? MarginRight { get; set; }

		/// <summary>
		/// The margin between the top outer edge of the chart and the plot area. Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also <code>spacingTop</code>.
		/// </summary>
		public Number? MarginTop { get; set; }

		/// <summary>
		/// Equivalent to <a href='#chart.zoomType'>zoomType</a>, but for multitouch gestures only. By default, the <code>pinchType</code> is the same as the <code>zoomType</code> setting. However, pinching can be enabled separately in some cases, for example in stock charts where a mouse drag pans the chart, while pinching is enabled.
		/// Default: null
		/// </summary>
		public string PinchType { get; set; }

		/// <summary>
		/// The background color or gradient for the plot area.
		/// </summary>
		[JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
		public BackColorOrGradient PlotBackgroundColor { get; set; }

		/// <summary>
		/// The URL for an image to use as the plot background. To set an image as the background for the entire chart, set a CSS background image to the container element.
		/// </summary>
		public string PlotBackgroundImage { get; set; }

		/// <summary>
		/// The color of the inner chart or plot area border.
		/// Default: #C0C0C0
		/// </summary>
		public Color? PlotBorderColor { get; set; }

		/// <summary>
		/// The pixel width of the plot area border.
		/// Default: 0
		/// </summary>
		public Number? PlotBorderWidth { get; set; }

		/// <summary>
		/// Whether to apply a drop shadow to the plot area. Requires that plotBackgroundColor be set. Since 2.3 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.
		/// Default: false
		/// </summary>
		public bool? PlotShadow { get; set; }

		/// <summary>
		/// When true, cartesian charts like line, spline, area and column are transformed into the polar coordinate system. Requires <code>highcharts-more.js</code>.
		/// Default: false
		/// </summary>
		public bool? Polar { get; set; }

		/// <summary>
		/// Whether to reflow the chart to fit the width of the container div on resizing the window.
		/// Default: true
		/// </summary>
		public bool? Reflow { get; set; }

		/// <summary>
		/// The HTML element where the chart will be rendered. If it is a string, the element by that id is used. The HTML element can also be passed by direct reference.
		/// </summary>
		// TODO: renderTo for object is not implemented. Just for string when the name of the chart is specified.

		/// <summary>
		/// The button that appears after a selection zoom, allowing the user to reset zoom.
		/// </summary>
		public ChartResetZoomButton ResetZoomButton { get; set; }

		/// <summary>
		/// The background color of the marker square when selecting (zooming in on) an area of the chart.
		/// Default: rgba(69,114,167,0.25)
		/// </summary>
		public Color? SelectionMarkerFill { get; set; }

		/// <summary>
		/// Whether to apply a drop shadow to the outer chart area. Requires that  backgroundColor be set. Since 2.3 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.
		/// Default: false
		/// </summary>
		public bool? Shadow { get; set; }

		/// <summary>
		/// Whether to show the axes initially. This only applies to empty charts where series are added dynamically, as axes are automatically added to cartesian series.
		/// Default: false
		/// </summary>
		public bool? ShowAxes { get; set; }

		/// <summary>
		/// <p>The space between the bottom edge of the chart and the content (plot area, axis title and labels, title, subtitle or  legend in top position).</p> .
		/// Default: 15
		/// </summary>
		public Number? SpacingBottom { get; set; }

		/// <summary>
		/// <p>The space between the left edge of the chart and the content (plot area, axis title and labels, title, subtitle or  legend in top position).</p> .
		/// Default: 10
		/// </summary>
		public Number? SpacingLeft { get; set; }

		/// <summary>
		/// <p>The space between the right edge of the chart and the content (plot area, axis title and labels, title, subtitle or  legend in top position).</p> .
		/// Default: 10
		/// </summary>
		public Number? SpacingRight { get; set; }

		/// <summary>
		/// <p>The space between the top edge of the chart and the content (plot area, axis title and labels, title, subtitle or  legend in top position).</p> .
		/// Default: 10
		/// </summary>
		public Number? SpacingTop { get; set; }

		/// <summary>
		/// Additional CSS styles to apply inline to the container <code>div</code>. Note that since the default font styles are applied in the renderer, it is ignorant of the individual chart  options and must be set globally. Defaults to:<pre>style: { fontFamily: ''Lucida Grande', 'Lucida Sans Unicode', Verdana, Arial, Helvetica, sans-serif', // default font fontSize: '12px'}</pre>
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string Style { get; set; }

		/// <summary>
		/// The default series type for the chart. Can be one of line, spline, area, areaspline,  column, bar, pie and scatter. From version 2.3, <code>arearange</code>, <code>areasplinerange</code> and <code>columnrange</code> are supported with the highcharts-more.js component.
		/// Default: line
		/// </summary>
		public ChartTypes? Type { get; set; }

		/// <summary>
		/// An explicit width for the chart. By default the width is calculated from the offset width of the containing element.
		/// </summary>
		public Number? Width { get; set; }

		/// <summary>
		/// Decides in what dimentions the user can zoom by dragging the mouse. Can  be one of <code>x</code>, <code>y</code> or <code>xy</code>.
		/// </summary>
		public ZoomTypes? ZoomType { get; set; }

	}

}