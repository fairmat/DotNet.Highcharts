using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// A collection of options for buttons appearing in the exporting module.
	/// </summary>
	public class NavigationButtonOptions
	{
		/// <summary>
		/// Alignment for the buttons. Defaults to "right"
		/// </summary>
		public HorizontalAligns? Align { get; set; }

		/// <summary>
		/// Background color or gradient for the buttons. Defaults to 
		/// backgroundColor: {
		/// linearGradient: [0, 0, 0, 20],
		/// stops: [
		/// [0.4, '#F7F7F7'],
		/// [0.6, '#E3E3E3']
		/// ]
		/// }
		/// </summary>
		public BackColorOrGradient BackgroundColor { get; set; }

		/// <summary>
		/// The border color of the buttons Defaults to "#B0B0B0"
		/// </summary>
		public Color? BorderColor { get; set; }

		/// <summary>
		/// The border corner radius of the buttons Defaults to 3
		/// </summary>
		public Number? BorderRadius { get; set; }

		/// <summary>
		/// The border width of the buttons Defaults to 1
		/// </summary>
		public Number? BorderWidth { get; set; }

		/// <summary>
		/// Whether to enable buttons Defaults to true
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// Pixel height of the buttons Defaults to 20
		/// </summary>
		public Number? Height { get; set; }

		/// <summary>
		/// Color of the button border on hover Defaults to #909090
		/// </summary>
		public Color? HoverBorderColor { get; set; }

		/// <summary>
		/// Fill color for the symbol within the button on hover Defaults to #81A7CF
		/// </summary>
		public Color? HoverSymbolFill { get; set; }

		/// <summary>
		/// Stroke (line) color for the symbol within the button on hover Defaults to #4572A5
		/// </summary>
		public Color? HoverSymbolStroke { get; set; }

		/// <summary>
		/// Fill color for the symbol within the button Defaults to #E0E0E0
		/// </summary>
		public Color? SymbolFill { get; set; }

		/// <summary>
		/// The pixel size of the symbol on the button Defaults to 12
		/// </summary>
		public Number? SymbolSize { get; set; }

		/// <summary>
		/// The color of the symbol's stroke or line Defaults to "#A0A0A0"
		/// </summary>
		public Color? SymbolStroke { get; set; }

		/// <summary>
		/// The pixel stroke width of the symbol on the button Defaults to 1
		/// </summary>
		public Number? SymbolStrokeWidth { get; set; }

		/// <summary>
		/// The x position of the center of the symbol inside the button. Defaults to 11.5
		/// </summary>
		public Number? SymbolX { get; set; }

		/// <summary>
		/// The y position of the center of the symbol inside the button. Defaults to 10.5
		/// </summary>
		public Number? SymbolY { get; set; }

		/// <summary>
		/// The vertical alignment of the buttons. Can be one of "top", "middle" or
		/// "bottom". Defaults to "top"
		/// </summary>
		public VerticalAligns? VerticalAlign { get; set; }

		/// <summary>
		/// The pixel width of the button Defaults to 24
		/// </summary>
		public Number? Width { get; set; }

		/// <summary>
		/// The vertical offset of the button's position relative to its verticalAlign. Defaults to 10
		/// </summary>
		public Number? Y { get; set; }

	}

}