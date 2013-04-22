using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// Options for the tooltip that appears when the user hovers over a series or point.
	/// </summary>
	public class Tooltip
	{
		/// <summary>
		/// The background color or gradient for the tooltip. Defaults to "rgba(255, 255, 255, .85)"
		/// </summary>
		public BackColorOrGradient BackgroundColor { get; set; }

		/// <summary>
		/// The color of the tooltip border. When null, the border takes the color of the
		/// corresponding series or point. Defaults to "auto"
		/// </summary>
		public Color? BorderColor { get; set; }

		/// <summary>
		/// The radius of the rounded border corners. Defaults to 5
		/// </summary>
		public Number? BorderRadius { get; set; }

		/// <summary>
		/// The pixel width of the tooltip border. Defaults to 2
		/// </summary>
		public Number? BorderWidth { get; set; }

		/// <summary>
		/// Display crosshairs to connect the points with their corresponding axis values. The crosshairs can
		/// be defined as a boolean, an array of booleans or an object.
		/// 
		/// 	Boolean
		/// 	If the crosshairs option is true, a single crosshair relating to the
		/// 	x axis will be shown.
		/// 	
		/// 	Array of booleans
		/// 	In an array of booleans, the first value turns on the x axis crosshair and the second
		/// 	value to the y axis crosshair. Use [true, true] to show complete crosshairs.
		/// 	
		/// 	Array of objects
		/// 	In an array of objects, the first value applies to the x axis crosshair and the second
		/// 	value to the y axis crosshair. For each dimension, a width, color,
		/// 	dashStyle and zIndex can be given. Defaults to null
		/// </summary>
		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public Crosshairs Crosshairs { get; set; }

		/// <summary>
		/// Enable or disable the tooltip. Defaults to true
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// A string to append to the tooltip format. Defaults to false
		/// </summary>
		public string FooterFormat { get; set; }

		/// <summary>
		/// Callback function to format the text of the tooltip. Return false to disable
		/// tooltip for a specific point on series.
		/// A subset of HTML is supported. The HTML of the tooltip is parsed and converted to SVG, 
		/// therefore this isn't a complete HTML renderer. The following tabs are supported: 
		/// &lt;b&gt;, &lt;strong&gt;,
		/// &lt;i&gt;, &lt;em&gt;, &lt;br/&gt;, &lt;span&gt;.
		/// Spans can be styled with a style attribute, but only text-related CSS that is 
		/// shared with SVG is handled.
		/// 
		/// Since version 2.1 the tooltip can be shared between multiple series through 
		/// the shared option. The available data in the formatter differ a bit
		/// depending on whether the tooltip is shared or not. In a shared tooltip, all 
		/// properties except x, which is common for all points, are kept in 
		/// an array, this.points.
		/// 
		/// Available data are:
		/// 
		/// 	this.percentage (not shared) / this.points[i].percentage (shared)
		/// 	Stacked series and pies only. The point's percentage of the total.
		/// 	
		/// 	this.point (not shared) / this.points[i].point (shared)
		/// 	The point object. The point name, if defined, is available 
		/// through this.point.name.
		/// 	
		/// 	this.points
		/// 	In a shared tooltip, this is an array containing all other properties for each point.
		/// 	
		/// 	this.series (not shared) / this.points[i].series (shared)
		/// 	The series object. The series name is available 
		/// through this.series.name.
		/// 
		/// 	this.total (not shared) / this.points[i].total (shared)
		/// 	Stacked series only. The total value at this point's x value.
		/// 	
		/// 	this.x
		/// 	The x value. This property is the same regardless of the tooltip being shared or not.
		/// 	
		/// 	this.y (not shared) / this.points[i].y (shared)
		/// 	The y value.
		/// </summary>
		[JsonFormatter("{0}")]
		public string Formatter { get; set; }

		/// <summary>
		/// The HTML of the point's line in the tooltip. Variables are enclosed by curly brackets. Available variables
		/// are point.x, point.y, series.name and series.color and other properties on the same form. Furthermore, 
		/// point.y can be extended by the tooltip.yPrefix
		/// and tooltip.ySuffix variables. This can also be overridden for each series, which makes it a good hook for displaying
		/// units.
		/// 
		/// Defaults to &lt;span style="color:{series.color}"&gt;{series.name}&lt;/span&gt;: &lt;b&gt;{point.y}&lt;/b&gt;&lt;br/&gt;
		/// </summary>
		public string PointFormat { get; set; }

		/// <summary>
		/// Whether to apply a drop shadow to the tooltip. Defaults to true
		/// </summary>
		public bool? Shadow { get; set; }

		/// <summary>
		/// When the tooltip is shared, the entire plot area will capture mouse movement, and tooltip texts 
		/// for all series will be shown in a single bubble. This is recommended for single series charts
		/// and for iPad optimized sites. Defaults to false
		/// </summary>
		public bool? Shared { get; set; }

		/// <summary>
		/// Proximity snap for graphs or single points. Does not apply to bars, columns
		/// and pie slices. It defaults to 10 for mouse-powered devices and 25 for touch 
		/// devices. Defaults to 10/25
		/// </summary>
		public Number? Snap { get; set; }

		/// <summary>
		/// CSS styles for the tooltip. The tooltip can also be styled through the CSS
		/// class .highcharts-tooltip.
		/// Default value:
		/// style: {
		/// color: '#333333',
		/// fontSize: '9pt',
		/// padding: '5px'
		/// }
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string Style { get; set; }

		/// <summary>
		/// How many decimals to show in each series' y value. This is overridable in each series' tooltip options object.
		/// The default is to preserve all decimals.
		/// </summary>
		public Number? ValueDecimals { get; set; }

		/// <summary>
		/// A string to prepend to each series' y value. Overridable in each series' tooltip options object. Defaults to ""
		/// </summary>
		public string ValuePrefix { get; set; }

		/// <summary>
		/// A string to append to each series' y value. Overridable in each series' tooltip options object. Defaults to ""
		/// </summary>
		public string ValueSuffix { get; set; }

		/// <summary>
		/// The format for the date in the tooltip header if the X axis is a datetime axis.
		/// </summary>
		public string XDateFormat { get; set; }

		/// <summary>
		/// Use HTML to render the contents of the tooltip instead of SVG. Using HTML allows advanced formatting
		/// like tables and images in the tooltip. It is also recommended for rtl languages as it works around
		/// rtl bugs in early Firefox. Defaults to false
		/// </summary>
		public bool? UseHTML { get; set; }

	}

}