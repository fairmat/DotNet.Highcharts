using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class PlotOptionsSeriesStates
	{
		/// <summary>
		/// Configuration options for the hovered line. Members are 
		/// inherited from the default line configuration, but single members can be overridden.
		/// </summary>
		public PlotOptionsSeriesStatesHover Hover { get; set; }

	}

}