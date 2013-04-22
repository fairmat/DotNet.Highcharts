using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	/// <summary>
	/// The button that appears after a selection zoom, allowing the user to reset zoom.
	/// </summary>
	public class ChartResetZoomButton
	{
		/// <summary>
		/// The position of the button.
		/// </summary>
		public Position Position { get; set; }

		/// <summary>
		/// What frame the button should be placed related to. Can be either "plot" or "chart". Defaults to "plot"
		/// </summary>
		public RelativeTo? RelativeTo { get; set; }

		/// <summary>
		/// A collection of attributes for the button. The object takes SVG attributes like 
		/// fill, stroke, stroke-width or r,
		/// the border radius. The theme also supports style,
		/// a collection of CSS properties for the text. Equivalent attributes for the hover state
		/// are given in theme.states.hover.
		/// </summary>
		public Theme Theme { get; set; }

	}

}