using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class YAxisLabels : XAxisLabels
	{
		/// <summary>
		/// What part of the string the given position is anchored to. 
		/// Can be one of "left", "center" or "right". Defaults to "right"
		/// </summary>
		public HorizontalAligns? Align { get; set; }

		/// <summary>
		/// The x position offset of the label relative to the tick position on the axis. Defaults to -8
		/// </summary>
		public Number? X { get; set; }

		/// <summary>
		/// The y position offset of the label relative to the tick position on the axis. Defaults to 3
		/// </summary>
		public Number? Y { get; set; }

	}

}