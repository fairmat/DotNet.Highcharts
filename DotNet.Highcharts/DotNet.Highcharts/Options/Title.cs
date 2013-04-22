using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// The chart's main title.
	/// </summary>
	public class Title
	{
		/// <summary>
		/// The horizontal alignment of the title. Can be one of "left", "center" and "right". Defaults to "center"
		/// </summary>
		public HorizontalAligns? Align { get; set; }

		/// <summary>
		/// When the title is floating, the plot area will not move to make space for it. Defaults to false
		/// </summary>
		public bool? Floating { get; set; }

		/// <summary>
		/// The margin between the title and the plot area, or if a subtitle is present, the
		/// margin between the subtitle and the plot area. Defaults to 15
		/// </summary>
		public Number? Margin { get; set; }

		/// <summary>
		/// The title of the chart. To disable the title, set the text to null. Defaults to "Chart title"
		/// </summary>
		public string Text { get; set; }

		/// <summary>
		/// CSS styles for the title. Use this for font styling, but use align,
		/// x and yfor text alignment. Defaults to:
		/// {
		/// color: '#3E576F',
		/// fontSize: '16px'
		/// }
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string Style { get; set; }

		/// <summary>
		/// The vertical alignment of the title. Can be one of "top", "middle" and "bottom". Defaults to "top"
		/// </summary>
		public VerticalAligns? VerticalAlign { get; set; }

		/// <summary>
		/// The x position of the title relative to the alignment within chart.spacingLeft and chart.spacingRight. Defaults to 0
		/// </summary>
		public Number? X { get; set; }

		/// <summary>
		/// The y position of the title relative to the alignment within chart.spacingTop and chart.spacingBottom. Defaults to 15
		/// </summary>
		public Number? Y { get; set; }

	}

}