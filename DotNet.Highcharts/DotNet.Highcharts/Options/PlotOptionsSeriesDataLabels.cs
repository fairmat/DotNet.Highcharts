using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class PlotOptionsSeriesDataLabels : XAxisLabels
	{
		/// <summary>
		/// The alignment of the data label compared to the point. Can be 
		/// one of "left", "center" or "right". Defaults to "center"
		/// </summary>
		public HorizontalAligns? Align { get; set; }

		/// <summary>
		/// The background color or gradient for the data label. Defaults to undefined
		/// </summary>
		public Color? BackgroundColor { get; set; }

		/// <summary>
		/// The border color for the data label. Defaults to undefined
		/// </summary>
		public Color? BorderColor { get; set; }

		/// <summary>
		/// The border radius in pixels for the data label. Defaults to 0
		/// </summary>
		public Number? BorderRadius { get; set; }

		/// <summary>
		/// The border width in pixels for the data label. Defaults to 0
		/// </summary>
		public Number? BorderWidth { get; set; }

		/// <summary>
		/// The text color for the data labels. Defaults to null
		/// </summary>
		public Color? Color { get; set; }

		/// <summary>
		/// Enable or disable the data labels. Defaults to false
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// Callback JavaScript function to format the data label. Available data are:
		/// 			
		/// 	
		/// 		this.percentage
		/// 		Stacked series and pies only. The point's percentage of the total.
		/// 	
		/// 	
		/// 		this.point
		/// 		The point object. The point name, if defined, is available 
		/// through this.point.name.
		/// 	
		/// 	
		/// 		this.series:
		/// 		The series object. The series name is available 
		/// through this.series.name.
		/// 	
		/// 	
		/// 		this.total
		/// 		Stacked series only. The total value at this point's x value.
		/// 					
		/// 	
		/// 		this.x:
		/// 		The y value.
		/// 	
		/// 	
		/// 		this.y:
		/// 		The y value.
		/// 	
		/// 
		/// Default value:
		/// formatter: function() {
		/// return this.y;
		/// }
		/// </summary>
		[JsonFormatter("{0}")]
		public string Formatter { get; set; }

		/// <summary>
		/// When either the borderWidth or the backgroundColor is set, this
		/// is the padding within the box. Defaults to 2
		/// </summary>
		public Number? Padding { get; set; }

		/// <summary>
		/// Text rotation in degrees. Defaults to 0
		/// </summary>
		public Number? Rotation { get; set; }

		/// <summary>
		/// The shadow of the box. Works best with borderWidth or backgroundColor Defaults to false
		/// </summary>
		public bool? Shadow { get; set; }

		/// <summary>
		/// Styles for the label.
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string Style { get; set; }

		/// <summary>
		/// The x position offset of the label relative to the point. Defaults to 0
		/// </summary>
		public Number? X { get; set; }

		/// <summary>
		/// The y position offset of the label relative to the point. Defaults to -6
		/// </summary>
		public Number? Y { get; set; }

	}

}