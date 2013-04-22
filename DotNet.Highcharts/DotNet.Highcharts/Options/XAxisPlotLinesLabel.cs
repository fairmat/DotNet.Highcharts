using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// Text labels for the plot bands
	/// </summary>
	public class XAxisPlotLinesLabel
	{
		/// <summary>
		/// Horizontal alignment of the label. Can be one of "left", "center" or "right". Defaults to "center"
		/// </summary>
		public HorizontalAligns? Align { get; set; }

		/// <summary>
		/// Vertical alignment of the label relative to the plot band. Can be one of "top", "middle" or "bottom". Defaults to "top"
		/// </summary>
		public VerticalAligns? VerticalAlign { get; set; }

		/// <summary>
		/// Rotation of the text label in degrees. Defaults to 0 for horizontal plot lines and 90 for vertical lines.
		/// </summary>
		public Number? Rotation { get; set; }

		/// <summary>
		/// CSS styles for the text label.
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string Style { get; set; }

		/// <summary>
		/// The text alignment for the label. While align determines
		/// where the texts anchor point is placed within the plot band, textAlign determines
		/// how the text is aligned against its anchor point. Possible values are
		/// "left", "center" and "right". Defaults to the same as
		/// the align option.
		/// </summary>
		public HorizontalAligns? TextAlign { get; set; }

		/// <summary>
		/// Horizontal position relative the alignment. Default varies by orientation.
		/// </summary>
		public Number? X { get; set; }

		/// <summary>
		/// Vertical position of the text baseline relative to the alignment. Default varies by orientation.
		/// </summary>
		public Number? Y { get; set; }

	}

}