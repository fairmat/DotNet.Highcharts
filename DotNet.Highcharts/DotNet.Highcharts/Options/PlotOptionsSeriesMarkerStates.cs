using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class PlotOptionsSeriesMarkerStates
	{
		/// <summary>
		/// Configuration options for the hovered point marker. Members are 
		/// inherited from the default line configuration, but single members can be overridden.
		/// </summary>
		public PlotOptionsSeriesMarkerStatesHover Hover { get; set; }

		/// <summary>
		/// Configuration options for the selected point marker. Members are 
		/// inherited from the default line configuration, but single members can be overridden.
		/// </summary>
		public PlotOptionsSeriesMarkerStatesSelect Select { get; set; }

	}

}