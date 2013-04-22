using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class PlotOptionsPiePointEvents : PlotOptionsSeriesPointEvents
	{
		/// <summary>
		/// Fires when the legend item belonging to the pie point (slice) is clicked. 
		/// The this keyword refers to the 
		/// point itself. One parameter, event, is passed to the function.
		/// This contains common event information based on jQuery or MooTools depending on 
		/// which library is used as the base for Highcharts. The default action is to toggle
		/// the visibility of the point. This can be prevented by calling 
		/// event.preventDefault().
		/// </summary>
		[JsonFormatter("{0}")]
		public string LegendItemClick { get; set; }

	}

}