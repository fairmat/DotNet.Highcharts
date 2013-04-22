using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class PlotOptionsLine : PlotOptionsSeries
	{
		/// <summary>
		/// Whether to apply steps to the line. Defaults to false
		/// </summary>
		public bool? Step { get; set; }

	}

}