using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class PlotOptionsLineMarkerStates
	{
		public PlotOptionsLineMarkerStatesHover Hover { get; set; }

		/// <summary>
		/// The appearance of the point marker when selected. In order to allow a point to be  selected, set the <code>series.allowPointSelect</code> option to true.
		/// </summary>
		public PlotOptionsLineMarkerStatesSelect Select { get; set; }

	}

}