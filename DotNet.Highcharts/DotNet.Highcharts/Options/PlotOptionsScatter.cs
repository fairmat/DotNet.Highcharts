using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class PlotOptionsScatter : PlotOptionsSeries
	{
		/// <summary>
		/// The width of the line connecting the data points. Defaults to 0
		/// </summary>
		public Number? LineWidth { get; set; }

	}

}