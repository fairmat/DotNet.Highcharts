using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class PlotOptionsBarDataLabels : PlotOptionsColumnDataLabels
	{
		/// <summary>
		/// Alignment of the data label relative to the data point. Defaults to "left"
		/// </summary>
		public HorizontalAligns? Align { get; set; }

		/// <summary>
		/// The x position of the data label relative to the data point. Defaults to 5
		/// </summary>
		public Number? X { get; set; }

	}

}