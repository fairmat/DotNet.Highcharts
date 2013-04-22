using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class PlotOptionsPieStatesHover : PlotOptionsSeriesStatesHover
	{
		/// <summary>
		/// How much to brighten the point on interaction. Requires the main color to be defined in hex or rgb(a) format. Defaults to .1
		/// </summary>
		public Number? Brightness { get; set; }

	}

}