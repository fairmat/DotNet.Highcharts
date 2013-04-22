using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// The stack labels show the total value for each bar in a stacked column or bar chart. The label will be placed on top of
	/// positive columns and below negative columns. In case of an inverted column chart or a bar chart the label is placed to 
	/// the right of positive bars and to the left of negative bars.
	/// </summary>
	public class YAxisStackLabels
	{
		/// <summary>
		/// Defines the horizontal alignment of the stack total label. 
		/// Can be one of "left", "center" or "right".
		/// The default value is calculated at runtime and depends on orientation and whether 
		/// the stack is positive or negative.
		/// </summary>
		public HorizontalAligns? Align { get; set; }

		/// <summary>
		/// The text alignment for the label. While align determines
		/// where the texts anchor point is placed with regards to the stack, textAlign determines
		/// how the text is aligned against its anchor point. Possible values are
		/// "left", "center" and "right". The default value is calculated
		/// at runtime and depends on orientation and whether the stack is positive or negative.
		/// </summary>
		public HorizontalAligns? TextAlign { get; set; }

		/// <summary>
		/// Defines the vertical alignment of the stack total label.
		/// Can be one of "top",
		/// "middle" or "bottom".
		/// The default value is calculated at runtime and depends on orientation and whether 
		/// the stack is positive or negative.
		/// </summary>
		public VerticalAligns? VerticalAlign { get; set; }

		/// <summary>
		/// Enable or disable the stack total labels. Defaults to false
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// Callback JavaScript function to format the label. The value is 
		/// given by this.total. Defaults to: 
		/// function() {
		/// return this.total;
		/// }
		/// </summary>
		[JsonFormatter("{0}")]
		public string Formatter { get; set; }

		/// <summary>
		/// CSS styles for the label. Defaults to:
		/// style: {
		/// color: '#666',
		/// 'font-size': '11px',
		/// 'line-height': '14px'
		/// }
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string Style { get; set; }

		/// <summary>
		/// Rotation of the labels in degrees. Defaults to 0
		/// </summary>
		public Number? Rotation { get; set; }

		/// <summary>
		/// The x position offset of the label relative to the left of the stacked bar. The default value is
		/// calculated at runtime and depends on orientation and whether the stack is positive or negative.
		/// </summary>
		public Number? X { get; set; }

		/// <summary>
		/// The y position offset of the label relative to the tick position
		/// on the axis. The default value is calculated at runtime and depends on orientation and whether 
		/// the stack is positive or negative.
		/// </summary>
		public Number? Y { get; set; }

	}

}