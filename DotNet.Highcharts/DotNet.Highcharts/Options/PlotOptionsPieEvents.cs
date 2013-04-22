using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class PlotOptionsPieEvents : PlotOptionsSeriesEvents
	{
		/// <summary>
		/// Not applicable to pies, as the legend item is per point. See point.events.
		/// </summary>
		[JsonFormatter("{0}")]
		public string LegendItemClick { get; set; }

	}

}